namespace CommunicaltV1
{
    partial class frmExportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportar));
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
            this.btn_ExpP = new System.Windows.Forms.Button();
            this.btn_ExpS = new System.Windows.Forms.Button();
            this.grid_Pranchetas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.grid_Simb = new System.Windows.Forms.DataGridView();
            this.lbl_Symb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pranchetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Simb)).BeginInit();
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
            this.btnExportar.TabIndex = 7;
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
            // btn_ExpP
            // 
            this.btn_ExpP.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExpP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExpP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExpP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ExpP.Location = new System.Drawing.Point(223, 468);
            this.btn_ExpP.Name = "btn_ExpP";
            this.btn_ExpP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ExpP.Size = new System.Drawing.Size(173, 45);
            this.btn_ExpP.TabIndex = 1;
            this.btn_ExpP.Text = "Exportar Prancheta";
            this.btn_ExpP.UseVisualStyleBackColor = false;
            this.btn_ExpP.Click += new System.EventHandler(this.btn_ExpP_Click);
            // 
            // btn_ExpS
            // 
            this.btn_ExpS.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExpS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExpS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExpS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ExpS.Location = new System.Drawing.Point(722, 468);
            this.btn_ExpS.Name = "btn_ExpS";
            this.btn_ExpS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ExpS.Size = new System.Drawing.Size(150, 45);
            this.btn_ExpS.TabIndex = 1;
            this.btn_ExpS.Text = "Exportar Símbolo";
            this.btn_ExpS.UseVisualStyleBackColor = false;
            this.btn_ExpS.Click += new System.EventHandler(this.btn_ExpS_Click);
            // 
            // grid_Pranchetas
            // 
            this.grid_Pranchetas.AllowUserToAddRows = false;
            this.grid_Pranchetas.AllowUserToDeleteRows = false;
            this.grid_Pranchetas.AllowUserToResizeRows = false;
            this.grid_Pranchetas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_Pranchetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Pranchetas.Location = new System.Drawing.Point(223, 89);
            this.grid_Pranchetas.MultiSelect = false;
            this.grid_Pranchetas.Name = "grid_Pranchetas";
            this.grid_Pranchetas.ReadOnly = true;
            this.grid_Pranchetas.RowHeadersVisible = false;
            this.grid_Pranchetas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_Pranchetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Pranchetas.ShowEditingIcon = false;
            this.grid_Pranchetas.Size = new System.Drawing.Size(461, 373);
            this.grid_Pranchetas.TabIndex = 7;
            this.grid_Pranchetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Pranchetas_CellClick);
            this.grid_Pranchetas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Pranchetas_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(219, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Minhas pranchetas";
            // 
            // grid_Simb
            // 
            this.grid_Simb.AllowUserToAddRows = false;
            this.grid_Simb.AllowUserToDeleteRows = false;
            this.grid_Simb.AllowUserToResizeColumns = false;
            this.grid_Simb.AllowUserToResizeRows = false;
            this.grid_Simb.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_Simb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Simb.Location = new System.Drawing.Point(722, 89);
            this.grid_Simb.Margin = new System.Windows.Forms.Padding(0);
            this.grid_Simb.MultiSelect = false;
            this.grid_Simb.Name = "grid_Simb";
            this.grid_Simb.RowHeadersVisible = false;
            this.grid_Simb.RowHeadersWidth = 5;
            this.grid_Simb.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_Simb.RowTemplate.Height = 170;
            this.grid_Simb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_Simb.ShowCellErrors = false;
            this.grid_Simb.ShowEditingIcon = false;
            this.grid_Simb.Size = new System.Drawing.Size(230, 373);
            this.grid_Simb.TabIndex = 8;
            this.grid_Simb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Simb_CellClick);
            // 
            // lbl_Symb
            // 
            this.lbl_Symb.AutoSize = true;
            this.lbl_Symb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Symb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Symb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Symb.Location = new System.Drawing.Point(722, 62);
            this.lbl_Symb.Name = "lbl_Symb";
            this.lbl_Symb.Size = new System.Drawing.Size(150, 24);
            this.lbl_Symb.TabIndex = 9;
            this.lbl_Symb.Text = "Meus símbolos";
            // 
            // frmExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 548);
            this.Controls.Add(this.lbl_Symb);
            this.Controls.Add(this.grid_Simb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grid_Pranchetas);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Fechar);
            this.Controls.Add(this.btn_ExpS);
            this.Controls.Add(this.btn_ExpP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Communicalt!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPranchetas_FormClosed);
            this.Load += new System.EventHandler(this.frmPranchetas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pranchetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Simb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnPranchetas;
        private System.Windows.Forms.Button btnSimbolo;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button btn_ExpP;
        private System.Windows.Forms.Button btn_ExpS;
        private System.Windows.Forms.DataGridView grid_Pranchetas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView grid_Simb;
        private System.Windows.Forms.Label lbl_Symb;
    }
}