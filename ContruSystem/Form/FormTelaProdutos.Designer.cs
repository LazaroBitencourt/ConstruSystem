namespace ContruSystem
{
    partial class FormTelaProdutos
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProduto = new System.Windows.Forms.Panel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.frmLblCategoria = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.frmLblPrco = new System.Windows.Forms.Label();
            this.frmLblProduto = new System.Windows.Forms.Label();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.frmLblDescricao = new System.Windows.Forms.Label();
            this.panelQuantidade = new System.Windows.Forms.Panel();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.frmLblEstoque = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelProcurar = new System.Windows.Forms.Panel();
            this.pictureBoxProcurar = new System.Windows.Forms.PictureBox();
            this.txtPesquisarProduto = new System.Windows.Forms.TextBox();
            this.frmLblPesqProduto = new System.Windows.Forms.Label();
            this.FormTelaProdutoslbl = new System.Windows.Forms.Label();
            this.frmLblCadastroProduto = new System.Windows.Forms.Label();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelProduto.SuspendLayout();
            this.panelData.SuspendLayout();
            this.PanelCodigo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelQuantidade.SuspendLayout();
            this.panelProcurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcurar)).BeginInit();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnExcluir.Location = new System.Drawing.Point(259, 352);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(1);
            this.btnExcluir.Size = new System.Drawing.Size(90, 37);
            this.btnExcluir.TabIndex = 62;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnSalvar.Location = new System.Drawing.Point(31, 352);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(1);
            this.btnSalvar.Size = new System.Drawing.Size(90, 37);
            this.btnSalvar.TabIndex = 61;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(492, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 462);
            this.label1.TabIndex = 59;
            // 
            // panelProduto
            // 
            this.panelProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProduto.Controls.Add(this.cmbCategoria);
            this.panelProduto.Location = new System.Drawing.Point(157, 166);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(308, 21);
            this.panelProduto.TabIndex = 51;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.White;
            this.cmbCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(0, 0);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(306, 24);
            this.cmbCategoria.TabIndex = 71;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnLimpar.Location = new System.Drawing.Point(374, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(1);
            this.btnLimpar.Size = new System.Drawing.Size(90, 37);
            this.btnLimpar.TabIndex = 58;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmLblCategoria
            // 
            this.frmLblCategoria.AutoSize = true;
            this.frmLblCategoria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblCategoria.Location = new System.Drawing.Point(26, 166);
            this.frmLblCategoria.Name = "frmLblCategoria";
            this.frmLblCategoria.Size = new System.Drawing.Size(95, 19);
            this.frmLblCategoria.TabIndex = 44;
            this.frmLblCategoria.Text = "Categoria:";
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.txtDescricao);
            this.panelData.Location = new System.Drawing.Point(157, 127);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(307, 21);
            this.panelData.TabIndex = 49;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtDescricao.Location = new System.Drawing.Point(0, 0);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(305, 19);
            this.txtDescricao.TabIndex = 18;
            // 
            // frmLblPrco
            // 
            this.frmLblPrco.AutoSize = true;
            this.frmLblPrco.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblPrco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblPrco.Location = new System.Drawing.Point(27, 205);
            this.frmLblPrco.Name = "frmLblPrco";
            this.frmLblPrco.Size = new System.Drawing.Size(61, 19);
            this.frmLblPrco.TabIndex = 45;
            this.frmLblPrco.Text = "Preço:";
            // 
            // frmLblProduto
            // 
            this.frmLblProduto.AutoSize = true;
            this.frmLblProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblProduto.Location = new System.Drawing.Point(27, 90);
            this.frmLblProduto.Name = "frmLblProduto";
            this.frmLblProduto.Size = new System.Drawing.Size(71, 19);
            this.frmLblProduto.TabIndex = 42;
            this.frmLblProduto.Text = "Código:";
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCodigo.Controls.Add(this.txtCodigoProduto);
            this.PanelCodigo.Location = new System.Drawing.Point(157, 90);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(100, 21);
            this.PanelCodigo.TabIndex = 48;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.BackColor = System.Drawing.Color.White;
            this.txtCodigoProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoProduto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtCodigoProduto.Location = new System.Drawing.Point(0, 0);
            this.txtCodigoProduto.Multiline = true;
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(98, 19);
            this.txtCodigoProduto.TabIndex = 18;
            this.txtCodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEstoque);
            this.panel1.Location = new System.Drawing.Point(157, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 21);
            this.panel1.TabIndex = 55;
            // 
            // txtEstoque
            // 
            this.txtEstoque.BackColor = System.Drawing.Color.White;
            this.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstoque.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtEstoque.Location = new System.Drawing.Point(0, 0);
            this.txtEstoque.Multiline = true;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(100, 19);
            this.txtEstoque.TabIndex = 18;
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLblDescricao
            // 
            this.frmLblDescricao.AutoSize = true;
            this.frmLblDescricao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblDescricao.Location = new System.Drawing.Point(26, 127);
            this.frmLblDescricao.Name = "frmLblDescricao";
            this.frmLblDescricao.Size = new System.Drawing.Size(93, 19);
            this.frmLblDescricao.TabIndex = 43;
            this.frmLblDescricao.Text = "Descrição:";
            // 
            // panelQuantidade
            // 
            this.panelQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuantidade.Controls.Add(this.txtPreco);
            this.panelQuantidade.Location = new System.Drawing.Point(157, 205);
            this.panelQuantidade.Name = "panelQuantidade";
            this.panelQuantidade.Size = new System.Drawing.Size(100, 21);
            this.panelQuantidade.TabIndex = 53;
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
            this.txtPreco.Size = new System.Drawing.Size(98, 19);
            this.txtPreco.TabIndex = 18;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLblEstoque
            // 
            this.frmLblEstoque.AutoSize = true;
            this.frmLblEstoque.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblEstoque.Location = new System.Drawing.Point(27, 244);
            this.frmLblEstoque.Name = "frmLblEstoque";
            this.frmLblEstoque.Size = new System.Drawing.Size(80, 19);
            this.frmLblEstoque.TabIndex = 54;
            this.frmLblEstoque.Text = "Estoque:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnEditar.Location = new System.Drawing.Point(144, 352);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(1);
            this.btnEditar.Size = new System.Drawing.Size(90, 37);
            this.btnEditar.TabIndex = 63;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelProcurar
            // 
            this.panelProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProcurar.Controls.Add(this.pictureBoxProcurar);
            this.panelProcurar.Controls.Add(this.txtPesquisarProduto);
            this.panelProcurar.Location = new System.Drawing.Point(619, 87);
            this.panelProcurar.Name = "panelProcurar";
            this.panelProcurar.Size = new System.Drawing.Size(286, 21);
            this.panelProcurar.TabIndex = 65;
            // 
            // pictureBoxProcurar
            // 
            this.pictureBoxProcurar.BackColor = System.Drawing.Color.White;
            this.pictureBoxProcurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxProcurar.Image = global::ContruSystem.Properties.Resources.iconProcurar2;
            this.pictureBoxProcurar.Location = new System.Drawing.Point(265, 0);
            this.pictureBoxProcurar.Name = "pictureBoxProcurar";
            this.pictureBoxProcurar.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxProcurar.TabIndex = 93;
            this.pictureBoxProcurar.TabStop = false;
            // 
            // txtPesquisarProduto
            // 
            this.txtPesquisarProduto.BackColor = System.Drawing.Color.White;
            this.txtPesquisarProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisarProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisarProduto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtPesquisarProduto.Location = new System.Drawing.Point(0, 0);
            this.txtPesquisarProduto.Multiline = true;
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.Size = new System.Drawing.Size(284, 19);
            this.txtPesquisarProduto.TabIndex = 18;
            this.txtPesquisarProduto.TextChanged += new System.EventHandler(this.txtPesquisarProduto_TextChanged);
            // 
            // frmLblPesqProduto
            // 
            this.frmLblPesqProduto.AutoSize = true;
            this.frmLblPesqProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblPesqProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblPesqProduto.Location = new System.Drawing.Point(518, 87);
            this.frmLblPesqProduto.Name = "frmLblPesqProduto";
            this.frmLblPesqProduto.Size = new System.Drawing.Size(94, 19);
            this.frmLblPesqProduto.TabIndex = 66;
            this.frmLblPesqProduto.Text = "Pesquisar:";
            // 
            // FormTelaProdutoslbl
            // 
            this.FormTelaProdutoslbl.AutoSize = true;
            this.FormTelaProdutoslbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaProdutoslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.FormTelaProdutoslbl.Location = new System.Drawing.Point(26, 35);
            this.FormTelaProdutoslbl.Name = "FormTelaProdutoslbl";
            this.FormTelaProdutoslbl.Size = new System.Drawing.Size(181, 23);
            this.FormTelaProdutoslbl.TabIndex = 91;
            this.FormTelaProdutoslbl.Text = "Dados do Produto";
            // 
            // frmLblCadastroProduto
            // 
            this.frmLblCadastroProduto.AutoSize = true;
            this.frmLblCadastroProduto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblCadastroProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblCadastroProduto.Location = new System.Drawing.Point(518, 35);
            this.frmLblCadastroProduto.Name = "frmLblCadastroProduto";
            this.frmLblCadastroProduto.Size = new System.Drawing.Size(220, 23);
            this.frmLblCadastroProduto.TabIndex = 92;
            this.frmLblCadastroProduto.Text = "Produtos Cadastrados";
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridView);
            this.panelDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDataGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.panelDataGridView.Location = new System.Drawing.Point(522, 127);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(383, 311);
            this.panelDataGridView.TabIndex = 93;
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
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(383, 311);
            this.dataGridView.TabIndex = 60;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // FormTelaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(928, 500);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.frmLblCadastroProduto);
            this.Controls.Add(this.FormTelaProdutoslbl);
            this.Controls.Add(this.frmLblPesqProduto);
            this.Controls.Add(this.panelProcurar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelProduto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.frmLblCategoria);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.frmLblPrco);
            this.Controls.Add(this.frmLblProduto);
            this.Controls.Add(this.PanelCodigo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.frmLblDescricao);
            this.Controls.Add(this.panelQuantidade);
            this.Controls.Add(this.frmLblEstoque);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelaProdutos";
            this.Text = "FormTelaProdutos1";
            this.panelProduto.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.PanelCodigo.ResumeLayout(false);
            this.PanelCodigo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelQuantidade.ResumeLayout(false);
            this.panelQuantidade.PerformLayout();
            this.panelProcurar.ResumeLayout(false);
            this.panelProcurar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcurar)).EndInit();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label frmLblCategoria;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label frmLblPrco;
        private System.Windows.Forms.Label frmLblProduto;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label frmLblDescricao;
        private System.Windows.Forms.Panel panelQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label frmLblEstoque;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panelProcurar;
        private System.Windows.Forms.TextBox txtPesquisarProduto;
        private System.Windows.Forms.Label frmLblPesqProduto;
        private System.Windows.Forms.Label FormTelaProdutoslbl;
        private System.Windows.Forms.Label frmLblCadastroProduto;
        private System.Windows.Forms.PictureBox pictureBoxProcurar;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}