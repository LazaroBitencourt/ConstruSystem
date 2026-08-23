using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ContruSystem
{
    public partial class FormTelaUsuarios : Form
    {
        public FormTelaUsuarios()
        {
            InitializeComponent();
        }
        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            txtCodigoFuncionario.ReadOnly = true;
            dtpDataAdmissao.Value = DateTime.Now;
            CarregarFuncionarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Informe o nome do funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (!mskCpf.MaskCompleted)
            {
                MessageBox.Show("Informe o CPF completo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCpf.Focus();
                return;
            }

            if (cmbCargo.Text.Trim() == "")
            {
                MessageBox.Show("Selecione o cargo do funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCargo.Focus();
                return;
            }

            decimal salario;

            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("Informe um salário válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return;
            }

            if (salario <= 0)
            {
                MessageBox.Show("O salário deve ser maior que zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return;
            }

            if (dtpDataAdmissao.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("A data de admissão não pode ser maior que a data atual.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataAdmissao.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();

                    string verificar = "SELECT COUNT(*) FROM funcionarios WHERE cpf = @cpf";
                    MySqlCommand comandoVerificar = new MySqlCommand(verificar, conexao);
                    comandoVerificar.Parameters.AddWithValue("@cpf", mskCpf.Text);

                    int quantidade = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                    if (quantidade > 0)
                    {
                        MessageBox.Show("Este CPF já está cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mskCpf.Focus();
                        return;
                    }

                    string sql = "INSERT INTO funcionarios (nome, cpf, cargo, salario, data_admissao) VALUES (@nome, @cpf, @cargo, @salario, @data)";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                    comando.Parameters.AddWithValue("@cpf", mskCpf.Text);
                    comando.Parameters.AddWithValue("@cargo", cmbCargo.Text.Trim());
                    comando.Parameters.AddWithValue("@salario", salario);
                    comando.Parameters.AddWithValue("@data", dtpDataAdmissao.Value.Date);
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Funcionário cadastrado com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarFuncionarios();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao cadastrar funcionário.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarFuncionarios()
        {
            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();

                    string sql = "SELECT id_funcionario AS Codigo, nome AS Nome, cpf AS CPF, cargo AS Cargo, salario AS Salario, data_admissao AS DataAdmissao FROM funcionarios ORDER BY nome";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dataGridView.DataSource = tabela;
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao carregar funcionários.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();

                    string sql = "SELECT id_funcionario AS Codigo, nome AS Nome, cpf AS CPF, cargo AS Cargo, salario AS Salario, data_admissao AS DataAdmissao FROM funcionarios WHERE nome LIKE @pesquisa OR cpf LIKE @pesquisa OR cargo LIKE @pesquisa ORDER BY nome";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@pesquisa", "%" + txtPesquisar.Text.Trim() + "%");

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dataGridView.DataSource = tabela;
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao pesquisar funcionário.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigoFuncionario.Text = dataGridView.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtNome.Text = dataGridView.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                mskCpf.Text = dataGridView.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                cmbCargo.Text = dataGridView.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();
                txtSalario.Text = dataGridView.Rows[e.RowIndex].Cells["Salario"].Value.ToString();
                dtpDataAdmissao.Value = Convert.ToDateTime(dataGridView.Rows[e.RowIndex].Cells["DataAdmissao"].Value);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigoFuncionario.Text.Trim() == "")
            {
                MessageBox.Show("Selecione um funcionário na tabela.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Informe o nome do funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (!mskCpf.MaskCompleted)
            {
                MessageBox.Show("Informe o CPF completo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCpf.Focus();
                return;
            }

            if (cmbCargo.Text.Trim() == "")
            {
                MessageBox.Show("Selecione o cargo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCargo.Focus();
                return;
            }

            decimal salario;

            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("Informe um salário válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return;
            }

            if (salario <= 0)
            {
                MessageBox.Show("O salário deve ser maior que zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDataAdmissao.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("A data de admissão não pode ser maior que a data atual.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();

                    string verificar = "SELECT COUNT(*) FROM funcionarios WHERE cpf = @cpf AND id_funcionario <> @codigo";
                    MySqlCommand comandoVerificar = new MySqlCommand(verificar, conexao);
                    comandoVerificar.Parameters.AddWithValue("@cpf", mskCpf.Text);
                    comandoVerificar.Parameters.AddWithValue("@codigo", txtCodigoFuncionario.Text);

                    int quantidade = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                    if (quantidade > 0)
                    {
                        MessageBox.Show("Este CPF já pertence a outro funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, cargo = @cargo, salario = @salario, data_admissao = @data WHERE id_funcionario = @codigo";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                    comando.Parameters.AddWithValue("@cpf", mskCpf.Text);
                    comando.Parameters.AddWithValue("@cargo", cmbCargo.Text.Trim());
                    comando.Parameters.AddWithValue("@salario", salario);
                    comando.Parameters.AddWithValue("@data", dtpDataAdmissao.Value.Date);
                    comando.Parameters.AddWithValue("@codigo", txtCodigoFuncionario.Text);
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Funcionário alterado com sucesso.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarFuncionarios();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao editar funcionário.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoFuncionario.Text.Trim() == "")
            {
                MessageBox.Show("Selecione um funcionário na tabela.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show("Deseja realmente excluir este funcionário?", "Excluir funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                    {
                        conexao.Open();

                        string verificar = "SELECT COUNT(*) FROM vendas WHERE id_funcionario = @codigo";
                        MySqlCommand comandoVerificar = new MySqlCommand(verificar, conexao);
                        comandoVerificar.Parameters.AddWithValue("@codigo", txtCodigoFuncionario.Text);

                        int quantidadeVendas = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                        if (quantidadeVendas > 0)
                        {
                            MessageBox.Show("Este funcionário não pode ser excluído porque possui vendas registradas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string sql = "DELETE FROM funcionarios WHERE id_funcionario = @codigo";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@codigo", txtCodigoFuncionario.Text);
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Funcionário excluído com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    CarregarFuncionarios();
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erro ao excluir funcionário.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtCodigoFuncionario.Clear();
            txtNome.Clear();
            mskCpf.Clear();
            txtPesquisar.Clear();
            cmbCargo.SelectedIndex = -1;
            cmbCargo.Text = string.Empty;
            txtSalario.Clear();
            dtpDataAdmissao.Value = DateTime.Now;
            txtNome.Focus();
            dataGridView.DataSource = null;
        }

        private void CarregarCargos()
        {
            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();
                    string sql = "SELECT DISTINCT cargo FROM funcionarios ORDER BY cargo";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    cmbCargo.Items.Clear();

                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            cmbCargo.Items.Add(leitor["cargo"].ToString());
                        }
                    }
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao carregar cargos.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCargo_DropDown(object sender, EventArgs e)
        {
            CarregarCargos();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormTelaUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormTelaUsuarios";
            this.Load += new System.EventHandler(this.FormTelaUsuarios_Load);
            this.ResumeLayout(false);

        }

        private void FormTelaUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}

