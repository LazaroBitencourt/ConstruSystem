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
            formShow(new FormTelaVendas());
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
    }
}
