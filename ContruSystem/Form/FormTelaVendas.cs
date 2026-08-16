using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace ContruSystem
{
    public partial class FormTelaVendas : Form
    {
        private String strConexao;
        private DataTable tabelaItens = new DataTable();
        private int idProdutoSelecionado = 0;
        private int estoqueSelecionado = 0;
        private decimal precoProdutoSelecionado = 0;
        private int linhaItemSelecionado = -1;
        private DateTime dataVendaAtual;

        public FormTelaVendas()
        {
            InitializeComponent();
            strConexao = ConfigurationManager.ConnectionStrings["SistemaVendas"].ConnectionString;
        }

        private void FormTelaVendas_Load(object sender, EventArgs e)
        {
            dataVendaAtual = DateTime.Now;
            txtData.Text = dataVendaAtual.ToString();
            txtCodigoVenda.ReadOnly = true;
            txtEstoqueDisponivel.ReadOnly = true;
            txtPreco.ReadOnly = true;
            txtValTotal.ReadOnly = true;
            txtData.Text = DateTime.Now.ToString();
            dgvPesquisaProdutos.Visible = false;
            CriarTabelaItens();
            CarregarFuncionarios();
            txtValTotal.Text = "0,00";
        }


        private void CriarTabelaItens()
        {
            tabelaItens.Columns.Add("Codigo", typeof(int));
            tabelaItens.Columns.Add("Descricao", typeof(string));
            tabelaItens.Columns.Add("Quantidade", typeof(int));
            tabelaItens.Columns.Add("Preco", typeof(decimal));
            tabelaItens.Columns.Add("Desconto", typeof(decimal));
            tabelaItens.Columns.Add("Total", typeof(decimal));
            dataGridView.DataSource = tabelaItens;
        }



        private void CarregarFuncionarios()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();
                    string sql = "SELECT id_funcionario, nome FROM funcionarios ORDER BY nome";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    cmbFuncionario.DataSource = tabela;
                    cmbFuncionario.DisplayMember = "nome";
                    cmbFuncionario.ValueMember = "id_funcionario";
                    cmbFuncionario.SelectedIndex = -1;
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao carregar funcionários.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesqProduto_TextChanged(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        private void PesquisarProdutos()
        {
            if (txtPesqProduto.Text.Trim() == "")
            {
                dgvPesquisaProdutos.Visible = false;
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();
                    string sql = "SELECT id_produto AS Codigo, descricao AS Descricao, preco AS Preco, estoque AS Estoque FROM produtos WHERE estoque > 0 AND (descricao LIKE @pesquisa OR CAST(id_produto AS CHAR) LIKE @pesquisa) ORDER BY descricao LIMIT 10";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@pesquisa", "%" + txtPesqProduto.Text.Trim() + "%");
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dgvPesquisaProdutos.DataSource = tabela;
                    dgvPesquisaProdutos.Visible = tabela.Rows.Count > 0;
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao pesquisar produtos.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvPesquisaProdutos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idProdutoSelecionado = Convert.ToInt32(dgvPesquisaProdutos.Rows[e.RowIndex].Cells["Codigo"].Value);
                estoqueSelecionado = Convert.ToInt32(dgvPesquisaProdutos.Rows[e.RowIndex].Cells["Estoque"].Value);
                precoProdutoSelecionado = Convert.ToDecimal(dgvPesquisaProdutos.Rows[e.RowIndex].Cells["Preco"].Value);
                txtPesqProduto.Text = dgvPesquisaProdutos.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                txtPreco.Text = precoProdutoSelecionado.ToString("N2");
                txtEstoqueDisponivel.Text = estoqueSelecionado.ToString();
                dgvPesquisaProdutos.Visible = false;
                UDQuantidade.Value = 1;
                UDDesconto.Value = 0;
                UDQuantidade.Focus();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (idProdutoSelecionado == 0)
            {
                MessageBox.Show("Pesquise e selecione um produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesqProduto.Focus();
                return;
            }

            int quantidade = Convert.ToInt32(UDQuantidade.Value);

            if (quantidade > estoqueSelecionado)
            {
                MessageBox.Show("A quantidade informada é maior que o estoque disponível.", "Estoque insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UDQuantidade.Focus();
                return;
            }

            if (ProdutoJaAdicionado(idProdutoSelecionado))
            {
                MessageBox.Show("Este produto já foi adicionado à venda. Se desejar alterar a quantidade, selecione o item e clique em Editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal desconto = UDDesconto.Value;
            decimal totalItem = CalcularTotalItem(precoProdutoSelecionado, quantidade, desconto);

            tabelaItens.Rows.Add(idProdutoSelecionado, txtPesqProduto.Text.Trim(), quantidade, precoProdutoSelecionado, desconto, totalItem);

            AtualizarTotalVenda();
            LimparProduto();

        }
        private bool ProdutoJaAdicionado(int codigoProduto)
        {
            foreach (DataRow linha in tabelaItens.Rows)
            {
                if (Convert.ToInt32(linha["Codigo"]) == codigoProduto)
                {
                    return true;
                }
            }

            return false;
        }

        private decimal CalcularTotalItem(decimal preco, int quantidade, decimal desconto)
        {
            decimal subtotal = preco * quantidade;
            decimal valorDesconto = subtotal * desconto / 100;
            decimal total = subtotal - valorDesconto;
            return total;
        }

        private void AtualizarTotalVenda()
        {
            decimal totalVenda = 0;

            foreach (DataRow linha in tabelaItens.Rows)
            {
                totalVenda += Convert.ToDecimal(linha["Total"]);
            }

            txtValTotal.Text = totalVenda.ToString("N2");
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
            {

            if (e.RowIndex >= 0)
            {
                if (dataGridView.Rows[e.RowIndex].Cells["Codigo"].Value == null ||
            dataGridView.Rows[e.RowIndex].Cells["Codigo"].Value == DBNull.Value)
                {
                    return;
                }
                linhaItemSelecionado = e.RowIndex;
                idProdutoSelecionado = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Codigo"].Value);
                precoProdutoSelecionado = Convert.ToDecimal(dataGridView.Rows[e.RowIndex].Cells["Preco"].Value);
                estoqueSelecionado = ConsultarEstoque(idProdutoSelecionado);
                txtPesqProduto.Text = dataGridView.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                txtPreco.Text = precoProdutoSelecionado.ToString("N2");
                txtEstoqueDisponivel.Text = estoqueSelecionado.ToString();
                UDQuantidade.Value = Convert.ToDecimal(dataGridView.Rows[e.RowIndex].Cells["Quantidade"].Value);
                UDDesconto.Value = Convert.ToDecimal(dataGridView.Rows[e.RowIndex].Cells["Desconto"].Value);
                dgvPesquisaProdutos.Visible = false;
            }

        }
        private int ConsultarEstoque(int codigoProduto)
        {
            int estoque = 0;

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();
                    string sql = "SELECT estoque FROM produtos WHERE id_produto = @codigo";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@codigo", codigoProduto);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        estoque = Convert.ToInt32(resultado);
                    }
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao consultar estoque.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estoque;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (linhaItemSelecionado < 0)
            {
                MessageBox.Show("Selecione um item da venda para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantidade = Convert.ToInt32(UDQuantidade.Value);

            if (quantidade > estoqueSelecionado)
            {
                MessageBox.Show("A quantidade informada é maior que o estoque disponível.", "Estoque insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal desconto = UDDesconto.Value;
            decimal totalItem = CalcularTotalItem(precoProdutoSelecionado, quantidade, desconto);

            dataGridView.Rows[linhaItemSelecionado].Cells["Quantidade"].Value = quantidade;
            dataGridView.Rows[linhaItemSelecionado].Cells["Desconto"].Value = desconto;
            dataGridView.Rows[linhaItemSelecionado].Cells["Total"].Value = totalItem;

            MessageBox.Show("Item alterado com sucesso.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AtualizarTotalVenda();
            linhaItemSelecionado = -1;
            LimparProduto();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show("Deseja remover este produto da venda?", "Remover item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                int linha = dataGridView.CurrentRow.Index;
                tabelaItens.Rows.RemoveAt(linha);
                AtualizarTotalVenda();
                LimparProduto();
                linhaItemSelecionado = -1;
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (cmbFuncionario.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o funcionário responsável pela venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFuncionario.Focus();
                return;
            }

            if (tabelaItens.Rows.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto à venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show("Deseja finalizar esta venda?", "Finalizar venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
            {
                return;
            }

            using (MySqlConnection conexao = new MySqlConnection(strConexao))
            {
                conexao.Open();
                MySqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    decimal subtotal = 0;
                    decimal totalVenda = 0;

                    foreach (DataRow item in tabelaItens.Rows)
                    {
                        decimal preco = Convert.ToDecimal(item["Preco"]);
                        int quantidade = Convert.ToInt32(item["Quantidade"]);
                        subtotal += preco * quantidade;
                        totalVenda += Convert.ToDecimal(item["Total"]);
                    }

                    decimal descontoTotal = subtotal - totalVenda;

                    string sqlVenda = "INSERT INTO vendas (data_venda, id_funcionario, subtotal, desconto_total, total_venda) VALUES (@data, @funcionario, @subtotal, @desconto, @total)";
                    MySqlCommand comandoVenda = new MySqlCommand(sqlVenda, conexao, transacao);
                    comandoVenda.Parameters.AddWithValue("@data", dataVendaAtual);
                    comandoVenda.Parameters.AddWithValue("@funcionario", cmbFuncionario.SelectedValue);
                    comandoVenda.Parameters.AddWithValue("@subtotal", subtotal);
                    comandoVenda.Parameters.AddWithValue("@desconto", descontoTotal);
                    comandoVenda.Parameters.AddWithValue("@total", totalVenda);
                    comandoVenda.ExecuteNonQuery();

                    int codigoVenda = Convert.ToInt32(comandoVenda.LastInsertedId);

                    foreach (DataRow item in tabelaItens.Rows)
                    {
                        int codigoProduto = Convert.ToInt32(item["Codigo"]);
                        int quantidade = Convert.ToInt32(item["Quantidade"]);

                        string sqlEstoque = "UPDATE produtos SET estoque = estoque - @quantidade WHERE id_produto = @produto AND estoque >= @quantidade";
                        MySqlCommand comandoEstoque = new MySqlCommand(sqlEstoque, conexao, transacao);
                        comandoEstoque.Parameters.AddWithValue("@quantidade", quantidade);
                        comandoEstoque.Parameters.AddWithValue("@produto", codigoProduto);
                        int registrosAlterados = comandoEstoque.ExecuteNonQuery();

                        if (registrosAlterados == 0)
                        {
                            throw new Exception("Estoque insuficiente para o produto: " + item["Descricao"].ToString());
                        }

                        string sqlItem = "INSERT INTO itens_venda (id_venda, id_produto, quantidade, preco_unitario, desconto_percentual, total_item) VALUES (@venda, @produto, @quantidade, @preco, @desconto, @total)";
                        MySqlCommand comandoItem = new MySqlCommand(sqlItem, conexao, transacao);
                        comandoItem.Parameters.AddWithValue("@venda", codigoVenda);
                        comandoItem.Parameters.AddWithValue("@produto", codigoProduto);
                        comandoItem.Parameters.AddWithValue("@quantidade", quantidade);
                        comandoItem.Parameters.AddWithValue("@preco", item["Preco"]);
                        comandoItem.Parameters.AddWithValue("@desconto", item["Desconto"]);
                        comandoItem.Parameters.AddWithValue("@total", item["Total"]);
                        comandoItem.ExecuteNonQuery();
                    }

                    transacao.Commit();
                    txtCodigoVenda.Text = codigoVenda.ToString();
                    MessageBox.Show("Venda nº " + codigoVenda + " finalizada com sucesso.", "Venda finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparVenda();
                    txtCodigoVenda.Text = (codigoVenda + 1).ToString();
                }
                catch (Exception erro)
                {
                    transacao.Rollback();
                    MessageBox.Show("A venda não foi concluída.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tabelaItens.Rows.Count == 0)
            {
                LimparVenda();
                return;
            }

            DialogResult resposta = MessageBox.Show("Deseja cancelar a venda atual? Os produtos adicionados serão removidos.", "Cancelar venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                LimparVenda();
            }

        }
        private void LimparProduto()
        {
            idProdutoSelecionado = 0;
            estoqueSelecionado = 0;
            precoProdutoSelecionado = 0;
            txtPesqProduto.Clear();
            txtEstoqueDisponivel.Clear();
            txtPreco.Clear();
            UDQuantidade.Value = 1;
           UDDesconto.Value = 0;
            dgvPesquisaProdutos.Visible = false;
            txtPesqProduto.Focus();
        }

        private void LimparVenda()
        {
            tabelaItens.Rows.Clear();
            cmbFuncionario.SelectedIndex = -1;
            //txtCodigoVenda.Clear();
            txtData.Text = DateTime.Now.ToString();
            txtValTotal.Text = "0,00";
            linhaItemSelecionado = -1;
            LimparProduto();

        }

        
    }

}