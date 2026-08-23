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
        // frmAtivo guarda o form atualmente exibido dentro do panelFormTelaPrincipal,
        // permitindo fechá-lo antes de abrir outro (evita telas empilhadas)
        private Form frmAtivo;
        private string nomeUsuarioLogado;
        private string tipoUsuarioLogado;

        public FormTelaPrincipal(string nomeUsuario, string tipoUsuario)
        {
            InitializeComponent();
            nomeUsuarioLogado = nomeUsuario;
            tipoUsuarioLogado = tipoUsuario;
        }
        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {
            frmLblSaudacao.Text = "Bem-vindo, " + nomeUsuarioLogado;
            frmLblDataHoje.Text = DateTime.Now.ToString("dd/MM/yyyy");
            frmLblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
            CarregarDashboard();
            // apenas administradores têm acesso à tela de Usuários
            bool ehAdministrador = tipoUsuarioLogado.Equals("administrador", StringComparison.OrdinalIgnoreCase);
            btnUsuarios.Enabled = ehAdministrador; // Enabled = false já bloqueia o clique automaticamente

            if (!ehAdministrador)
            {
                btnUsuarios.BackColor = Color.FromArgb(180, 180, 180);// reforça visualmente que o botão está desabilitado
            }

        }
        // Exibe um form dentro do panelFormTelaPrincipal, no lugar de abrir uma nova janela.
        // TopLevel = false é o que permite o form "filho" ficar embutido dentro do painel.
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
        // Destaca visualmente o botão do menu que está ativo no momento
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
            frmAtivoFechar();// Home não tem tela própria, só fecha o form atual e mostra o dashboard

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            botaoAtivado(btnVendas);
            FormTelaVendas frmVendas = new FormTelaVendas();

            // ouve o evento disparado quando uma venda é concluída, para atualizar
            // o dashboard (vendas hoje, qtd vendas, estoque) sem precisar reabrir a tela principal
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
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            botaoAtivado(btnUsuarios);
            formShow(new FormTelaUsuario());
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
        // Busca em uma única consulta os 3 indicadores do dashboard,
        // evitando 3 idas separadas ao banco
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
        // Handler do evento VendaFinalizada (FormTelaVendas) — mantém o dashboard sincronizado
        private void FrmVendas_VendaFinalizada(object sender, EventArgs e)
        {
            CarregarDashboard();
        }

        
    }
}
