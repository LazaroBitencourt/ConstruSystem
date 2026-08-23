namespace ContruSystem
{
    partial class FormTelaUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.frmLblUsuarios = new System.Windows.Forms.Label();
            this.frmLblDadosUsuarios = new System.Windows.Forms.Label();
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
            this.frmLblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.frmLblLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.frmLblSenha = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.frmLblData = new System.Windows.Forms.Label();
            this.panelProduto = new System.Windows.Forms.Panel();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.frmLblTipoUsuario = new System.Windows.Forms.Label();
            this.panelProcurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLblUsuarios
            // 
            this.frmLblUsuarios.AutoSize = true;
            this.frmLblUsuarios.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblUsuarios.Location = new System.Drawing.Point(22, 167);
            this.frmLblUsuarios.Name = "frmLblUsuarios";
            this.frmLblUsuarios.Size = new System.Drawing.Size(217, 23);
            this.frmLblUsuarios.TabIndex = 113;
            this.frmLblUsuarios.Text = "Usuários Cadastrados";
            // 
            // frmLblDadosUsuarios
            // 
            this.frmLblDadosUsuarios.AutoSize = true;
            this.frmLblDadosUsuarios.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblDadosUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblDadosUsuarios.Location = new System.Drawing.Point(22, 10);
            this.frmLblDadosUsuarios.Name = "frmLblDadosUsuarios";
            this.frmLblDadosUsuarios.Size = new System.Drawing.Size(178, 23);
            this.frmLblDadosUsuarios.TabIndex = 112;
            this.frmLblDadosUsuarios.Text = "Dados do Usuário";
            // 
            // frmLblPesquisar
            // 
            this.frmLblPesquisar.AutoSize = true;
            this.frmLblPesquisar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblPesquisar.Location = new System.Drawing.Point(20, 205);
            this.frmLblPesquisar.Name = "frmLblPesquisar";
            this.frmLblPesquisar.Size = new System.Drawing.Size(94, 19);
            this.frmLblPesquisar.TabIndex = 107;
            this.frmLblPesquisar.Text = "Pesquisar:";
            // 
            // panelProcurar
            // 
            this.panelProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProcurar.Controls.Add(this.pictureBox1);
            this.panelProcurar.Controls.Add(this.txtPesquisar);
            this.panelProcurar.Location = new System.Drawing.Point(121, 205);
            this.panelProcurar.Name = "panelProcurar";
            this.panelProcurar.Size = new System.Drawing.Size(288, 21);
            this.panelProcurar.TabIndex = 106;
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
            this.btnEditar.Location = new System.Drawing.Point(215, 455);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(1);
            this.btnEditar.Size = new System.Drawing.Size(160, 37);
            this.btnEditar.TabIndex = 105;
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
            this.btnExcluir.Location = new System.Drawing.Point(406, 455);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(1);
            this.btnExcluir.Size = new System.Drawing.Size(160, 37);
            this.btnExcluir.TabIndex = 104;
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
            this.btnSalvar.Location = new System.Drawing.Point(24, 455);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(1);
            this.btnSalvar.Size = new System.Drawing.Size(160, 37);
            this.btnSalvar.TabIndex = 103;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(25, 241);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(875, 190);
            this.dataGridView.TabIndex = 102;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(27, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 2);
            this.label1.TabIndex = 101;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnLimpar.Location = new System.Drawing.Point(597, 455);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(1);
            this.btnLimpar.Size = new System.Drawing.Size(160, 37);
            this.btnLimpar.TabIndex = 100;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.txtNome);
            this.panelData.Location = new System.Drawing.Point(152, 46);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(293, 21);
            this.panelData.TabIndex = 97;
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
            // frmLblNome
            // 
            this.frmLblNome.AutoSize = true;
            this.frmLblNome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblNome.Location = new System.Drawing.Point(22, 46);
            this.frmLblNome.Name = "frmLblNome";
            this.frmLblNome.Size = new System.Drawing.Size(62, 19);
            this.frmLblNome.TabIndex = 93;
            this.frmLblNome.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Location = new System.Drawing.Point(152, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 21);
            this.panel1.TabIndex = 99;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtLogin.Location = new System.Drawing.Point(0, 0);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(291, 19);
            this.txtLogin.TabIndex = 18;
            // 
            // frmLblLogin
            // 
            this.frmLblLogin.AutoSize = true;
            this.frmLblLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblLogin.Location = new System.Drawing.Point(22, 85);
            this.frmLblLogin.Name = "frmLblLogin";
            this.frmLblLogin.Size = new System.Drawing.Size(59, 19);
            this.frmLblLogin.TabIndex = 98;
            this.frmLblLogin.Text = "Login:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Location = new System.Drawing.Point(152, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 21);
            this.panel2.TabIndex = 115;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSenha.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtSenha.Location = new System.Drawing.Point(0, 0);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(291, 19);
            this.txtSenha.TabIndex = 18;
            // 
            // frmLblSenha
            // 
            this.frmLblSenha.AutoSize = true;
            this.frmLblSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblSenha.Location = new System.Drawing.Point(22, 123);
            this.frmLblSenha.Name = "frmLblSenha";
            this.frmLblSenha.Size = new System.Drawing.Size(65, 19);
            this.frmLblSenha.TabIndex = 114;
            this.frmLblSenha.Text = "Senha:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtData);
            this.panel3.Location = new System.Drawing.Point(642, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 21);
            this.panel3.TabIndex = 117;
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
            this.txtData.Size = new System.Drawing.Size(99, 19);
            this.txtData.TabIndex = 18;
            // 
            // frmLblData
            // 
            this.frmLblData.AutoSize = true;
            this.frmLblData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblData.Location = new System.Drawing.Point(493, 46);
            this.frmLblData.Name = "frmLblData";
            this.frmLblData.Size = new System.Drawing.Size(120, 19);
            this.frmLblData.TabIndex = 116;
            this.frmLblData.Text = "Data Criação:";
            // 
            // panelProduto
            // 
            this.panelProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProduto.Controls.Add(this.cmbTipoUsuario);
            this.panelProduto.Location = new System.Drawing.Point(642, 86);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(173, 21);
            this.panelProduto.TabIndex = 75;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.BackColor = System.Drawing.Color.White;
            this.cmbTipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.cmbTipoUsuario.Location = new System.Drawing.Point(0, 0);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(171, 22);
            this.cmbTipoUsuario.TabIndex = 71;
            // 
            // frmLblTipoUsuario
            // 
            this.frmLblTipoUsuario.AutoSize = true;
            this.frmLblTipoUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.frmLblTipoUsuario.Location = new System.Drawing.Point(493, 86);
            this.frmLblTipoUsuario.Name = "frmLblTipoUsuario";
            this.frmLblTipoUsuario.Size = new System.Drawing.Size(143, 19);
            this.frmLblTipoUsuario.TabIndex = 74;
            this.frmLblTipoUsuario.Text = "Tipo de Usuário:";
            // 
            // FormTelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(928, 516);
            this.Controls.Add(this.panelProduto);
            this.Controls.Add(this.frmLblTipoUsuario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.frmLblData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.frmLblSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.frmLblLogin);
            this.Controls.Add(this.frmLblUsuarios);
            this.Controls.Add(this.frmLblDadosUsuarios);
            this.Controls.Add(this.frmLblPesquisar);
            this.Controls.Add(this.panelProcurar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.frmLblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelaUsuario";
            this.Text = "FormTelaUsuario";
            this.Load += new System.EventHandler(this.FormTelaUsuario_Load);
            this.panelProcurar.ResumeLayout(false);
            this.panelProcurar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelProduto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmLblUsuarios;
        private System.Windows.Forms.Label frmLblDadosUsuarios;
        private System.Windows.Forms.Label frmLblPesquisar;
        private System.Windows.Forms.Panel panelProcurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label frmLblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label frmLblLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label frmLblSenha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label frmLblData;
        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label frmLblTipoUsuario;
    }
}