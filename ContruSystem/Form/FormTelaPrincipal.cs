using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Control = System.Windows.Forms.Control;
using MessageBox = System.Windows.Forms.MessageBox;



namespace ContruSystem
{
    public partial class FormTelaPrincipal : Form

    {
        private Form frmAtivo;
        private string nomeUsuarioLogado;

        public FormTelaPrincipal(string nomeUsuario)
        {
            InitializeComponent();
            nomeUsuarioLogado = nomeUsuario;
        }
        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {
            frmLblSaudacao.Text = "Bem-vindo, " + nomeUsuarioLogado;
            frmLblDataHoje.Text = DateTime.Now.ToString("dd/MM/yyyy");
            frmLblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
            CarregarDashboard();
        }
        private void formShow(Form frm)
        {
            frmAtivoFechar();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelFormTelaPrincipal.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void frmAtivoFechar()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void botaoAtivado(Button frmAtivo)
        {
            foreach (Control controle in panelMenuTelaPrincipal.Controls)
            {
                controle.ForeColor = Color.FromArgb(26, 54, 93);
                frmAtivo.ForeColor = Color.FromArgb(247, 250, 252);

            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            botaoAtivado(btnRelatorio);
            formShow(new FormTelaRelatorio());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            botaoAtivado(btnHome);
            frmAtivoFechar();

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            botaoAtivado(btnVendas);
            FormTelaVendas frmVendas = new FormTelaVendas();
            frmVendas.VendaFinalizada += FrmVendas_VendaFinalizada;
            formShow(frmVendas);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            botaoAtivado(btnProdutos);
            formShow(new FormTelaProdutos());
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            botaoAtivado(btnFuncionarios);
            formShow(new FormTelaFuncionarios());

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmLblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frmLblHoraAtual_Click(object sender, EventArgs e)
        {

        }
        private void CarregarDashboard()
        {
            try
            {
                using (MySqlConnection conexao = ConexaoBanco.CriarConexao())
                {
                    conexao.Open();

                    string sql = @"
                SELECT 
                    (SELECT COALESCE(SUM(total_venda), 0) FROM vendas WHERE DATE(data_venda) = CURDATE()) AS TotalVendas,
                    (SELECT COUNT(*) FROM vendas WHERE DATE(data_venda) = CURDATE()) AS QtdVendas,
                    (SELECT COUNT(*) FROM produtos WHERE estoque <= 10) AS EstoqueBaixo";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        if (leitor.Read())
                        {
                            labelValorVendasHoje.Text = "R$ " + Convert.ToDecimal(leitor["TotalVendas"]).ToString("N2");
                            labelValorQtdVendasHoje.Text = leitor["QtdVendas"].ToString();
                            labelValorProdutosBaixoEst.Text = leitor["EstoqueBaixo"].ToString();
                        }
                    }
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao carregar o dashboard.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmVendas_VendaFinalizada(object sender, EventArgs e)
        {
            CarregarDashboard();
        }


    }
}
