namespace CommunicaltV1
{
    partial class frmImportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnNova = new System.Windows.Forms.Button();
            this.btnPranchetas = new System.Windows.Forms.Button();
            this.btnSimbolo = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_ImpPranch = new System.Windows.Forms.Button();
            this.lbl_ImpPranch = new System.Windows.Forms.Label();
            this.lbl_ImpS = new System.Windows.Forms.Label();
            this.btn_ImpSimb = new System.Windows.Forms.Button();
            this.lbl_ImpSimb = new System.Windows.Forms.Label();
            this.lbl_ImpP = new System.Windows.Forms.Label();
            this.btn_SelectSymb = new System.Windows.Forms.Button();
            this.lbl_ArqSymb = new System.Windows.Forms.Label();
            this.btn_SelectPranch = new System.Windows.Forms.Button();
            this.lbl_ArqPranch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnImportar);
            this.panel1.Controls.Add(this.btnNova);
            this.panel1.Controls.Add(this.btnPranchetas);
            this.panel1.Controls.Add(this.btnSimbolo);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 548);
            this.panel1.TabIndex = 2;
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
            this.btnExportar.TabIndex = 37;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImportar.Location = new System.Drawing.Point(0, 295);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnImportar.Size = new System.Drawing.Size(194, 56);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // btnNova
            // 
            this.btnNova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btnNova.FlatAppearance.BorderSize = 0;
            this.btnNova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNova.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNova.Location = new System.Drawing.Point(0, 239);
            this.btnNova.Name = "btnNova";
            this.btnNova.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNova.Size = new System.Drawing.Size(194, 56);
            this.btnNova.TabIndex = 1;
            this.btnNova.Text = "Nova Prancheta";
            this.btnNova.UseVisualStyleBackColor = false;
            this.btnNova.Click += new System.EventHandler(this.btn_NovaPranch_Click);
            // 
            // btnPranchetas
            // 
            this.btnPranchetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btnPranchetas.FlatAppearance.BorderSize = 0;
            this.btnPranchetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPranchetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPranchetas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPranchetas.Location = new System.Drawing.Point(0, 183);
            this.btnPranchetas.Name = "btnPranchetas";
            this.btnPranchetas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPranchetas.Size = new System.Drawing.Size(194, 56);
            this.btnPranchetas.TabIndex = 1;
            this.btnPranchetas.Text = "Pranchetas";
            this.btnPranchetas.UseVisualStyleBackColor = false;
            this.btnPranchetas.Click += new System.EventHandler(this.btn_Pranchetas_Click);
            // 
            // btnSimbolo
            // 
            this.btnSimbolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btnSimbolo.FlatAppearance.BorderSize = 0;
            this.btnSimbolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimbolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimbolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSimbolo.Location = new System.Drawing.Point(0, 127);
            this.btnSimbolo.Name = "btnSimbolo";
            this.btnSimbolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSimbolo.Size = new System.Drawing.Size(194, 56);
            this.btnSimbolo.TabIndex = 1;
            this.btnSimbolo.Text = "Novo Símbolo";
            this.btnSimbolo.UseVisualStyleBackColor = false;
            this.btnSimbolo.Click += new System.EventHandler(this.btn_Simbolo_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfig.Location = new System.Drawing.Point(0, 71);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfig.Size = new System.Drawing.Size(194, 56);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 71);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Communicalt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "2";
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
            this.lbl_Fechar.TabIndex = 3;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(246)))));
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(194, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(858, 10);
            this.pnl_Top.TabIndex = 4;
            this.pnl_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseDown);
            this.pnl_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseMove);
            this.pnl_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseUp);
            // 
            // btn_ImpPranch
            // 
            this.btn_ImpPranch.BackColor = System.Drawing.Color.Transparent;
            this.btn_ImpPranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImpPranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImpPranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ImpPranch.Location = new System.Drawing.Point(248, 142);
            this.btn_ImpPranch.Name = "btn_ImpPranch";
            this.btn_ImpPranch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ImpPranch.Size = new System.Drawing.Size(91, 38);
            this.btn_ImpPranch.TabIndex = 27;
            this.btn_ImpPranch.Text = "Importar";
            this.btn_ImpPranch.UseVisualStyleBackColor = false;
            this.btn_ImpPranch.Click += new System.EventHandler(this.btn_ImpPranch_Click);
            // 
            // lbl_ImpPranch
            // 
            this.lbl_ImpPranch.AutoSize = true;
            this.lbl_ImpPranch.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ImpPranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImpPranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ImpPranch.Location = new System.Drawing.Point(244, 48);
            this.lbl_ImpPranch.Name = "lbl_ImpPranch";
            this.lbl_ImpPranch.Size = new System.Drawing.Size(238, 24);
            this.lbl_ImpPranch.TabIndex = 25;
            this.lbl_ImpPranch.Text = "Importar uma Prancheta:";
            // 
            // lbl_ImpS
            // 
            this.lbl_ImpS.AutoSize = true;
            this.lbl_ImpS.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ImpS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImpS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ImpS.Location = new System.Drawing.Point(244, 108);
            this.lbl_ImpS.Name = "lbl_ImpS";
            this.lbl_ImpS.Size = new System.Drawing.Size(301, 20);
            this.lbl_ImpS.TabIndex = 26;
            this.lbl_ImpS.Text = "Selecione o arquivo a ser importado:";
            // 
            // btn_ImpSimb
            // 
            this.btn_ImpSimb.BackColor = System.Drawing.Color.Transparent;
            this.btn_ImpSimb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImpSimb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImpSimb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ImpSimb.Location = new System.Drawing.Point(248, 333);
            this.btn_ImpSimb.Name = "btn_ImpSimb";
            this.btn_ImpSimb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ImpSimb.Size = new System.Drawing.Size(91, 38);
            this.btn_ImpSimb.TabIndex = 32;
            this.btn_ImpSimb.Text = "Importar";
            this.btn_ImpSimb.UseVisualStyleBackColor = false;
            this.btn_ImpSimb.Click += new System.EventHandler(this.btn_ImpSimb_Click);
            // 
            // lbl_ImpSimb
            // 
            this.lbl_ImpSimb.AutoSize = true;
            this.lbl_ImpSimb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ImpSimb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImpSimb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ImpSimb.Location = new System.Drawing.Point(244, 239);
            this.lbl_ImpSimb.Name = "lbl_ImpSimb";
            this.lbl_ImpSimb.Size = new System.Drawing.Size(209, 24);
            this.lbl_ImpSimb.TabIndex = 30;
            this.lbl_ImpSimb.Text = "Importar um Símbolo:";
            // 
            // lbl_ImpP
            // 
            this.lbl_ImpP.AutoSize = true;
            this.lbl_ImpP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ImpP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImpP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ImpP.Location = new System.Drawing.Point(244, 299);
            this.lbl_ImpP.Name = "lbl_ImpP";
            this.lbl_ImpP.Size = new System.Drawing.Size(301, 20);
            this.lbl_ImpP.TabIndex = 31;
            this.lbl_ImpP.Text = "Selecione o arquivo a ser importado:";
            // 
            // btn_SelectSymb
            // 
            this.btn_SelectSymb.BackColor = System.Drawing.Color.Transparent;
            this.btn_SelectSymb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectSymb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectSymb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SelectSymb.Location = new System.Drawing.Point(554, 321);
            this.btn_SelectSymb.Name = "btn_SelectSymb";
            this.btn_SelectSymb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_SelectSymb.Size = new System.Drawing.Size(81, 27);
            this.btn_SelectSymb.TabIndex = 34;
            this.btn_SelectSymb.Text = "Selecionar";
            this.btn_SelectSymb.UseVisualStyleBackColor = false;
            this.btn_SelectSymb.Click += new System.EventHandler(this.btn_SelectSymb_Click);
            // 
            // lbl_ArqSymb
            // 
            this.lbl_ArqSymb.AutoSize = true;
            this.lbl_ArqSymb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ArqSymb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArqSymb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ArqSymb.Location = new System.Drawing.Point(551, 302);
            this.lbl_ArqSymb.Name = "lbl_ArqSymb";
            this.lbl_ArqSymb.Size = new System.Drawing.Size(184, 16);
            this.lbl_ArqSymb.TabIndex = 33;
            this.lbl_ArqSymb.Text = "Nenhum arquivo selecionado";
            // 
            // btn_SelectPranch
            // 
            this.btn_SelectPranch.BackColor = System.Drawing.Color.Transparent;
            this.btn_SelectPranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectPranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectPranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SelectPranch.Location = new System.Drawing.Point(554, 131);
            this.btn_SelectPranch.Name = "btn_SelectPranch";
            this.btn_SelectPranch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_SelectPranch.Size = new System.Drawing.Size(81, 27);
            this.btn_SelectPranch.TabIndex = 36;
            this.btn_SelectPranch.Text = "Selecionar";
            this.btn_SelectPranch.UseVisualStyleBackColor = false;
            this.btn_SelectPranch.Click += new System.EventHandler(this.btn_SelectPranch_Click);
            // 
            // lbl_ArqPranch
            // 
            this.lbl_ArqPranch.AutoSize = true;
            this.lbl_ArqPranch.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ArqPranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArqPranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ArqPranch.Location = new System.Drawing.Point(551, 112);
            this.lbl_ArqPranch.Name = "lbl_ArqPranch";
            this.lbl_ArqPranch.Size = new System.Drawing.Size(184, 16);
            this.lbl_ArqPranch.TabIndex = 35;
            this.lbl_ArqPranch.Text = "Nenhum arquivo selecionado";
            // 
            // frmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 548);
            this.Controls.Add(this.btn_SelectPranch);
            this.Controls.Add(this.lbl_ArqPranch);
            this.Controls.Add(this.btn_SelectSymb);
            this.Controls.Add(this.lbl_ArqSymb);
            this.Controls.Add(this.btn_ImpSimb);
            this.Controls.Add(this.lbl_ImpSimb);
            this.Controls.Add(this.lbl_ImpP);
            this.Controls.Add(this.btn_ImpPranch);
            this.Controls.Add(this.lbl_ImpPranch);
            this.Controls.Add(this.lbl_ImpS);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Communicalt!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmImportar_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnPranchetas;
        private System.Windows.Forms.Button btnSimbolo;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button btn_ImpPranch;
        private System.Windows.Forms.Label lbl_ImpPranch;
        private System.Windows.Forms.Label lbl_ImpS;
        private System.Windows.Forms.Button btn_ImpSimb;
        private System.Windows.Forms.Label lbl_ImpSimb;
        private System.Windows.Forms.Label lbl_ImpP;
        private System.Windows.Forms.Button btn_SelectSymb;
        private System.Windows.Forms.Label lbl_ArqSymb;
        private System.Windows.Forms.Button btn_SelectPranch;
        private System.Windows.Forms.Label lbl_ArqPranch;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnNova;
    }
}