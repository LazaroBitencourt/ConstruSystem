using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContruSystem
{
    public partial class FormTelaProdutos : Form
    {
        private String strConexao;
        public FormTelaProdutos()
        {
            InitializeComponent();
            strConexao = ConfigurationManager.ConnectionStrings["SistemaVendas"].ConnectionString;
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Informe a descrição do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return;
            }

            if (cmbCategoria.Text.Trim() == "")
            {
                MessageBox.Show("Selecione a categoria do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return;
            }

            decimal preco;

            if (!decimal.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("Informe um preço válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return;
            }

            if (preco <= 0)
            {
                MessageBox.Show("O preço deve ser maior que zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return;
            }

            int estoque;

            if (!int.TryParse(txtEstoque.Text, out estoque))
            {
                MessageBox.Show("Informe uma quantidade válida para o estoque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstoque.Focus();
                return;
            }

            if (estoque < 0)
            {
                MessageBox.Show("O estoque não pode ser negativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstoque.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    string verificar = "SELECT COUNT(*) FROM produtos WHERE descricao = @descricao AND categoria = @categoria";
                    MySqlCommand comandoVerificar = new MySqlCommand(verificar, conexao);
                    comandoVerificar.Parameters.AddWithValue("@descricao", txtDescricao.Text.Trim());
                    comandoVerificar.Parameters.AddWithValue("@categoria", cmbCategoria.Text.Trim());

                    int quantidade = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                    if (quantidade > 0)
                    {
                        MessageBox.Show("Este produto já está cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sql = "INSERT INTO produtos (descricao, categoria, preco, estoque) VALUES (@descricao, @categoria, @preco, @estoque)";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@descricao", txtDescricao.Text.Trim());
                    comando.Parameters.AddWithValue("@categoria", cmbCategoria.Text.Trim());
                    comando.Parameters.AddWithValue("@preco", preco);
                    comando.Parameters.AddWithValue("@estoque", estoque);
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Produto cadastrado com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarProdutos();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao cadastrar produto.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CarregarProdutos()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    string sql = "SELECT id_produto AS Codigo, descricao AS Descricao, categoria AS Categoria, preco AS Preco, estoque AS Estoque FROM produtos ORDER BY descricao";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dataGridView.DataSource= tabela;
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao carregar produtos.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    string sql = "SELECT id_produto AS Codigo, descricao AS Descricao, categoria AS Categoria, preco AS Preco, estoque AS Estoque FROM produtos WHERE descricao LIKE @pesquisa OR categoria LIKE @pesquisa ORDER BY descricao";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@pesquisa", "%" + txtPesquisarProduto.Text.Trim() + "%");

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dataGridView.DataSource = tabela;
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao pesquisar produto.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigoProduto.Text = dataGridView.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtDescricao.Text = dataGridView.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                cmbCategoria.Text = dataGridView.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
                txtPreco.Text = dataGridView.Rows[e.RowIndex].Cells["Preco"].Value.ToString();
                txtEstoque.Text = dataGridView.Rows[e.RowIndex].Cells["Estoque"].Value.ToString();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text.Trim() == "")
            {
                MessageBox.Show("Selecione um produto na tabela.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDescricao.Text.Trim() == "" || cmbCategoria.Text.Trim() == "" || txtPreco.Text.Trim() == "" || txtEstoque.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal preco;
            int estoque;

            if (!decimal.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("Informe um preço válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return;
            }

            if (!int.TryParse(txtEstoque.Text, out estoque))
            {
                MessageBox.Show("Informe um estoque válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstoque.Focus();
                return;
            }

            if (preco <= 0 || estoque < 0)
            {
                MessageBox.Show("Verifique o preço e o estoque informados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    string sql = "UPDATE produtos SET descricao = @descricao, categoria = @categoria, preco = @preco, estoque = @estoque WHERE id_produto = @codigo";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@descricao", txtDescricao.Text.Trim());
                    comando.Parameters.AddWithValue("@categoria", cmbCategoria.Text.Trim());
                    comando.Parameters.AddWithValue("@preco", preco);
                    comando.Parameters.AddWithValue("@estoque", estoque);
                    comando.Parameters.AddWithValue("@codigo", txtCodigoProduto.Text);
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Produto alterado com sucesso.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarProdutos();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao editar produto.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text.Trim() == "")
            {
                MessageBox.Show("Selecione um produto na tabela.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show("Deseja realmente excluir este produto?", "Excluir produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexao = new MySqlConnection(strConexao))
                    {
                        conexao.Open();

                        string verificar = "SELECT COUNT(*) FROM itens_venda WHERE id_produto = @codigo";
                        MySqlCommand comandoVerificar = new MySqlCommand(verificar, conexao);
                        comandoVerificar.Parameters.AddWithValue("@codigo", txtCodigoProduto.Text);

                        int quantidadeVendas = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                        if (quantidadeVendas > 0)
                        {
                            MessageBox.Show("Este produto não pode ser excluído porque possui vendas registradas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string sql = "DELETE FROM produtos WHERE id_produto = @codigo";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@codigo", txtCodigoProduto.Text);
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produto excluído com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    CarregarProdutos();
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erro ao excluir produto.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodigoProduto.Clear();
            txtDescricao.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtPreco.Clear();
            txtEstoque.Clear();
            txtDescricao.Focus();
        }

    }
}
