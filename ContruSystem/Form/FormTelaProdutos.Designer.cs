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
            this.btnExcluir.Location = new System.Drawing.Point(324, 440);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(1);
            this.btnExcluir.Size = new System.Drawing.Size(112, 46);
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
            this.btnSalvar.Location = new System.Drawing.Point(39, 440);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(1);
            this.btnSalvar.Size = new System.Drawing.Size(112, 46);
            this.btnSalvar.TabIndex = 61;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(615, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 578);
            this.label1.TabIndex = 59;
            // 
            // panelProduto
            // 
            this.panelProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProduto.Controls.Add(this.cmbCategoria);
            this.panelProduto.Location = new System.Drawing.Point(196, 208);
            this.panelProduto.Margin = new System.Windows.Forms.Padding(4);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(384, 26);
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
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(382, 27);
            this.cmbCategoria.TabIndex = 71;
            this.cmbCategoria.DropDown += new System.EventHandler(this.cmbCategoria_DropDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnLimpar.Location = new System.Drawing.Point(468, 440);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(1);
            this.btnLimpar.Size = new System.Drawing.Size(112, 46);
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
            this.frmLblCategoria.Location = new System.Drawing.Point(32, 208);
            this.frmLblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frmLblCategoria.Name = "frmLblCategoria";
            this.frmLblCategoria.Size = new System.Drawing.Size(114, 24);
            this.frmLblCategoria.TabIndex = 44;
            this.frmLblCategoria.Text = "Categoria:";
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.txtDescricao);
            this.panelData.Location = new System.Drawing.Point(196, 159);
            this.panelData.Margin = new System.Windows.Forms.Padding(4);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(383, 26);
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
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(381, 24);
            this.txtDescricao.TabIndex = 18;
            // 
            // frmLblPrco
            // 
            this.frmLblPrco.AutoSize = true;
            this.frmLblPrco.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblPrco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblPrco.Location = new System.Drawing.Point(34, 256);
            this.frmLblPrco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frmLblPrco.Name = "frmLblPrco";
            this.frmLblPrco.Size = new System.Drawing.Size(114, 24);
            this.frmLblPrco.TabIndex = 45;
            this.frmLblPrco.Text = "Preço:  R$";
            // 
            // frmLblProduto
            // 
            this.frmLblProduto.AutoSize = true;
            this.frmLblProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblProduto.Location = new System.Drawing.Point(34, 112);
            this.frmLblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frmLblProduto.Name = "frmLblProduto";
            this.frmLblProduto.Size = new System.Drawing.Size(86, 24);
            this.frmLblProduto.TabIndex = 42;
            this.frmLblProduto.Text = "Código:";
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCodigo.Controls.Add(this.txtCodigoProduto);
            this.PanelCodigo.Location = new System.Drawing.Point(196, 112);
            this.PanelCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(124, 26);
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
            this.txtCodigoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProduto.Multiline = true;
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.ReadOnly = true;
            this.txtCodigoProduto.Size = new System.Drawing.Size(122, 24);
            this.txtCodigoProduto.TabIndex = 18;
            this.txtCodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEstoque);
            this.panel1.Location = new System.Drawing.Point(196, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 26);
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
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoque.Multiline = true;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(125, 24);
            this.txtEstoque.TabIndex = 18;
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLblDescricao
            // 
            this.frmLblDescricao.AutoSize = true;
            this.frmLblDescricao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblDescricao.Location = new System.Drawing.Point(32, 159);
            this.frmLblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frmLblDescricao.Name = "frmLblDescricao";
            this.frmLblDescricao.Size = new System.Drawing.Size(115, 24);
            this.frmLblDescricao.TabIndex = 43;
            this.frmLblDescricao.Text = "Descrição:";
            // 
            // panelQuantidade
            // 
            this.panelQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuantidade.Controls.Add(this.txtPreco);
            this.panelQuantidade.Location = new System.Drawing.Point(196, 256);
            this.panelQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.panelQuantidade.Name = "panelQuantidade";
            this.panelQuantidade.Size = new System.Drawing.Size(124, 26);
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
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(122, 24);
            this.txtPreco.TabIndex = 18;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLblEstoque
            // 
            this.frmLblEstoque.AutoSize = true;
            this.frmLblEstoque.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblEstoque.Location = new System.Drawing.Point(34, 305);
            this.frmLblEstoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frmLblEstoque.Name = "frmLblEstoque";
            this.frmLblEstoque.Size = new System.Drawing.Size(97, 24);
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
            this.btnEditar.Location = new System.Drawing.Point(180, 440);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(1);
            this.btnEditar.Size = new System.Drawing.Size(112, 46);
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
            this.panelProcurar.Location = new System.Drawing.Point(774, 109);
            this.panelProcurar.Margin = new System.Windows.Forms.Padding(4);
            this.panelProcurar.Name = "panelProcurar";
            this.panelProcurar.Size = new System.Drawing.Size(357, 26);
            this.panelProcurar.TabIndex = 65;
            // 
            // pictureBoxProcurar
            // 
            this.pictureBoxProcurar.BackColor = System.Drawing.Color.White;
            this.pictureBoxProcurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxProcurar.Image = global::ContruSystem.Properties.Resources.iconProcurar2;
            this.pictureBoxProcurar.Location = new System.Drawing.Point(331, 0);
            this.pictureBoxProcurar.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProcurar.Name = "pictureBoxProcurar";
            this.pictureBoxProcurar.Size = new System.Drawing.Size(24, 24);
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
            this.txtPesquisarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisarProduto.Multiline = true;
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.Size = new System.Drawing.Size(355, 24);
            this.txtPesquisarProduto.TabIndex = 18;
            this.txtPesquisarProduto.TextChanged += new System.EventHandler(this.txtPesquisarProduto_TextChanged);
            // 
            // frmLblPesqProduto
            // 
            this.frmLblPesqProduto.AutoSize = true;
            this.frmLblPesqProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblPesqProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblPesqProduto.Location = new System.Drawing.Point(648, 109);
            this.frmLblPesqProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frmLblPesqProduto.Name = "frmLblPesqProduto";
            this.frmLblPesqProduto.Size = new System.Drawing.Size(115, 24);
            this.frmLblPesqProduto.TabIndex = 66;
            this.frmLblPesqProduto.Text = "Pesquisar:";
            // 
            // FormTelaProdutoslbl
            // 
            this.FormTelaProdutoslbl.AutoSize = true;
            this.FormTelaProdutoslbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTelaProdutoslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.FormTelaProdutoslbl.Location = new System.Drawing.Point(32, 44);
            this.FormTelaProdutoslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormTelaProdutoslbl.Name = "FormTelaProdutoslbl";
            this.FormTelaProdutoslbl.Size = new System.Drawing.Size(227, 29);
            this.FormTelaProdutoslbl.TabIndex = 91;
            this.FormTelaProdutoslbl.Text = "Dados do Produto";
            // 
            // frmLblCadastroProduto
            // 
            this.frmLblCadastroProduto.AutoSize = true;
            this.frmLblCadastroProduto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblCadastroProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblCadastroProduto.Location = new System.Drawing.Point(648, 44);
            this.frmLblCadastroProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frmLblCadastroProduto.Name = "frmLblCadastroProduto";
            this.frmLblCadastroProduto.Size = new System.Drawing.Size(275, 29);
            this.frmLblCadastroProduto.TabIndex = 92;
            this.frmLblCadastroProduto.Text = "Produtos Cadastrados";
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridView);
            this.panelDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDataGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.panelDataGridView.Location = new System.Drawing.Point(652, 159);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(479, 389);
            this.panelDataGridView.TabIndex = 93;
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
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(479, 389);
            this.dataGridView.TabIndex = 60;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // FormTelaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1160, 625);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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