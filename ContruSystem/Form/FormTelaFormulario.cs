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
using System.Configuration;
using ClosedXML.Excel;
using System.Drawing.Printing;

namespace ContruSystem
{
    public partial class FormTelaRelatorio : Form
    {
        private String strConexao;
        private PrintDocument documentoImpressao = new PrintDocument();
        private int linhaAtualImpressao = 0;
        public FormTelaRelatorio()
        {
            InitializeComponent();
            strConexao = ConfigurationManager.ConnectionStrings["SistemaVendas"].ConnectionString;
        }

        private void FormTelaRelatorio_Load(object sender, EventArgs e)
        {
            txtTotalGeral.ReadOnly = true;
            dtpDataInicial.Value = DateTime.Now.Date;
            dtpDataFinal.Value = DateTime.Now.Date;
            txtTotalGeral.Text = "0,00";
            frmLblDataRelatorio.Text = "Período: " + DateTime.Now.ToShortDateString() + " a " + DateTime.Now.ToShortDateString();

        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if (dtpDataInicial.Value.Date > dtpDataFinal.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataInicial.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    string sql = "SELECT v.id_venda AS Codigo, v.data_venda AS DataVenda, f.nome AS Funcionario, v.subtotal AS Subtotal, v.desconto_total AS Desconto, v.total_venda AS Total FROM vendas v INNER JOIN funcionarios f ON v.id_funcionario = f.id_funcionario WHERE v.data_venda >= @dataInicial AND v.data_venda < @dataFinal ORDER BY v.data_venda DESC";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@dataInicial", dtpDataInicial.Value.Date);
                    comando.Parameters.AddWithValue("@dataFinal", dtpDataFinal.Value.Date.AddDays(1));

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dataGridView.DataSource = tabela;

                    if (tabela.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma venda foi encontrada no período informado.", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTotalGeral.Text = "0,00";
                        return;
                    }

                    CalcularTotalGeral();
                    frmLblDataRelatorio.Text = "Período: " + dtpDataInicial.Value.Date.ToShortDateString() + " a " + dtpDataFinal.Value.Date.ToShortDateString();
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao gerar o relatório.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CalcularTotalGeral()
        {
            decimal totalGeral = 0;

            foreach (DataGridViewRow linha in dataGridView.Rows)
            {
                if (linha.Cells["Total"].Value != null)
                {
                    totalGeral += Convert.ToDecimal(linha.Cells["Total"].Value);
                }
            }

            txtTotalGeral.Text = totalGeral.ToString("N2");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            txtTotalGeral.Text = "0,00";
            dtpDataInicial.Value = DateTime.Now.Date;
            dtpDataFinal.Value = DateTime.Now.Date;
            frmLblDataRelatorio.Text = "Período: " + DateTime.Now.ToShortDateString() + " a " + DateTime.Now.ToShortDateString();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportarParaExcel()
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Gere um relatório antes de exportar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog salvarArquivo = new SaveFileDialog();
            salvarArquivo.Filter = "Arquivo Excel|*.xlsx";
            salvarArquivo.FileName = "Relatorio_Vendas_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

            if (salvarArquivo.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var planilha = workbook.Worksheets.Add("Relatório");

                    // Título e período
                    planilha.Range(1, 1, 1, 6).Merge();
                    planilha.Cell(1, 1).Value = "Relatório de Vendas";
                    planilha.Cell(1, 1).Style.Font.Bold = true;
                    planilha.Cell(1, 1).Style.Font.FontSize = 14;
                    planilha.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    planilha.Cell(1, 1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    planilha.Range(2, 1, 2, 6).Merge();
                    planilha.Cell(2, 1).Value = frmLblDataRelatorio.Text;
                    planilha.Cell(2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    planilha.Cell(2, 1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    // Cabeçalho da tabela (linha 4)
                    int linhaCabecalho = 4;
                    planilha.Cell(linhaCabecalho, 1).Value = "Código";
                    planilha.Cell(linhaCabecalho, 2).Value = "Data";
                    planilha.Cell(linhaCabecalho, 3).Value = "Funcionário";
                    planilha.Cell(linhaCabecalho, 4).Value = "Subtotal";
                    planilha.Cell(linhaCabecalho, 5).Value = "Desconto";
                    planilha.Cell(linhaCabecalho, 6).Value = "Total";

                    planilha.Range(linhaCabecalho, 1, linhaCabecalho, 6).Style.Font.Bold = true;
                    planilha.Range(linhaCabecalho, 1, linhaCabecalho, 6).Style.Fill.BackgroundColor = XLColor.LightGray;


                    // Dados
                    int linha = linhaCabecalho + 1;
                    foreach (DataGridViewRow linhaGrid in dataGridView.Rows)
                    {
                        if (linhaGrid.Cells["Codigo"].Value == null) continue;

                        planilha.Cell(linha, 1).Value = Convert.ToInt32(linhaGrid.Cells["Codigo"].Value);
                        planilha.Cell(linha, 2).Value = Convert.ToDateTime(linhaGrid.Cells["DataVenda"].Value);
                        planilha.Cell(linha, 2).Style.DateFormat.Format = "dd/MM/yyyy HH:mm";
                        planilha.Cell(linha, 3).Value = linhaGrid.Cells["Funcionario"].Value.ToString();
                        planilha.Cell(linha, 4).Value = Convert.ToDecimal(linhaGrid.Cells["Subtotal"].Value);
                        planilha.Cell(linha, 5).Value = Convert.ToDecimal(linhaGrid.Cells["Desconto"].Value);
                        planilha.Cell(linha, 6).Value = Convert.ToDecimal(linhaGrid.Cells["Total"].Value);
                        linha++;
                    }

                    planilha.Column(4).Style.NumberFormat.Format = "#,##0.00";
                    planilha.Column(5).Style.NumberFormat.Format = "#,##0.00";
                    planilha.Column(6).Style.NumberFormat.Format = "#,##0.00";

                    // Total geral
                    planilha.Cell(linha, 5).Value = "Total Geral:";
                    planilha.Cell(linha, 5).Style.Font.Bold = true;
                    planilha.Cell(linha, 6).Value = decimal.Parse(txtTotalGeral.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
                    planilha.Cell(linha, 6).Style.Font.Bold = true;

                    planilha.Columns().AdjustToContents();

                    workbook.SaveAs(salvarArquivo.FileName);
                }

                MessageBox.Show("Relatório exportado com sucesso!", "Exportação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao exportar para Excel.\n\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarParaExcel();
        }

        private void ImprimirRelatorio()
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Gere um relatório antes de imprimir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            linhaAtualImpressao = 0;

            documentoImpressao.PrintPage += DocumentoImpressao_PrintPage;

            PrintPreviewDialog visualizacao = new PrintPreviewDialog();
            visualizacao.Document = documentoImpressao;
            visualizacao.Width = 900;
            visualizacao.Height = 700;
            visualizacao.ShowDialog();

            documentoImpressao.PrintPage -= DocumentoImpressao_PrintPage;
        }
        private void DocumentoImpressao_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fonteTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fonteCabecalho = new Font("Arial", 9, FontStyle.Bold);
            Font fonteTexto = new Font("Arial", 9);

            int margemEsquerda = e.MarginBounds.Left;
            int margemTopo = e.MarginBounds.Top;
            int larguraDisponivel = e.MarginBounds.Width;
            int posicaoY = margemTopo;

            // Larguras das colunas (soma deve bater com larguraDisponivel)
            int[] largurasColunas = { 60, 130, 150, 90, 90, 90 };
            string[] titulosColunas = { "Código", "Data", "Funcionário", "Subtotal", "Desconto", "Total" };

            // Cabeçalho do relatório (só na primeira página)
            if (linhaAtualImpressao == 0)
            {
                g.DrawString("Relatório de Vendas", fonteTitulo, Brushes.Black, margemEsquerda, posicaoY);
                posicaoY += 30;
                g.DrawString(frmLblDataRelatorio.Text, fonteTexto, Brushes.Black, margemEsquerda, posicaoY);
                posicaoY += 25;
            }

            // Cabeçalho das colunas
            int x = margemEsquerda;
            for (int i = 0; i < titulosColunas.Length; i++)
            {
                g.DrawString(titulosColunas[i], fonteCabecalho, Brushes.Black, x, posicaoY);
                x += largurasColunas[i];
            }
            posicaoY += 20;
            g.DrawLine(Pens.Black, margemEsquerda, posicaoY, margemEsquerda + larguraDisponivel, posicaoY);
            posicaoY += 5;

            // Linhas da tabela
            while (linhaAtualImpressao < dataGridView.Rows.Count)
            {
                DataGridViewRow linha = dataGridView.Rows[linhaAtualImpressao];

                if (linha.Cells["Codigo"].Value == null)
                {
                    linhaAtualImpressao++;
                    continue;
                }

                // Se não cabe mais linha na página, para e continua na próxima
                if (posicaoY + 20 > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                x = margemEsquerda;

                string codigo = linha.Cells["Codigo"].Value.ToString();
                string data = Convert.ToDateTime(linha.Cells["DataVenda"].Value).ToString("dd/MM/yyyy HH:mm");
                string funcionario = linha.Cells["Funcionario"].Value.ToString();
                string subtotal = Convert.ToDecimal(linha.Cells["Subtotal"].Value).ToString("N2");
                string desconto = Convert.ToDecimal(linha.Cells["Desconto"].Value).ToString("N2");
                string total = Convert.ToDecimal(linha.Cells["Total"].Value).ToString("N2");

                string[] valores = { codigo, data, funcionario, subtotal, desconto, total };

                for (int i = 0; i < valores.Length; i++)
                {
                    g.DrawString(valores[i], fonteTexto, Brushes.Black, x, posicaoY);
                    x += largurasColunas[i];
                }

                posicaoY += 18;
                linhaAtualImpressao++;
            }

            // Total geral no final (só depois de percorrer todas as linhas)
            posicaoY += 10;
            g.DrawLine(Pens.Black, margemEsquerda, posicaoY, margemEsquerda + larguraDisponivel, posicaoY);
            posicaoY += 10;
            g.DrawString("Total Geral: " + txtTotalGeral.Text, fonteCabecalho, Brushes.Black, margemEsquerda, posicaoY);

            e.HasMorePages = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio();
        }
    }
}
