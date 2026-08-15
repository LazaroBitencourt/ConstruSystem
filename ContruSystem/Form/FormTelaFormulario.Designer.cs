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
            this.FormTelaFormulariolblRel = new System.Windows.Forms.Label();
            this.FormTelaFormulariolblPeriodo = new System.Windows.Forms.Label();
            this.FormTelaFormularioDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FormTelaFormulariolblDataInicial = new System.Windows.Forms.Label();
            this.PanelDataInicial = new System.Windows.Forms.Panel();
            this.FormTelaFormularioDataInicial = new System.Windows.Forms.DateTimePicker();
            this.FormTelaFormularioPeriodoPesq = new System.Windows.Forms.Label();
            this.FormTelaFormulariolblDataFinal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FormTelaFormularioDataFinal = new System.Windows.Forms.DateTimePicker();
            this.FormTelaFormularioGerarBtn = new System.Windows.Forms.Button();
            this.FormTelaFormularioExportarExcBtn = new System.Windows.Forms.Button();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.FormTelaFormulariolblValorTotal = new System.Windows.Forms.Label();
            this.FormTelaFormularioValorTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FormTelaFormularioDataGridView)).BeginInit();
            this.PanelDataInicial.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTelaFormulariolblRel
            // 
            this.FormTelaFormulariolblRel.AutoSize = true;
            this.FormTelaFormulariolblRel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormulariolblRel.ForeColor = System.Drawing.Color.Black;
            this.FormTelaFormulariolblRel.Location = new System.Drawing.Point(313, 9);
            this.FormTelaFormulariolblRel.Name = "FormTelaFormulariolblRel";
            this.FormTelaFormulariolblRel.Size = new System.Drawing.Size(242, 23);
            this.FormTelaFormulariolblRel.TabIndex = 114;
            this.FormTelaFormulariolblRel.Text = "RELATÓRIO DE VENDAS";
            // 
            // FormTelaFormulariolblPeriodo
            // 
            this.FormTelaFormulariolblPeriodo.AutoSize = true;
            this.FormTelaFormulariolblPeriodo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormulariolblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.FormTelaFormulariolblPeriodo.Location = new System.Drawing.Point(22, 10);
            this.FormTelaFormulariolblPeriodo.Name = "FormTelaFormulariolblPeriodo";
            this.FormTelaFormulariolblPeriodo.Size = new System.Drawing.Size(83, 23);
            this.FormTelaFormulariolblPeriodo.TabIndex = 113;
            this.FormTelaFormulariolblPeriodo.Text = "Período";
            // 
            // FormTelaFormularioDataGridView
            // 
            this.FormTelaFormularioDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.FormTelaFormularioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormTelaFormularioDataGridView.Location = new System.Drawing.Point(13, 70);
            this.FormTelaFormularioDataGridView.Name = "FormTelaFormularioDataGridView";
            this.FormTelaFormularioDataGridView.ReadOnly = true;
            this.FormTelaFormularioDataGridView.Size = new System.Drawing.Size(848, 205);
            this.FormTelaFormularioDataGridView.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 2);
            this.label1.TabIndex = 101;
            // 
            // FormTelaFormulariolblDataInicial
            // 
            this.FormTelaFormulariolblDataInicial.AutoSize = true;
            this.FormTelaFormulariolblDataInicial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormulariolblDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.FormTelaFormulariolblDataInicial.Location = new System.Drawing.Point(22, 46);
            this.FormTelaFormulariolblDataInicial.Name = "FormTelaFormulariolblDataInicial";
            this.FormTelaFormulariolblDataInicial.Size = new System.Drawing.Size(133, 19);
            this.FormTelaFormulariolblDataInicial.TabIndex = 92;
            this.FormTelaFormulariolblDataInicial.Text = "Período Inicial:";
            // 
            // PanelDataInicial
            // 
            this.PanelDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDataInicial.Controls.Add(this.FormTelaFormularioDataInicial);
            this.PanelDataInicial.Location = new System.Drawing.Point(161, 44);
            this.PanelDataInicial.Name = "PanelDataInicial";
            this.PanelDataInicial.Size = new System.Drawing.Size(127, 21);
            this.PanelDataInicial.TabIndex = 96;
            // 
            // FormTelaFormularioDataInicial
            // 
            this.FormTelaFormularioDataInicial.CalendarForeColor = System.Drawing.Color.Black;
            this.FormTelaFormularioDataInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTelaFormularioDataInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.FormTelaFormularioDataInicial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormularioDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FormTelaFormularioDataInicial.Location = new System.Drawing.Point(0, 0);
            this.FormTelaFormularioDataInicial.Name = "FormTelaFormularioDataInicial";
            this.FormTelaFormularioDataInicial.Size = new System.Drawing.Size(125, 23);
            this.FormTelaFormularioDataInicial.TabIndex = 0;
            // 
            // FormTelaFormularioPeriodoPesq
            // 
            this.FormTelaFormularioPeriodoPesq.AutoSize = true;
            this.FormTelaFormularioPeriodoPesq.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormularioPeriodoPesq.ForeColor = System.Drawing.Color.Black;
            this.FormTelaFormularioPeriodoPesq.Location = new System.Drawing.Point(317, 41);
            this.FormTelaFormularioPeriodoPesq.Name = "FormTelaFormularioPeriodoPesq";
            this.FormTelaFormularioPeriodoPesq.Size = new System.Drawing.Size(233, 14);
            this.FormTelaFormularioPeriodoPesq.TabIndex = 115;
            this.FormTelaFormularioPeriodoPesq.Text = "Período: 01/05/2025 a 01/05/2025";
            this.FormTelaFormularioPeriodoPesq.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormTelaFormulariolblDataFinal
            // 
            this.FormTelaFormulariolblDataFinal.AutoSize = true;
            this.FormTelaFormulariolblDataFinal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormulariolblDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.FormTelaFormulariolblDataFinal.Location = new System.Drawing.Point(305, 46);
            this.FormTelaFormulariolblDataFinal.Name = "FormTelaFormulariolblDataFinal";
            this.FormTelaFormulariolblDataFinal.Size = new System.Drawing.Size(122, 19);
            this.FormTelaFormulariolblDataFinal.TabIndex = 116;
            this.FormTelaFormulariolblDataFinal.Text = "Período Final:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FormTelaFormularioDataFinal);
            this.panel1.Location = new System.Drawing.Point(444, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 21);
            this.panel1.TabIndex = 117;
            // 
            // FormTelaFormularioDataFinal
            // 
            this.FormTelaFormularioDataFinal.CalendarForeColor = System.Drawing.Color.Black;
            this.FormTelaFormularioDataFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTelaFormularioDataFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.FormTelaFormularioDataFinal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormularioDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FormTelaFormularioDataFinal.Location = new System.Drawing.Point(0, 0);
            this.FormTelaFormularioDataFinal.Name = "FormTelaFormularioDataFinal";
            this.FormTelaFormularioDataFinal.Size = new System.Drawing.Size(125, 23);
            this.FormTelaFormularioDataFinal.TabIndex = 0;
            // 
            // FormTelaFormularioGerarBtn
            // 
            this.FormTelaFormularioGerarBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FormTelaFormularioGerarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.FormTelaFormularioGerarBtn.FlatAppearance.BorderSize = 0;
            this.FormTelaFormularioGerarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormTelaFormularioGerarBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormularioGerarBtn.ForeColor = System.Drawing.Color.White;
            this.FormTelaFormularioGerarBtn.Image = global::ContruSystem.Properties.Resources.IconPrint1;
            this.FormTelaFormularioGerarBtn.Location = new System.Drawing.Point(592, 28);
            this.FormTelaFormularioGerarBtn.Name = "FormTelaFormularioGerarBtn";
            this.FormTelaFormularioGerarBtn.Padding = new System.Windows.Forms.Padding(1);
            this.FormTelaFormularioGerarBtn.Size = new System.Drawing.Size(181, 37);
            this.FormTelaFormularioGerarBtn.TabIndex = 105;
            this.FormTelaFormularioGerarBtn.Text = "Gerar Relatório";
            this.FormTelaFormularioGerarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FormTelaFormularioGerarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FormTelaFormularioGerarBtn.UseVisualStyleBackColor = false;
            // 
            // FormTelaFormularioExportarExcBtn
            // 
            this.FormTelaFormularioExportarExcBtn.BackColor = System.Drawing.Color.Gray;
            this.FormTelaFormularioExportarExcBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.FormTelaFormularioExportarExcBtn.FlatAppearance.BorderSize = 0;
            this.FormTelaFormularioExportarExcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormTelaFormularioExportarExcBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormularioExportarExcBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.FormTelaFormularioExportarExcBtn.Image = global::ContruSystem.Properties.Resources.IconExcel1;
            this.FormTelaFormularioExportarExcBtn.Location = new System.Drawing.Point(720, 440);
            this.FormTelaFormularioExportarExcBtn.Name = "FormTelaFormularioExportarExcBtn";
            this.FormTelaFormularioExportarExcBtn.Padding = new System.Windows.Forms.Padding(1);
            this.FormTelaFormularioExportarExcBtn.Size = new System.Drawing.Size(181, 37);
            this.FormTelaFormularioExportarExcBtn.TabIndex = 103;
            this.FormTelaFormularioExportarExcBtn.Text = "Exportar Excel";
            this.FormTelaFormularioExportarExcBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FormTelaFormularioExportarExcBtn.UseVisualStyleBackColor = false;
            this.FormTelaFormularioExportarExcBtn.Click += new System.EventHandler(this.FormTelaProdutosSalvarBtn_Click);
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormulario.Controls.Add(this.FormTelaFormularioValorTotal);
            this.panelFormulario.Controls.Add(this.FormTelaFormulariolblValorTotal);
            this.panelFormulario.Controls.Add(this.FormTelaFormularioDataGridView);
            this.panelFormulario.Controls.Add(this.FormTelaFormulariolblRel);
            this.panelFormulario.Controls.Add(this.FormTelaFormularioPeriodoPesq);
            this.panelFormulario.Location = new System.Drawing.Point(26, 92);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(875, 324);
            this.panelFormulario.TabIndex = 118;
            // 
            // FormTelaFormulariolblValorTotal
            // 
            this.FormTelaFormulariolblValorTotal.AutoSize = true;
            this.FormTelaFormulariolblValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.FormTelaFormulariolblValorTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormulariolblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.FormTelaFormulariolblValorTotal.Location = new System.Drawing.Point(582, 288);
            this.FormTelaFormulariolblValorTotal.Name = "FormTelaFormulariolblValorTotal";
            this.FormTelaFormulariolblValorTotal.Size = new System.Drawing.Size(122, 23);
            this.FormTelaFormulariolblValorTotal.TabIndex = 116;
            this.FormTelaFormulariolblValorTotal.Text = "Valor Total:";
            this.FormTelaFormulariolblValorTotal.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormTelaFormularioValorTotal
            // 
            this.FormTelaFormularioValorTotal.AutoSize = true;
            this.FormTelaFormularioValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.FormTelaFormularioValorTotal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaFormularioValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.FormTelaFormularioValorTotal.Location = new System.Drawing.Point(706, 283);
            this.FormTelaFormularioValorTotal.Name = "FormTelaFormularioValorTotal";
            this.FormTelaFormularioValorTotal.Size = new System.Drawing.Size(119, 29);
            this.FormTelaFormularioValorTotal.TabIndex = 117;
            this.FormTelaFormularioValorTotal.Text = "3.185,00";
            // 
            // FormTelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(928, 500);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.FormTelaFormulariolblDataFinal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FormTelaFormulariolblPeriodo);
            this.Controls.Add(this.FormTelaFormularioGerarBtn);
            this.Controls.Add(this.FormTelaFormularioExportarExcBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormTelaFormulariolblDataInicial);
            this.Controls.Add(this.PanelDataInicial);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelaRelatorio";
            this.Text = "FormTelaFormulario";
            this.Load += new System.EventHandler(this.FormTelaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormTelaFormularioDataGridView)).EndInit();
            this.PanelDataInicial.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormTelaFormulariolblRel;
        private System.Windows.Forms.Label FormTelaFormulariolblPeriodo;
        private System.Windows.Forms.Button FormTelaFormularioGerarBtn;
        private System.Windows.Forms.Button FormTelaFormularioExportarExcBtn;
        private System.Windows.Forms.DataGridView FormTelaFormularioDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FormTelaFormulariolblDataInicial;
        private System.Windows.Forms.Panel PanelDataInicial;
        private System.Windows.Forms.DateTimePicker FormTelaFormularioDataInicial;
        private System.Windows.Forms.Label FormTelaFormularioPeriodoPesq;
        private System.Windows.Forms.Label FormTelaFormulariolblDataFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker FormTelaFormularioDataFinal;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label FormTelaFormulariolblValorTotal;
        private System.Windows.Forms.Label FormTelaFormularioValorTotal;
    }
}