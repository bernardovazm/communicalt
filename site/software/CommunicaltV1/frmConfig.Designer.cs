namespace CommunicaltV1
{
    partial class frmConfig
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btn_Importar = new System.Windows.Forms.Button();
            this.btn_NovaPranch = new System.Windows.Forms.Button();
            this.btn_Pranchetas = new System.Windows.Forms.Button();
            this.btn_Simbolo = new System.Windows.Forms.Button();
            this.btn_Config = new System.Windows.Forms.Button();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.lbl_Communicalt = new System.Windows.Forms.Label();
            this.lbl_Icon = new System.Windows.Forms.Label();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.cmb_Tema = new System.Windows.Forms.ComboBox();
            this.lbl_Cor = new System.Windows.Forms.Label();
            this.lblLogado = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btn_Deslogar = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblInstituicao = new System.Windows.Forms.Label();
            this.txtInstituicao = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_Logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btn_Importar);
            this.panel1.Controls.Add(this.btn_NovaPranch);
            this.panel1.Controls.Add(this.btn_Pranchetas);
            this.panel1.Controls.Add(this.btn_Simbolo);
            this.panel1.Controls.Add(this.btn_Config);
            this.panel1.Controls.Add(this.pnl_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 548);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExportar.Location = new System.Drawing.Point(0, 357);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExportar.Size = new System.Drawing.Size(194, 56);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btn_Importar
            // 
            this.btn_Importar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btn_Importar.FlatAppearance.BorderSize = 0;
            this.btn_Importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Importar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Importar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Importar.Location = new System.Drawing.Point(0, 295);
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Importar.Size = new System.Drawing.Size(194, 56);
            this.btn_Importar.TabIndex = 1;
            this.btn_Importar.Text = "Importar";
            this.btn_Importar.UseVisualStyleBackColor = false;
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // btn_NovaPranch
            // 
            this.btn_NovaPranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btn_NovaPranch.FlatAppearance.BorderSize = 0;
            this.btn_NovaPranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NovaPranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovaPranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_NovaPranch.Location = new System.Drawing.Point(0, 239);
            this.btn_NovaPranch.Name = "btn_NovaPranch";
            this.btn_NovaPranch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_NovaPranch.Size = new System.Drawing.Size(194, 56);
            this.btn_NovaPranch.TabIndex = 1;
            this.btn_NovaPranch.Text = "Nova Prancheta";
            this.btn_NovaPranch.UseVisualStyleBackColor = false;
            this.btn_NovaPranch.Click += new System.EventHandler(this.btn_NovaPranch_Click);
            // 
            // btn_Pranchetas
            // 
            this.btn_Pranchetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btn_Pranchetas.FlatAppearance.BorderSize = 0;
            this.btn_Pranchetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pranchetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pranchetas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Pranchetas.Location = new System.Drawing.Point(0, 183);
            this.btn_Pranchetas.Name = "btn_Pranchetas";
            this.btn_Pranchetas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Pranchetas.Size = new System.Drawing.Size(194, 56);
            this.btn_Pranchetas.TabIndex = 1;
            this.btn_Pranchetas.Text = "Pranchetas";
            this.btn_Pranchetas.UseVisualStyleBackColor = false;
            this.btn_Pranchetas.Click += new System.EventHandler(this.btn_Pranchetas_Click);
            // 
            // btn_Simbolo
            // 
            this.btn_Simbolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btn_Simbolo.FlatAppearance.BorderSize = 0;
            this.btn_Simbolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Simbolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Simbolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Simbolo.Location = new System.Drawing.Point(0, 127);
            this.btn_Simbolo.Name = "btn_Simbolo";
            this.btn_Simbolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Simbolo.Size = new System.Drawing.Size(194, 56);
            this.btn_Simbolo.TabIndex = 1;
            this.btn_Simbolo.Text = "Novo Símbolo";
            this.btn_Simbolo.UseVisualStyleBackColor = false;
            this.btn_Simbolo.Click += new System.EventHandler(this.btn_Simbolo_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btn_Config.FlatAppearance.BorderSize = 0;
            this.btn_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Config.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Config.Location = new System.Drawing.Point(0, 71);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Config.Size = new System.Drawing.Size(194, 56);
            this.btn_Config.TabIndex = 1;
            this.btn_Config.Text = "Configurações";
            this.btn_Config.UseVisualStyleBackColor = false;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(246)))));
            this.pnl_Logo.Controls.Add(this.lbl_Communicalt);
            this.pnl_Logo.Controls.Add(this.lbl_Icon);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(194, 71);
            this.pnl_Logo.TabIndex = 0;
            this.pnl_Logo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Logo_Paint);
            // 
            // lbl_Communicalt
            // 
            this.lbl_Communicalt.AutoSize = true;
            this.lbl_Communicalt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Communicalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Communicalt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Communicalt.Location = new System.Drawing.Point(29, 22);
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
            this.lbl_Icon.Location = new System.Drawing.Point(10, 6);
            this.lbl_Icon.Name = "lbl_Icon";
            this.lbl_Icon.Size = new System.Drawing.Size(31, 24);
            this.lbl_Icon.TabIndex = 1;
            this.lbl_Icon.Text = "2";
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(246)))));
            this.pnl_Top.Location = new System.Drawing.Point(193, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(859, 10);
            this.pnl_Top.TabIndex = 1;
            this.pnl_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Top_Paint);
            this.pnl_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseDown);
            this.pnl_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseMove);
            this.pnl_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseUp);
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.lbl_Fechar.Location = new System.Drawing.Point(1030, 12);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(21, 20);
            this.lbl_Fechar.TabIndex = 1;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Fechar_MouseClick);
            // 
            // cmb_Tema
            // 
            this.cmb_Tema.Enabled = false;
            this.cmb_Tema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Tema.FormattingEnabled = true;
            this.cmb_Tema.Items.AddRange(new object[] {
            "Padrão",
            "Soft",
            "Noir",
            "Ruby"});
            this.cmb_Tema.Location = new System.Drawing.Point(401, 43);
            this.cmb_Tema.Name = "cmb_Tema";
            this.cmb_Tema.Size = new System.Drawing.Size(296, 28);
            this.cmb_Tema.TabIndex = 14;
            this.cmb_Tema.Text = "Selecione";
            // 
            // lbl_Cor
            // 
            this.lbl_Cor.AutoSize = true;
            this.lbl_Cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cor.Location = new System.Drawing.Point(239, 46);
            this.lbl_Cor.Name = "lbl_Cor";
            this.lbl_Cor.Size = new System.Drawing.Size(156, 20);
            this.lbl_Cor.TabIndex = 13;
            this.lbl_Cor.Text = "Modificar a cor tema:";
            // 
            // lblLogado
            // 
            this.lblLogado.AutoSize = true;
            this.lblLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogado.Location = new System.Drawing.Point(239, 89);
            this.lblLogado.Name = "lblLogado";
            this.lblLogado.Size = new System.Drawing.Size(110, 20);
            this.lblLogado.TabIndex = 15;
            this.lblLogado.Text = "Logado como:";
            this.lblLogado.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(355, 89);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 20);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "BetaTester";
            // 
            // btn_Deslogar
            // 
            this.btn_Deslogar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Deslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deslogar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Deslogar.Location = new System.Drawing.Point(243, 112);
            this.btn_Deslogar.Name = "btn_Deslogar";
            this.btn_Deslogar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Deslogar.Size = new System.Drawing.Size(180, 30);
            this.btn_Deslogar.TabIndex = 24;
            this.btn_Deslogar.Text = "Deslogar";
            this.btn_Deslogar.UseVisualStyleBackColor = false;
            this.btn_Deslogar.Click += new System.EventHandler(this.btn_Deslogar_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(215, 259);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(510, 185);
            this.txtMessage.TabIndex = 25;
            this.txtMessage.Text = "";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(272, 203);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 26;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(211, 201);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Nome:";
            // 
            // lblInstituicao
            // 
            this.lblInstituicao.AutoSize = true;
            this.lblInstituicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstituicao.Location = new System.Drawing.Point(457, 203);
            this.lblInstituicao.Name = "lblInstituicao";
            this.lblInstituicao.Size = new System.Drawing.Size(86, 20);
            this.lblInstituicao.TabIndex = 28;
            this.lblInstituicao.Text = "Instituição:";
            // 
            // txtInstituicao
            // 
            this.txtInstituicao.Location = new System.Drawing.Point(549, 203);
            this.txtInstituicao.Name = "txtInstituicao";
            this.txtInstituicao.Size = new System.Drawing.Size(176, 20);
            this.txtInstituicao.TabIndex = 29;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(211, 236);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(83, 20);
            this.lblMessage.TabIndex = 30;
            this.lblMessage.Text = "Mesagem:";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(211, 163);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(80, 20);
            this.lblFeedback.TabIndex = 31;
            this.lblFeedback.Text = "Feedback";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnviar.Location = new System.Drawing.Point(545, 450);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEnviar.Size = new System.Drawing.Size(180, 30);
            this.btnEnviar.TabIndex = 32;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 548);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtInstituicao);
            this.Controls.Add(this.lblInstituicao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btn_Deslogar);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLogado);
            this.Controls.Add(this.cmb_Tema);
            this.Controls.Add(this.lbl_Cor);
            this.Controls.Add(this.lbl_Fechar);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Communicalt!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_Logo.ResumeLayout(false);
            this.pnl_Logo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.Label lbl_Communicalt;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_Icon;
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.Button btn_Importar;
        private System.Windows.Forms.Button btn_NovaPranch;
        private System.Windows.Forms.Button btn_Pranchetas;
        private System.Windows.Forms.Button btn_Simbolo;
        private System.Windows.Forms.Button btn_Config;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ComboBox cmb_Tema;
        private System.Windows.Forms.Label lbl_Cor;
        private System.Windows.Forms.Label lblLogado;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btn_Deslogar;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblInstituicao;
        private System.Windows.Forms.TextBox txtInstituicao;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnEnviar;
    }
}

