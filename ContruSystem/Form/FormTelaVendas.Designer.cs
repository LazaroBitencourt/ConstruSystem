namespace ContruSystem
{
    partial class FormTelaVendas
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
            this.frmLblCodVenda = new System.Windows.Forms.Label();
            this.frmLblData = new System.Windows.Forms.Label();
            this.frmLblqtd = new System.Windows.Forms.Label();
            this.frmLblVendedor = new System.Windows.Forms.Label();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.panelProcurar = new System.Windows.Forms.Panel();
            this.pictureBoxImgProc = new System.Windows.Forms.PictureBox();
            this.txtPesqProduto = new System.Windows.Forms.TextBox();
            this.panelQuantidade = new System.Windows.Forms.Panel();
            this.UDQuantidade = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.frmLblPreco = new System.Windows.Forms.Label();
            this.frmLblDesc = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtValTotal = new System.Windows.Forms.TextBox();
            this.frmLblValTotal = new System.Windows.Forms.Label();
            this.frmLblDadoVenda = new System.Windows.Forms.Label();
            this.frmLblAdicionaProduto = new System.Windows.Forms.Label();
            this.frmLblItens = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frmLblPesquisar = new System.Windows.Forms.Label();
            this.panelVendedor = new System.Windows.Forms.Panel();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.panelEstoque = new System.Windows.Forms.Panel();
            this.txtEstoqueDisponivel = new System.Windows.Forms.TextBox();
            this.frmLblEstoque = new System.Windows.Forms.Label();
            this.panelDesconto = new System.Windows.Forms.Panel();
            this.UDDesconto = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPesquisaProdutos = new System.Windows.Forms.DataGridView();
            this.PanelCodigo.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelProcurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgProc)).BeginInit();
            this.panelQuantidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQuantidade)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelVendedor.SuspendLayout();
            this.panelEstoque.SuspendLayout();
            this.panelDesconto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDDesconto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLblCodVenda
            // 
            this.frmLblCodVenda.AutoSize = true;
            this.frmLblCodVenda.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblCodVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblCodVenda.Location = new System.Drawing.Point(22, 46);
            this.frmLblCodVenda.Name = "frmLblCodVenda";
            this.frmLblCodVenda.Size = new System.Drawing.Size(127, 19);
            this.frmLblCodVenda.TabIndex = 0;
            this.frmLblCodVenda.Text = "Código Venda:";
            // 
            // frmLblData
            // 
            this.frmLblData.AutoSize = true;
            this.frmLblData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblData.Location = new System.Drawing.Point(281, 46);
            this.frmLblData.Name = "frmLblData";
            this.frmLblData.Size = new System.Drawing.Size(54, 19);
            this.frmLblData.TabIndex = 7;
            this.frmLblData.Text = "Data:";
            // 
            // frmLblqtd
            // 
            this.frmLblqtd.AutoSize = true;
            this.frmLblqtd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblqtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblqtd.Location = new System.Drawing.Point(22, 162);
            this.frmLblqtd.Name = "frmLblqtd";
            this.frmLblqtd.Size = new System.Drawing.Size(109, 19);
            this.frmLblqtd.TabIndex = 11;
            this.frmLblqtd.Text = "Quantidade:";
            // 
            // frmLblVendedor
            // 
            this.frmLblVendedor.AutoSize = true;
            this.frmLblVendedor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblVendedor.Location = new System.Drawing.Point(550, 43);
            this.frmLblVendedor.Name = "frmLblVendedor";
            this.frmLblVendedor.Size = new System.Drawing.Size(93, 19);
            this.frmLblVendedor.TabIndex = 14;
            this.frmLblVendedor.Text = "Vendedor:";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.BackColor = System.Drawing.Color.White;
            this.txtCodigoVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoVenda.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtCodigoVenda.Location = new System.Drawing.Point(0, 0);
            this.txtCodigoVenda.Multiline = true;
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.ReadOnly = true;
            this.txtCodigoVenda.Size = new System.Drawing.Size(98, 19);
            this.txtCodigoVenda.TabIndex = 18;
            this.txtCodigoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCodigo.Controls.Add(this.txtCodigoVenda);
            this.PanelCodigo.Location = new System.Drawing.Point(162, 44);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(100, 21);
            this.PanelCodigo.TabIndex = 19;
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.txtData);
            this.panelData.Location = new System.Drawing.Point(341, 45);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(191, 21);
            this.panelData.TabIndex = 20;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtData.Location = new System.Drawing.Point(0, 0);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(189, 19);
            this.txtData.TabIndex = 18;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelProcurar
            // 
            this.panelProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProcurar.Controls.Add(this.pictureBoxImgProc);
            this.panelProcurar.Controls.Add(this.txtPesqProduto);
            this.panelProcurar.Location = new System.Drawing.Point(162, 124);
            this.panelProcurar.Name = "panelProcurar";
            this.panelProcurar.Size = new System.Drawing.Size(245, 21);
            this.panelProcurar.TabIndex = 23;
            // 
            // pictureBoxImgProc
            // 
            this.pictureBoxImgProc.BackColor = System.Drawing.Color.White;
            this.pictureBoxImgProc.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxImgProc.Image = global::ContruSystem.Properties.Resources.iconProcurar2;
            this.pictureBoxImgProc.Location = new System.Drawing.Point(224, 0);
            this.pictureBoxImgProc.Name = "pictureBoxImgProc";
            this.pictureBoxImgProc.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxImgProc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxImgProc.TabIndex = 100;
            this.pictureBoxImgProc.TabStop = false;
            // 
            // txtPesqProduto
            // 
            this.txtPesqProduto.BackColor = System.Drawing.Color.White;
            this.txtPesqProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesqProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesqProduto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtPesqProduto.Location = new System.Drawing.Point(0, 0);
            this.txtPesqProduto.Multiline = true;
            this.txtPesqProduto.Name = "txtPesqProduto";
            this.txtPesqProduto.Size = new System.Drawing.Size(243, 19);
            this.txtPesqProduto.TabIndex = 18;
            this.txtPesqProduto.TextChanged += new System.EventHandler(this.txtPesqProduto_TextChanged);
            // 
            // panelQuantidade
            // 
            this.panelQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuantidade.Controls.Add(this.UDQuantidade);
            this.panelQuantidade.Location = new System.Drawing.Point(162, 162);
            this.panelQuantidade.Name = "panelQuantidade";
            this.panelQuantidade.Size = new System.Drawing.Size(98, 22);
            this.panelQuantidade.TabIndex = 24;
            // 
            // UDQuantidade
            // 
            this.UDQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UDQuantidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UDQuantidade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.UDQuantidade.Location = new System.Drawing.Point(0, 0);
            this.UDQuantidade.Name = "UDQuantidade";
            this.UDQuantidade.Size = new System.Drawing.Size(96, 23);
            this.UDQuantidade.TabIndex = 98;
            this.UDQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Location = new System.Drawing.Point(429, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 21);
            this.panel1.TabIndex = 26;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.White;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreco.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtPreco.Location = new System.Drawing.Point(0, 0);
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(100, 19);
            this.txtPreco.TabIndex = 18;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLblPreco
            // 
            this.frmLblPreco.AutoSize = true;
            this.frmLblPreco.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblPreco.Location = new System.Drawing.Point(275, 162);
            this.frmLblPreco.Name = "frmLblPreco";
            this.frmLblPreco.Size = new System.Drawing.Size(148, 18);
            this.frmLblPreco.TabIndex = 25;
            this.frmLblPreco.Text = "Preço unitário:  R$";
            // 
            // frmLblDesc
            // 
            this.frmLblDesc.AutoSize = true;
            this.frmLblDesc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblDesc.Location = new System.Drawing.Point(584, 124);
            this.frmLblDesc.Name = "frmLblDesc";
            this.frmLblDesc.Size = new System.Drawing.Size(128, 19);
            this.frmLblDesc.TabIndex = 27;
            this.frmLblDesc.Text = "Desconto (%):";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnAdicionar.Location = new System.Drawing.Point(740, 146);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdicionar.Size = new System.Drawing.Size(160, 37);
            this.btnAdicionar.TabIndex = 29;
            this.btnAdicionar.Text = "Adicionar ";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 2);
            this.label1.TabIndex = 30;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(875, 121);
            this.dataGridView.TabIndex = 31;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Green;
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnFinalizar.Location = new System.Drawing.Point(561, 427);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Padding = new System.Windows.Forms.Padding(1);
            this.btnFinalizar.Size = new System.Drawing.Size(160, 37);
            this.btnFinalizar.TabIndex = 32;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnCancelar.Location = new System.Drawing.Point(741, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Size = new System.Drawing.Size(160, 37);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(26, 379);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(1);
            this.btnEditar.Size = new System.Drawing.Size(160, 37);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar Item";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(210, 379);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(1);
            this.btnLimpar.Size = new System.Drawing.Size(160, 37);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.Text = "Remover Item";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtValTotal);
            this.panel5.Location = new System.Drawing.Point(668, 379);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 30);
            this.panel5.TabIndex = 41;
            // 
            // txtValTotal
            // 
            this.txtValTotal.BackColor = System.Drawing.Color.White;
            this.txtValTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValTotal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtValTotal.Location = new System.Drawing.Point(0, 0);
            this.txtValTotal.Multiline = true;
            this.txtValTotal.Name = "txtValTotal";
            this.txtValTotal.ReadOnly = true;
            this.txtValTotal.Size = new System.Drawing.Size(231, 28);
            this.txtValTotal.TabIndex = 18;
            this.txtValTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLblValTotal
            // 
            this.frmLblValTotal.AutoSize = true;
            this.frmLblValTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblValTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblValTotal.Location = new System.Drawing.Point(524, 388);
            this.frmLblValTotal.Name = "frmLblValTotal";
            this.frmLblValTotal.Size = new System.Drawing.Size(138, 19);
            this.frmLblValTotal.TabIndex = 40;
            this.frmLblValTotal.Text = "Valor Total:  R$";
            // 
            // frmLblDadoVenda
            // 
            this.frmLblDadoVenda.AutoSize = true;
            this.frmLblDadoVenda.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblDadoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblDadoVenda.Location = new System.Drawing.Point(22, 10);
            this.frmLblDadoVenda.Name = "frmLblDadoVenda";
            this.frmLblDadoVenda.Size = new System.Drawing.Size(163, 23);
            this.frmLblDadoVenda.TabIndex = 92;
            this.frmLblDadoVenda.Text = "Dados da Venda";
            // 
            // frmLblAdicionaProduto
            // 
            this.frmLblAdicionaProduto.AutoSize = true;
            this.frmLblAdicionaProduto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblAdicionaProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblAdicionaProduto.Location = new System.Drawing.Point(22, 89);
            this.frmLblAdicionaProduto.Name = "frmLblAdicionaProduto";
            this.frmLblAdicionaProduto.Size = new System.Drawing.Size(192, 23);
            this.frmLblAdicionaProduto.TabIndex = 93;
            this.frmLblAdicionaProduto.Text = "Adicionar Produtos";
            // 
            // frmLblItens
            // 
            this.frmLblItens.AutoSize = true;
            this.frmLblItens.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblItens.Location = new System.Drawing.Point(22, 210);
            this.frmLblItens.Name = "frmLblItens";
            this.frmLblItens.Size = new System.Drawing.Size(154, 23);
            this.frmLblItens.TabIndex = 94;
            this.frmLblItens.Text = "Itens da Venda";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(27, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(874, 2);
            this.label4.TabIndex = 95;
            // 
            // frmLblPesquisar
            // 
            this.frmLblPesquisar.AutoSize = true;
            this.frmLblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.frmLblPesquisar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblPesquisar.Location = new System.Drawing.Point(22, 124);
            this.frmLblPesquisar.Name = "frmLblPesquisar";
            this.frmLblPesquisar.Size = new System.Drawing.Size(134, 19);
            this.frmLblPesquisar.TabIndex = 96;
            this.frmLblPesquisar.Text = "Pesq. Produto.:";
            // 
            // panelVendedor
            // 
            this.panelVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVendedor.Controls.Add(this.cmbFuncionario);
            this.panelVendedor.Location = new System.Drawing.Point(649, 43);
            this.panelVendedor.Name = "panelVendedor";
            this.panelVendedor.Size = new System.Drawing.Size(252, 21);
            this.panelVendedor.TabIndex = 97;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.BackColor = System.Drawing.Color.White;
            this.cmbFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFuncionario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(0, 0);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(250, 24);
            this.cmbFuncionario.TabIndex = 71;
            // 
            // panelEstoque
            // 
            this.panelEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEstoque.Controls.Add(this.txtEstoqueDisponivel);
            this.panelEstoque.Location = new System.Drawing.Point(530, 126);
            this.panelEstoque.Name = "panelEstoque";
            this.panelEstoque.Size = new System.Drawing.Size(46, 21);
            this.panelEstoque.TabIndex = 28;
            // 
            // txtEstoqueDisponivel
            // 
            this.txtEstoqueDisponivel.BackColor = System.Drawing.Color.White;
            this.txtEstoqueDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstoqueDisponivel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstoqueDisponivel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueDisponivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtEstoqueDisponivel.Location = new System.Drawing.Point(0, 0);
            this.txtEstoqueDisponivel.Multiline = true;
            this.txtEstoqueDisponivel.Name = "txtEstoqueDisponivel";
            this.txtEstoqueDisponivel.ReadOnly = true;
            this.txtEstoqueDisponivel.Size = new System.Drawing.Size(44, 19);
            this.txtEstoqueDisponivel.TabIndex = 18;
            this.txtEstoqueDisponivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLblEstoque
            // 
            this.frmLblEstoque.AutoSize = true;
            this.frmLblEstoque.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblEstoque.Location = new System.Drawing.Point(450, 125);
            this.frmLblEstoque.Name = "frmLblEstoque";
            this.frmLblEstoque.Size = new System.Drawing.Size(74, 19);
            this.frmLblEstoque.TabIndex = 27;
            this.frmLblEstoque.Text = "Estoque";
            // 
            // panelDesconto
            // 
            this.panelDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesconto.Controls.Add(this.UDDesconto);
            this.panelDesconto.Location = new System.Drawing.Point(588, 163);
            this.panelDesconto.Name = "panelDesconto";
            this.panelDesconto.Size = new System.Drawing.Size(124, 22);
            this.panelDesconto.TabIndex = 99;
            // 
            // UDDesconto
            // 
            this.UDDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UDDesconto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UDDesconto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.UDDesconto.Location = new System.Drawing.Point(0, 0);
            this.UDDesconto.Name = "UDDesconto";
            this.UDDesconto.Size = new System.Drawing.Size(122, 23);
            this.UDDesconto.TabIndex = 98;
            this.UDDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPesquisaProdutos);
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Location = new System.Drawing.Point(26, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 121);
            this.panel2.TabIndex = 101;
            // 
            // dgvPesquisaProdutos
            // 
            this.dgvPesquisaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesquisaProdutos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesquisaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPesquisaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPesquisaProdutos.EnableHeadersVisualStyles = false;
            this.dgvPesquisaProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvPesquisaProdutos.Name = "dgvPesquisaProdutos";
            this.dgvPesquisaProdutos.ReadOnly = true;
            this.dgvPesquisaProdutos.Size = new System.Drawing.Size(875, 121);
            this.dgvPesquisaProdutos.TabIndex = 100;
            this.dgvPesquisaProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisaProdutos_CellClick_1);
            // 
            // FormTelaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(928, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDesconto);
            this.Controls.Add(this.panelEstoque);
            this.Controls.Add(this.frmLblEstoque);
            this.Controls.Add(this.panelVendedor);
            this.Controls.Add(this.frmLblPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frmLblItens);
            this.Controls.Add(this.frmLblAdicionaProduto);
            this.Controls.Add(this.frmLblDadoVenda);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.frmLblValTotal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.frmLblqtd);
            this.Controls.Add(this.frmLblCodVenda);
            this.Controls.Add(this.frmLblDesc);
            this.Controls.Add(this.PanelCodigo);
            this.Controls.Add(this.frmLblVendedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.frmLblData);
            this.Controls.Add(this.panelProcurar);
            this.Controls.Add(this.panelQuantidade);
            this.Controls.Add(this.frmLblPreco);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelaVendas";
            this.Load += new System.EventHandler(this.FormTelaVendas_Load);
            this.PanelCodigo.ResumeLayout(false);
            this.PanelCodigo.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelProcurar.ResumeLayout(false);
            this.panelProcurar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgProc)).EndInit();
            this.panelQuantidade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UDQuantidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelVendedor.ResumeLayout(false);
            this.panelEstoque.ResumeLayout(false);
            this.panelEstoque.PerformLayout();
            this.panelDesconto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UDDesconto)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmLblCodVenda;
        private System.Windows.Forms.Label frmLblData;
        private System.Windows.Forms.Label frmLblqtd;
        private System.Windows.Forms.Label frmLblVendedor;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Panel panelProcurar;
        private System.Windows.Forms.TextBox txtPesqProduto;
        private System.Windows.Forms.Panel panelQuantidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label frmLblPreco;
        private System.Windows.Forms.Label frmLblDesc;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtValTotal;
        private System.Windows.Forms.Label frmLblValTotal;
        private System.Windows.Forms.Label frmLblDadoVenda;
        private System.Windows.Forms.Label frmLblAdicionaProduto;
        private System.Windows.Forms.Label frmLblItens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label frmLblPesquisar;
        private System.Windows.Forms.Panel panelVendedor;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Panel panelEstoque;
        private System.Windows.Forms.TextBox txtEstoqueDisponivel;
        private System.Windows.Forms.Label frmLblEstoque;
        private System.Windows.Forms.NumericUpDown UDQuantidade;
        private System.Windows.Forms.Panel panelDesconto;
        private System.Windows.Forms.NumericUpDown UDDesconto;
        private System.Windows.Forms.PictureBox pictureBoxImgProc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPesquisaProdutos;
    }
}