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
    public partial class FormTelaUsuario : Form
    {
        private int idUsuarioSelecionado = 0;
        public FormTelaUsuario()
        {
            InitializeComponent();
        }

        private void FormTelaUsuario_Load(object sender, EventArgs e)
        {
            cmbTipoUsuario.Items.Clear();
            cmbTipoUsuario.Items.Add("Administrador");
            cmbTipoUsuario.Items.Add("Usuario");
            cmbTipoUsuario.SelectedIndex = -1;

            CarregarUsuarios();
        }
        private void CarregarUsuarios(string filtro = "")
        {
            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();

                    string sql = "SELECT id_usuario AS Codigo, nome AS Nome, login AS Login, senha AS Senha, tipo_usuario AS Tipo, criado_em AS DataCriacao FROM usuarios WHERE nome LIKE @pesquisa ORDER BY nome";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@pesquisa", "%" + filtro + "%");

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    dataGridView.DataSource = tabela;

                    if (dataGridView.Columns["Login"] != null)
                        dataGridView.Columns["Login"].Visible = true;

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao carregar usuários.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarUsuarios(txtPesquisar.Text.Trim());
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Informe o login do usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return false;
            }

            if (idUsuarioSelecionado == 0 && string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Informe a senha do usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }

            if (cmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo de usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoUsuario.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();

                    string sql = "INSERT INTO usuarios (nome, login, senha, tipo_usuario) VALUES (@nome, @login, @senha, @tipo)";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                    comando.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                    comando.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());
                    comando.Parameters.AddWithValue("@tipo", cmbTipoUsuario.SelectedItem.ToString());
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuário cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    CarregarUsuarios();
                }
            }
            catch (MySqlException erro)
            {
                if (erro.Number == 1062) // login duplicado (UNIQUE)
                {
                    MessageBox.Show("Já existe um usuário com este login.", "Login duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Erro ao salvar usuário.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView.Rows[e.RowIndex].Cells["Codigo"].Value is DBNull) return;

            idUsuarioSelecionado = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Codigo"].Value);
            txtNome.Text = dataGridView.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            txtLogin.Text = dataGridView.Rows[e.RowIndex].Cells["Login"].Value.ToString();
            txtSenha.Text = dataGridView.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
            cmbTipoUsuario.SelectedItem = dataGridView.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();

            if (dataGridView.Rows[e.RowIndex].Cells["DataCriacao"].Value is DBNull)
            {
                txtData.Clear();
            }
            else
            {
                txtData.Text = Convert.ToDateTime(dataGridView.Rows[e.RowIndex].Cells["DataCriacao"].Value).ToString("dd/MM/yyyy");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSelecionado == 0)
            {
                MessageBox.Show("Selecione um usuário na lista para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCamposEdicao())
            {
                return;
            }

            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();

                    string sql;
                    MySqlCommand comando;

                    if (string.IsNullOrWhiteSpace(txtSenha.Text))
                    {
                        // não altera a senha se o campo ficou em branco
                        sql = "UPDATE usuarios SET nome = @nome, login = @login, tipo_usuario = @tipo WHERE id_usuario = @id";
                        comando = new MySqlCommand(sql, conexao);
                    }
                    else
                    {
                        sql = "UPDATE usuarios SET nome = @nome, login = @login, senha = @senha, tipo_usuario = @tipo WHERE id_usuario = @id";
                        comando = new MySqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());
                    }

                    comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                    comando.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                    comando.Parameters.AddWithValue("@tipo", cmbTipoUsuario.SelectedItem.ToString());
                    comando.Parameters.AddWithValue("@id", idUsuarioSelecionado);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuário atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    CarregarUsuarios();
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao editar usuário.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCamposEdicao()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtLogin.Text) || cmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha nome, login e tipo do usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            idUsuarioSelecionado = 0;
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            cmbTipoUsuario.SelectedIndex = -1;
            txtPesquisar.Clear();
            txtNome.Focus();
            txtData.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idUsuarioSelecionado == 0)
            {
                MessageBox.Show("Selecione um usuário na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show("Deseja realmente excluir este usuário?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();
                    string sql = "DELETE FROM usuarios WHERE id_usuario = @id";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@id", idUsuarioSelecionado);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    CarregarUsuarios();
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao excluir usuário.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
