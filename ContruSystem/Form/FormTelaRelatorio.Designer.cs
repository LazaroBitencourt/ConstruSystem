namespace ContruSystem
{
    partial class FormTelaRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.frmLblRelatorio = new System.Windows.Forms.Label();
            this.frmLblPeriodo = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.frmLblDataInicial = new System.Windows.Forms.Label();
            this.PanelDataInicial = new System.Windows.Forms.Panel();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.frmLblDataRelatorio = new System.Windows.Forms.Label();
            this.frmLblDataFinal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.frmLblValorTotal = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.PanelDataInicial.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLblRelatorio
            // 
            this.frmLblRelatorio.AutoSize = true;
            this.frmLblRelatorio.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblRelatorio.Location = new System.Drawing.Point(313, 9);
            this.frmLblRelatorio.Name = "frmLblRelatorio";
            this.frmLblRelatorio.Size = new System.Drawing.Size(242, 23);
            this.frmLblRelatorio.TabIndex = 114;
            this.frmLblRelatorio.Text = "RELATÓRIO DE VENDAS";
            // 
            // frmLblPeriodo
            // 
            this.frmLblPeriodo.AutoSize = true;
            this.frmLblPeriodo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblPeriodo.Location = new System.Drawing.Point(22, 10);
            this.frmLblPeriodo.Name = "frmLblPeriodo";
            this.frmLblPeriodo.Size = new System.Drawing.Size(83, 23);
            this.frmLblPeriodo.TabIndex = 113;
            this.frmLblPeriodo.Text = "Período";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(13, 70);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(848, 205);
            this.dataGridView.TabIndex = 102;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 2);
            this.label1.TabIndex = 101;
            // 
            // frmLblDataInicial
            // 
            this.frmLblDataInicial.AutoSize = true;
            this.frmLblDataInicial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblDataInicial.Location = new System.Drawing.Point(22, 46);
            this.frmLblDataInicial.Name = "frmLblDataInicial";
            this.frmLblDataInicial.Size = new System.Drawing.Size(133, 19);
            this.frmLblDataInicial.TabIndex = 92;
            this.frmLblDataInicial.Text = "Período Inicial:";
            // 
            // PanelDataInicial
            // 
            this.PanelDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDataInicial.Controls.Add(this.dtpDataInicial);
            this.PanelDataInicial.Location = new System.Drawing.Point(161, 44);
            this.PanelDataInicial.Name = "PanelDataInicial";
            this.PanelDataInicial.Size = new System.Drawing.Size(127, 21);
            this.PanelDataInicial.TabIndex = 96;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDataInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDataInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDataInicial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(0, 0);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(125, 23);
            this.dtpDataInicial.TabIndex = 0;
            // 
            // frmLblDataRelatorio
            // 
            this.frmLblDataRelatorio.AutoSize = true;
            this.frmLblDataRelatorio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblDataRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblDataRelatorio.Location = new System.Drawing.Point(317, 41);
            this.frmLblDataRelatorio.Name = "frmLblDataRelatorio";
            this.frmLblDataRelatorio.Size = new System.Drawing.Size(233, 14);
            this.frmLblDataRelatorio.TabIndex = 115;
            this.frmLblDataRelatorio.Text = "Período: 01/05/2025 a 01/05/2025";
            // 
            // frmLblDataFinal
            // 
            this.frmLblDataFinal.AutoSize = true;
            this.frmLblDataFinal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblDataFinal.Location = new System.Drawing.Point(305, 46);
            this.frmLblDataFinal.Name = "frmLblDataFinal";
            this.frmLblDataFinal.Size = new System.Drawing.Size(122, 19);
            this.frmLblDataFinal.TabIndex = 116;
            this.frmLblDataFinal.Text = "Período Final:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpDataFinal);
            this.panel1.Location = new System.Drawing.Point(444, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 21);
            this.panel1.TabIndex = 117;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDataFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDataFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDataFinal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(0, 0);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(125, 23);
            this.dtpDataFinal.TabIndex = 0;
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormulario.Controls.Add(this.txtTotalGeral);
            this.panelFormulario.Controls.Add(this.frmLblValorTotal);
            this.panelFormulario.Controls.Add(this.dataGridView);
            this.panelFormulario.Controls.Add(this.frmLblRelatorio);
            this.panelFormulario.Controls.Add(this.frmLblDataRelatorio);
            this.panelFormulario.Location = new System.Drawing.Point(26, 92);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(875, 324);
            this.panelFormulario.TabIndex = 118;
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.BackColor = System.Drawing.Color.White;
            this.txtTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalGeral.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtTotalGeral.Location = new System.Drawing.Point(706, 281);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Size = new System.Drawing.Size(119, 29);
            this.txtTotalGeral.TabIndex = 121;
            this.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLblValorTotal
            // 
            this.frmLblValorTotal.AutoSize = true;
            this.frmLblValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.frmLblValorTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblValorTotal.Location = new System.Drawing.Point(540, 286);
            this.frmLblValorTotal.Name = "frmLblValorTotal";
            this.frmLblValorTotal.Size = new System.Drawing.Size(160, 23);
            this.frmLblValorTotal.TabIndex = 116;
            this.frmLblValorTotal.Text = "Valor Total:  R$";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(720, 440);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Padding = new System.Windows.Forms.Padding(1);
            this.btnFechar.Size = new System.Drawing.Size(181, 37);
            this.btnFechar.TabIndex = 120;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnLimpar.Image = global::ContruSystem.Properties.Resources.iconLimpar;
            this.btnLimpar.Location = new System.Drawing.Point(106, 440);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(1);
            this.btnLimpar.Size = new System.Drawing.Size(179, 37);
            this.btnLimpar.TabIndex = 121;
            this.btnLimpar.Text = "Limpar Pesquisa";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = global::ContruSystem.Properties.Resources.IconPrint1;
            this.btnImprimir.Location = new System.Drawing.Point(515, 440);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(1);
            this.btnImprimir.Size = new System.Drawing.Size(181, 37);
            this.btnImprimir.TabIndex = 119;
            this.btnImprimir.Text = "Imprimir Relatório";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGerarRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnGerarRelatorio.FlatAppearance.BorderSize = 0;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorio.Image = global::ContruSystem.Properties.Resources.iconReport;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(592, 28);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Padding = new System.Windows.Forms.Padding(1);
            this.btnGerarRelatorio.Size = new System.Drawing.Size(181, 37);
            this.btnGerarRelatorio.TabIndex = 105;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Gray;
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnExportar.Image = global::ContruSystem.Properties.Resources.IconExcel;
            this.btnExportar.Location = new System.Drawing.Point(309, 440);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Padding = new System.Windows.Forms.Padding(1);
            this.btnExportar.Size = new System.Drawing.Size(181, 37);
            this.btnExportar.TabIndex = 103;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FormTelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(928, 516);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.frmLblDataFinal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.frmLblPeriodo);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmLblDataInicial);
            this.Controls.Add(this.PanelDataInicial);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelaRelatorio";
            this.Text = "FormTelaFormulario";
            this.Load += new System.EventHandler(this.FormTelaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.PanelDataInicial.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmLblRelatorio;
        private System.Windows.Forms.Label frmLblPeriodo;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frmLblDataInicial;
        private System.Windows.Forms.Panel PanelDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label frmLblDataRelatorio;
        private System.Windows.Forms.Label frmLblDataFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label frmLblValorTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Button btnLimpar;
    }
}