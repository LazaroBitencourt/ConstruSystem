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
    public partial class FormTelaLogin : Form
    {

        public FormTelaLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtUsuario; // define o foco inicial no campo de usuário ao abrir a tela
            txtSenha.UseSystemPasswordChar = true; // esconde a senha digitada por padrão
            this.AcceptButton = btnEntrar; // permite logar pressionando Enter
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Informe o usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Informe a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();
                    // senha comparada em texto puro — não há hash/criptografia armazenada no banco
                    string sql = "SELECT nome, tipo_usuario FROM usuarios WHERE login = @login AND senha = @senha";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@login", txtUsuario.Text.Trim());
                    comando.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());

                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        if (leitor.Read())
                        {
                            // tipoUsuario é repassado ao menu principal para liberar/bloquear
                            // funcionalidades restritas (ex: tela de Usuários) conforme o perfil
                            string nomeUsuario = leitor["nome"].ToString();
                            string tipoUsuario = leitor["tipo_usuario"].ToString();

                            MessageBox.Show("Bem-vindo, " + nomeUsuario + "!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormTelaPrincipal menu = new FormTelaPrincipal(nomeUsuario, tipoUsuario);
                            menu.Show();
                            this.Hide(); // login some da tela, mas continua na memória até o app fechar
                        }
                        else
                        {
                            MessageBox.Show("Login ou senha inválidos.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSenha.Clear();
                            txtUsuario.Focus();
                        }
                    }
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao acessar o banco de dados.\n\n" + erro.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTelaLoginMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            // alterna a visibilidade da senha conforme o checkbox "Mostrar senha"
            txtSenha.UseSystemPasswordChar = !btnMostrarSenha.Checked;
        }

        private void FormTelaLoginSairBtn_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

    }


}

