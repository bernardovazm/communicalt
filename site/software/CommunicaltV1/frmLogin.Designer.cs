namespace CommunicaltV1
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lbl_Communicalt = new System.Windows.Forms.Label();
            this.lbl_Icon = new System.Windows.Forms.Label();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.lbl_Conta = new System.Windows.Forms.Label();
            this.btn_Cadastre = new System.Windows.Forms.Button();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.chk_Lembrar = new System.Windows.Forms.CheckBox();
            this.lbl_LinkSenha = new System.Windows.Forms.Label();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.pnl_Top.SuspendLayout();
            this.panel_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Communicalt
            // 
            this.lbl_Communicalt.AutoSize = true;
            this.lbl_Communicalt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Communicalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Communicalt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Communicalt.Location = new System.Drawing.Point(83, 27);
            this.lbl_Communicalt.Name = "lbl_Communicalt";
            this.lbl_Communicalt.Size = new System.Drawing.Size(147, 25);
            this.lbl_Communicalt.TabIndex = 0;
            this.lbl_Communicalt.Text = "Communicalt";
            // 
            // lbl_Icon
            // 
            this.lbl_Icon.AutoSize = true;
            this.lbl_Icon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Icon.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Icon.Location = new System.Drawing.Point(64, 11);
            this.lbl_Icon.Name = "lbl_Icon";
            this.lbl_Icon.Size = new System.Drawing.Size(31, 24);
            this.lbl_Icon.TabIndex = 1;
            this.lbl_Icon.Text = "2";
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(246)))));
            this.pnl_Top.Controls.Add(this.lbl_Fechar);
            this.pnl_Top.Controls.Add(this.lbl_Communicalt);
            this.pnl_Top.Controls.Add(this.lbl_Icon);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(314, 71);
            this.pnl_Top.TabIndex = 3;
            this.pnl_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseDown);
            this.pnl_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseMove);
            this.pnl_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseUp);
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Fechar.Location = new System.Drawing.Point(293, 2);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(21, 20);
            this.lbl_Fechar.TabIndex = 2;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_Conta
            // 
            this.lbl_Conta.AutoSize = true;
            this.lbl_Conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Conta.Location = new System.Drawing.Point(12, 359);
            this.lbl_Conta.Name = "lbl_Conta";
            this.lbl_Conta.Size = new System.Drawing.Size(106, 13);
            this.lbl_Conta.TabIndex = 7;
            this.lbl_Conta.Text = "Não tem uma conta?";
            // 
            // btn_Cadastre
            // 
            this.btn_Cadastre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastre.Location = new System.Drawing.Point(209, 356);
            this.btn_Cadastre.Name = "btn_Cadastre";
            this.btn_Cadastre.Size = new System.Drawing.Size(93, 23);
            this.btn_Cadastre.TabIndex = 8;
            this.btn_Cadastre.Text = "Cadastre-se";
            this.btn_Cadastre.UseVisualStyleBackColor = true;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(125, 32);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(52, 20);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(125, 102);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(60, 20);
            this.lbl_Senha.TabIndex = 0;
            this.lbl_Senha.Text = "Senha:";
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(54, 56);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(204, 20);
            this.txt_Login.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(54, 126);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(204, 20);
            this.txt_Senha.TabIndex = 1;
            this.txt_Senha.UseSystemPasswordChar = true;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btn_Entrar.FlatAppearance.BorderSize = 0;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Entrar.Location = new System.Drawing.Point(54, 199);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(204, 37);
            this.btn_Entrar.TabIndex = 2;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_Lembrar
            // 
            this.chk_Lembrar.AutoSize = true;
            this.chk_Lembrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Lembrar.Location = new System.Drawing.Point(54, 152);
            this.chk_Lembrar.Name = "chk_Lembrar";
            this.chk_Lembrar.Size = new System.Drawing.Size(64, 17);
            this.chk_Lembrar.TabIndex = 3;
            this.chk_Lembrar.Text = "Lembrar";
            this.chk_Lembrar.UseVisualStyleBackColor = true;
            // 
            // lbl_LinkSenha
            // 
            this.lbl_LinkSenha.AutoSize = true;
            this.lbl_LinkSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LinkSenha.Location = new System.Drawing.Point(143, 153);
            this.lbl_LinkSenha.Name = "lbl_LinkSenha";
            this.lbl_LinkSenha.Size = new System.Drawing.Size(102, 13);
            this.lbl_LinkSenha.TabIndex = 4;
            this.lbl_LinkSenha.Text = "Esqueceu a senha?";
            // 
            // panel_Login
            // 
            this.panel_Login.Controls.Add(this.lbl_LinkSenha);
            this.panel_Login.Controls.Add(this.chk_Lembrar);
            this.panel_Login.Controls.Add(this.btn_Entrar);
            this.panel_Login.Controls.Add(this.txt_Senha);
            this.panel_Login.Controls.Add(this.txt_Login);
            this.panel_Login.Controls.Add(this.lbl_Senha);
            this.panel_Login.Controls.Add(this.lbl_Login);
            this.panel_Login.Location = new System.Drawing.Point(0, 69);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(314, 271);
            this.panel_Login.TabIndex = 6;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(314, 391);
            this.Controls.Add(this.btn_Cadastre);
            this.Controls.Add(this.lbl_Conta);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.pnl_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communicalt!";
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Communicalt;
        private System.Windows.Forms.Label lbl_Icon;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_Conta;
        private System.Windows.Forms.Button btn_Cadastre;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.CheckBox chk_Lembrar;
        private System.Windows.Forms.Label lbl_LinkSenha;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Label lbl_Fechar;
    }
}