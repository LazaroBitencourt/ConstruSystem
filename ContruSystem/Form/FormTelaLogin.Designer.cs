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
            this.labelUsuarioLogin = new System.Windows.Forms.Label();
            this.textBoxCampoUsuarioLogin = new System.Windows.Forms.TextBox();
            this.textBoxCampoSenhaLogin = new System.Windows.Forms.TextBox();
            this.labelSenhaLogin = new System.Windows.Forms.Label();
            this.checboxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.btnSairLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoLogin
            // 
            this.pictureBoxLogoLogin.Image = global::ContruSystem.Properties.Resources.logo_ContruSystem;
            this.pictureBoxLogoLogin.Location = new System.Drawing.Point(204, 39);
            this.pictureBoxLogoLogin.Name = "pictureBoxLogoLogin";
            this.pictureBoxLogoLogin.Size = new System.Drawing.Size(270, 150);
            this.pictureBoxLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoLogin.TabIndex = 0;
            this.pictureBoxLogoLogin.TabStop = false;
            this.pictureBoxLogoLogin.Click += new System.EventHandler(this.pictureBoxLogoLogin_Click);
            // 
            // labelTelaLogin
            // 
            this.labelTelaLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.labelTelaLogin.Location = new System.Drawing.Point(136, 179);
            this.labelTelaLogin.Name = "labelTelaLogin";
            this.labelTelaLogin.Size = new System.Drawing.Size(405, 60);
            this.labelTelaLogin.TabIndex = 1;
            this.labelTelaLogin.Text = "Sistema de Gestão e Vendas para Loja de Materiais de Construção";
            this.labelTelaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTelaLogin.Click += new System.EventHandler(this.labelTelaLogin_Click);
            // 
            // labelUsuarioLogin
            // 
            this.labelUsuarioLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.labelUsuarioLogin.Location = new System.Drawing.Point(134, 259);
            this.labelUsuarioLogin.Name = "labelUsuarioLogin";
            this.labelUsuarioLogin.Size = new System.Drawing.Size(107, 40);
            this.labelUsuarioLogin.TabIndex = 2;
            this.labelUsuarioLogin.Text = "Usuário";
            this.labelUsuarioLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCampoUsuarioLogin
            // 
            this.textBoxCampoUsuarioLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxCampoUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCampoUsuarioLogin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCampoUsuarioLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.textBoxCampoUsuarioLogin.Location = new System.Drawing.Point(247, 263);
            this.textBoxCampoUsuarioLogin.MaxLength = 19;
            this.textBoxCampoUsuarioLogin.Multiline = true;
            this.textBoxCampoUsuarioLogin.Name = "textBoxCampoUsuarioLogin";
            this.textBoxCampoUsuarioLogin.Size = new System.Drawing.Size(294, 30);
            this.textBoxCampoUsuarioLogin.TabIndex = 3;
            // 
            // textBoxCampoSenhaLogin
            // 
            this.textBoxCampoSenhaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxCampoSenhaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCampoSenhaLogin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCampoSenhaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.textBoxCampoSenhaLogin.Location = new System.Drawing.Point(247, 324);
            this.textBoxCampoSenhaLogin.MaxLength = 20;
            this.textBoxCampoSenhaLogin.Name = "textBoxCampoSenhaLogin";
            this.textBoxCampoSenhaLogin.Size = new System.Drawing.Size(294, 29);
            this.textBoxCampoSenhaLogin.TabIndex = 5;
            this.textBoxCampoSenhaLogin.UseSystemPasswordChar = true;
            this.textBoxCampoSenhaLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelSenhaLogin
            // 
            this.labelSenhaLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.labelSenhaLogin.Location = new System.Drawing.Point(134, 320);
            this.labelSenhaLogin.Name = "labelSenhaLogin";
            this.labelSenhaLogin.Size = new System.Drawing.Size(107, 40);
            this.labelSenhaLogin.TabIndex = 4;
            this.labelSenhaLogin.Text = "Senha";
            this.labelSenhaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSenhaLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // checboxMostrarSenha
            // 
            this.checboxMostrarSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checboxMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.checboxMostrarSenha.Location = new System.Drawing.Point(247, 385);
            this.checboxMostrarSenha.Name = "checboxMostrarSenha";
            this.checboxMostrarSenha.Size = new System.Drawing.Size(144, 26);
            this.checboxMostrarSenha.TabIndex = 6;
            this.checboxMostrarSenha.Text = "Mostrar senha";
            this.checboxMostrarSenha.UseVisualStyleBackColor = true;
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.btnEntrarLogin.FlatAppearance.BorderSize = 0;
            this.btnEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnEntrarLogin.Location = new System.Drawing.Point(247, 436);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(120, 30);
            this.btnEntrarLogin.TabIndex = 7;
            this.btnEntrarLogin.Text = "Entrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = false;
            this.btnEntrarLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSairLogin
            // 
            this.btnSairLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnSairLogin.FlatAppearance.BorderSize = 0;
            this.btnSairLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnSairLogin.Location = new System.Drawing.Point(421, 436);
            this.btnSairLogin.Name = "btnSairLogin";
            this.btnSairLogin.Size = new System.Drawing.Size(120, 30);
            this.btnSairLogin.TabIndex = 8;
            this.btnSairLogin.Text = "Sair";
            this.btnSairLogin.UseVisualStyleBackColor = false;
            // 
            // FormTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btnSairLogin);
            this.Controls.Add(this.btnEntrarLogin);
            this.Controls.Add(this.checboxMostrarSenha);
            this.Controls.Add(this.textBoxCampoSenhaLogin);
            this.Controls.Add(this.labelSenhaLogin);
            this.Controls.Add(this.textBoxCampoUsuarioLogin);
            this.Controls.Add(this.labelUsuarioLogin);
            this.Controls.Add(this.labelTelaLogin);
            this.Controls.Add(this.pictureBoxLogoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConstruSystem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoLogin;
        private System.Windows.Forms.Label labelTelaLogin;
        private System.Windows.Forms.Label labelUsuarioLogin;
        private System.Windows.Forms.TextBox textBoxCampoUsuarioLogin;
        private System.Windows.Forms.TextBox textBoxCampoSenhaLogin;
        private System.Windows.Forms.Label labelSenhaLogin;
        private System.Windows.Forms.CheckBox checboxMostrarSenha;
        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Button btnSairLogin;
    }
}

