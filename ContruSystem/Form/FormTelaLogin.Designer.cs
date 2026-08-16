namespace ContruSystem
{
    partial class FormTelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaLogin));
            this.pictureBoxLogoLogin = new System.Windows.Forms.PictureBox();
            this.labelTelaLogin = new System.Windows.Forms.Label();
            this.frmLblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.frmLblSenha = new System.Windows.Forms.Label();
            this.btnMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelSenha = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoLogin)).BeginInit();
            this.panelUsuario.SuspendLayout();
            this.panelSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogoLogin
            // 
            this.pictureBoxLogoLogin.Image = global::ContruSystem.Properties.Resources.logo_ContruSystem;
            this.pictureBoxLogoLogin.Location = new System.Drawing.Point(206, 30);
            this.pictureBoxLogoLogin.Name = "pictureBoxLogoLogin";
            this.pictureBoxLogoLogin.Size = new System.Drawing.Size(270, 150);
            this.pictureBoxLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoLogin.TabIndex = 0;
            this.pictureBoxLogoLogin.TabStop = false;
            // 
            // labelTelaLogin
            // 
            this.labelTelaLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.labelTelaLogin.Location = new System.Drawing.Point(138, 170);
            this.labelTelaLogin.Name = "labelTelaLogin";
            this.labelTelaLogin.Size = new System.Drawing.Size(405, 60);
            this.labelTelaLogin.TabIndex = 1;
            this.labelTelaLogin.Text = "Sistema de Gestão e Vendas para Loja de Materiais de Construção";
            this.labelTelaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLblUsuario
            // 
            this.frmLblUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.frmLblUsuario.Location = new System.Drawing.Point(136, 250);
            this.frmLblUsuario.Name = "frmLblUsuario";
            this.frmLblUsuario.Size = new System.Drawing.Size(107, 40);
            this.frmLblUsuario.TabIndex = 2;
            this.frmLblUsuario.Text = "Usuário";
            this.frmLblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtUsuario.Location = new System.Drawing.Point(12, 0);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(270, 29);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.txtSenha.Location = new System.Drawing.Point(12, 0);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(270, 29);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // frmLblSenha
            // 
            this.frmLblSenha.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.frmLblSenha.Location = new System.Drawing.Point(136, 311);
            this.frmLblSenha.Name = "frmLblSenha";
            this.frmLblSenha.Size = new System.Drawing.Size(107, 40);
            this.frmLblSenha.TabIndex = 4;
            this.frmLblSenha.Text = "Senha";
            this.frmLblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMostrarSenha
            // 
            this.btnMostrarSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.btnMostrarSenha.Location = new System.Drawing.Point(249, 366);
            this.btnMostrarSenha.Name = "btnMostrarSenha";
            this.btnMostrarSenha.Size = new System.Drawing.Size(144, 26);
            this.btnMostrarSenha.TabIndex = 6;
            this.btnMostrarSenha.Text = "Mostrar senha";
            this.btnMostrarSenha.UseVisualStyleBackColor = true;
            this.btnMostrarSenha.CheckedChanged += new System.EventHandler(this.FormTelaLoginMostrarSenha_CheckedChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnEntrar.Location = new System.Drawing.Point(249, 417);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(120, 36);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnSair.Location = new System.Drawing.Point(423, 417);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 36);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.FormTelaLoginSairBtn_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelUsuario.Controls.Add(this.txtUsuario);
            this.panelUsuario.Location = new System.Drawing.Point(249, 250);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(294, 29);
            this.panelUsuario.TabIndex = 9;
            // 
            // panelSenha
            // 
            this.panelSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelSenha.Controls.Add(this.txtSenha);
            this.panelSenha.Location = new System.Drawing.Point(249, 311);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(294, 29);
            this.panelSenha.TabIndex = 10;
            // 
            // FormTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panelSenha);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnMostrarSenha);
            this.Controls.Add(this.frmLblSenha);
            this.Controls.Add(this.frmLblUsuario);
            this.Controls.Add(this.labelTelaLogin);
            this.Controls.Add(this.pictureBoxLogoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConstruSystem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoLogin)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.panelSenha.ResumeLayout(false);
            this.panelSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoLogin;
        private System.Windows.Forms.Label labelTelaLogin;
        private System.Windows.Forms.Label frmLblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label frmLblSenha;
        private System.Windows.Forms.CheckBox btnMostrarSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelSenha;
    }
}

