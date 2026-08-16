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
    public partial class FormTelaLogin : Form
    {
        private String strConexao;
        public FormTelaLogin()
        {
            InitializeComponent();
            strConexao = ConfigurationManager.ConnectionStrings["SistemaVendas"].ConnectionString;
            this.ActiveControl = txtUsuario;
            txtSenha.UseSystemPasswordChar = true;
            this.AcceptButton = btnEntrar;
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
                using (MySqlConnection conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    string sql = "SELECT nome FROM usuarios WHERE login = @login AND senha = @senha";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@login", txtUsuario.Text.Trim());
                    comando.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        string nomeUsuario = resultado.ToString();

                        MessageBox.Show("Bem-vindo, " + nomeUsuario + "!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormTelaPrincipal menu = new FormTelaPrincipal();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha inválidos.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Clear();
                        txtUsuario.Focus();
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

