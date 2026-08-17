namespace ContruSystem
{
    partial class FormTelaFuncionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.frmLblPesquisar = new System.Windows.Forms.Label();
            this.panelProcurar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.frmLblSalario = new System.Windows.Forms.Label();
            this.frmLblCodigoFunc = new System.Windows.Forms.Label();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.frmLblNome = new System.Windows.Forms.Label();
            this.panelQuantidade = new System.Windows.Forms.Panel();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.frmLblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.panelProduto = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.frmLblCpf = new System.Windows.Forms.Label();
            this.frmLblDataAdmissao = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.frmLblDadosFucionario = new System.Windows.Forms.Label();
            this.frmLblFuncionario = new System.Windows.Forms.Label();
            this.panelProcurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelData.SuspendLayout();
            this.PanelCodigo.SuspendLayout();
            this.panelQuantidade.SuspendLayout();
            this.panelProduto.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLblPesquisar
            // 
            this.frmLblPesquisar.AutoSize = true;
            this.frmLblPesquisar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblPesquisar.Location = new System.Drawing.Point(519, 87);
            this.frmLblPesquisar.Name = "frmLblPesquisar";
            this.frmLblPesquisar.Size = new System.Drawing.Size(94, 19);
            this.frmLblPesquisar.TabIndex = 85;
            this.frmLblPesquisar.Text = "Pesquisar:";
            // 
            // panelProcurar
            // 
            this.panelProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProcurar.Controls.Add(this.pictureBox1);
            this.panelProcurar.Controls.Add(this.txtPesquisar);
            this.panelProcurar.Location = new System.Drawing.Point(617, 87);
            this.panelProcurar.Name = "panelProcurar";
            this.panelProcurar.Size = new System.Drawing.Size(288, 21);
            this.panelProcurar.TabIndex = 84;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ContruSystem.Properties.Resources.iconProcurar2;
            this.pictureBox1.Location = new System.Drawing.Point(267, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.White;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtPesquisar.Location = new System.Drawing.Point(0, 0);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(286, 19);
            this.txtPesquisar.TabIndex = 18;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnEditar.Location = new System.Drawing.Point(145, 352);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(1);
            this.btnEditar.Size = new System.Drawing.Size(90, 37);
            this.btnEditar.TabIndex = 82;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnExcluir.TabIndex = 81;
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
            this.btnSalvar.TabIndex = 80;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Location = new System.Drawing.Point(523, 127);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(382, 311);
            this.dataGridView.TabIndex = 79;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(492, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 462);
            this.label1.TabIndex = 78;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnLimpar.Location = new System.Drawing.Point(372, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(1);
            this.btnLimpar.Size = new System.Drawing.Size(90, 37);
            this.btnLimpar.TabIndex = 77;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.txtNome);
            this.panelData.Location = new System.Drawing.Point(170, 127);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(293, 21);
            this.panelData.TabIndex = 72;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtNome.Location = new System.Drawing.Point(0, 0);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 19);
            this.txtNome.TabIndex = 18;
            // 
            // frmLblSalario
            // 
            this.frmLblSalario.AutoSize = true;
            this.frmLblSalario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblSalario.Location = new System.Drawing.Point(28, 244);
            this.frmLblSalario.Name = "frmLblSalario";
            this.frmLblSalario.Size = new System.Drawing.Size(104, 19);
            this.frmLblSalario.TabIndex = 70;
            this.frmLblSalario.Text = "Salário:  R$";
            // 
            // frmLblCodigoFunc
            // 
            this.frmLblCodigoFunc.AutoSize = true;
            this.frmLblCodigoFunc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblCodigoFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblCodigoFunc.Location = new System.Drawing.Point(27, 90);
            this.frmLblCodigoFunc.Name = "frmLblCodigoFunc";
            this.frmLblCodigoFunc.Size = new System.Drawing.Size(71, 19);
            this.frmLblCodigoFunc.TabIndex = 67;
            this.frmLblCodigoFunc.Text = "Código:";
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCodigo.Controls.Add(this.txtCodigoFuncionario);
            this.PanelCodigo.Location = new System.Drawing.Point(170, 88);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(89, 21);
            this.PanelCodigo.TabIndex = 71;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.BackColor = System.Drawing.Color.White;
            this.txtCodigoFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoFuncionario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(0, 0);
            this.txtCodigoFuncionario.Multiline = true;
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.ReadOnly = true;
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(87, 19);
            this.txtCodigoFuncionario.TabIndex = 18;
            this.txtCodigoFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLblNome
            // 
            this.frmLblNome.AutoSize = true;
            this.frmLblNome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblNome.Location = new System.Drawing.Point(27, 127);
            this.frmLblNome.Name = "frmLblNome";
            this.frmLblNome.Size = new System.Drawing.Size(62, 19);
            this.frmLblNome.TabIndex = 68;
            this.frmLblNome.Text = "Nome:";
            // 
            // panelQuantidade
            // 
            this.panelQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuantidade.Controls.Add(this.txtSalario);
            this.panelQuantidade.Location = new System.Drawing.Point(169, 244);
            this.panelQuantidade.Name = "panelQuantidade";
            this.panelQuantidade.Size = new System.Drawing.Size(145, 21);
            this.panelQuantidade.TabIndex = 74;
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.White;
            this.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSalario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtSalario.Location = new System.Drawing.Point(0, 0);
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(143, 19);
            this.txtSalario.TabIndex = 18;
            this.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLblCargo
            // 
            this.frmLblCargo.AutoSize = true;
            this.frmLblCargo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblCargo.Location = new System.Drawing.Point(27, 166);
            this.frmLblCargo.Name = "frmLblCargo";
            this.frmLblCargo.Size = new System.Drawing.Size(63, 19);
            this.frmLblCargo.TabIndex = 69;
            this.frmLblCargo.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.BackColor = System.Drawing.Color.White;
            this.cmbCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCargo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.cmbCargo.Location = new System.Drawing.Point(0, 0);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(292, 22);
            this.cmbCargo.TabIndex = 71;
            this.cmbCargo.DropDown += new System.EventHandler(this.cmbCargo_DropDown);
            // 
            // panelProduto
            // 
            this.panelProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProduto.Controls.Add(this.cmbCargo);
            this.panelProduto.Location = new System.Drawing.Point(169, 166);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(294, 21);
            this.panelProduto.TabIndex = 73;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.mskCpf);
            this.panel2.Location = new System.Drawing.Point(169, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 21);
            this.panel2.TabIndex = 87;
            // 
            // mskCpf
            // 
            this.mskCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mskCpf.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.mskCpf.Location = new System.Drawing.Point(0, 0);
            this.mskCpf.Mask = "000\\.000\\.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(142, 19);
            this.mskCpf.TabIndex = 19;
            this.mskCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmLblCpf
            // 
            this.frmLblCpf.AutoSize = true;
            this.frmLblCpf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblCpf.Location = new System.Drawing.Point(27, 205);
            this.frmLblCpf.Name = "frmLblCpf";
            this.frmLblCpf.Size = new System.Drawing.Size(46, 19);
            this.frmLblCpf.TabIndex = 86;
            this.frmLblCpf.Text = "CPF:";
            // 
            // frmLblDataAdmissao
            // 
            this.frmLblDataAdmissao.AutoSize = true;
            this.frmLblDataAdmissao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblDataAdmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblDataAdmissao.Location = new System.Drawing.Point(27, 284);
            this.frmLblDataAdmissao.Name = "frmLblDataAdmissao";
            this.frmLblDataAdmissao.Size = new System.Drawing.Size(137, 19);
            this.frmLblDataAdmissao.TabIndex = 88;
            this.frmLblDataAdmissao.Text = "Data Admissão:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtpDataAdmissao);
            this.panel3.Location = new System.Drawing.Point(170, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 21);
            this.panel3.TabIndex = 89;
            // 
            // dtpDataAdmissao
            // 
            this.dtpDataAdmissao.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDataAdmissao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDataAdmissao.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDataAdmissao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdmissao.Location = new System.Drawing.Point(0, 0);
            this.dtpDataAdmissao.Name = "dtpDataAdmissao";
            this.dtpDataAdmissao.Size = new System.Drawing.Size(143, 23);
            this.dtpDataAdmissao.TabIndex = 92;
            this.dtpDataAdmissao.Value = new System.DateTime(2026, 8, 16, 17, 15, 41, 0);
            // 
            // frmLblDadosFucionario
            // 
            this.frmLblDadosFucionario.AutoSize = true;
            this.frmLblDadosFucionario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblDadosFucionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblDadosFucionario.Location = new System.Drawing.Point(26, 35);
            this.frmLblDadosFucionario.Name = "frmLblDadosFucionario";
            this.frmLblDadosFucionario.Size = new System.Drawing.Size(217, 23);
            this.frmLblDadosFucionario.TabIndex = 90;
            this.frmLblDadosFucionario.Text = "Dados do Funcionário";
            // 
            // frmLblFuncionario
            // 
            this.frmLblFuncionario.AutoSize = true;
            this.frmLblFuncionario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblFuncionario.Location = new System.Drawing.Point(518, 35);
            this.frmLblFuncionario.Name = "frmLblFuncionario";
            this.frmLblFuncionario.Size = new System.Drawing.Size(256, 23);
            this.frmLblFuncionario.TabIndex = 91;
            this.frmLblFuncionario.Text = "Funcionários Cadastrados";
            // 
            // FormTelaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(928, 500);
            this.Controls.Add(this.frmLblFuncionario);
            this.Controls.Add(this.frmLblDadosFucionario);
            this.Controls.Add(this.frmLblDataAdmissao);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.frmLblCpf);
            this.Controls.Add(this.frmLblPesquisar);
            this.Controls.Add(this.panelProcurar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelProduto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.frmLblCargo);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.frmLblSalario);
            this.Controls.Add(this.frmLblCodigoFunc);
            this.Controls.Add(this.PanelCodigo);
            this.Controls.Add(this.frmLblNome);
            this.Controls.Add(this.panelQuantidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelaFuncionarios";
            this.Text = "FormTelaFuncionarios";
            this.panelProcurar.ResumeLayout(false);
            this.panelProcurar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.PanelCodigo.ResumeLayout(false);
            this.PanelCodigo.PerformLayout();
            this.panelQuantidade.ResumeLayout(false);
            this.panelQuantidade.PerformLayout();
            this.panelProduto.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmLblPesquisar;
        private System.Windows.Forms.Panel panelProcurar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label frmLblSalario;
        private System.Windows.Forms.Label frmLblCodigoFunc;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.Label frmLblNome;
        private System.Windows.Forms.Panel panelQuantidade;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label frmLblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label frmLblCpf;
        private System.Windows.Forms.Label frmLblDataAdmissao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label frmLblDadosFucionario;
        private System.Windows.Forms.Label frmLblFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.DateTimePicker dtpDataAdmissao;
    }
}