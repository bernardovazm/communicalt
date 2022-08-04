using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CaltCfg;

namespace CommunicaltV1
{
    public partial class frmNovaPrancheta : Form
    {
        Form _frm;
        int newform = 0;
        public frmNovaPrancheta(Form frm, Point pos)
        {
            _frm = frm;
            InitializeComponent();
            Location = pos;
            InitCalt();
            Globals.Salv = 0;
        }
        Config Cfg = new Config();


        public void InitCalt()
        {
            DataGridViewImageColumn simbColuna = new DataGridViewImageColumn();
            simbColuna.Width = 170;
            simbColuna.Name = "Simbolos";
            grid_Simb.Columns.Insert(0, simbColuna);
            grid_Simb.Rows.Clear();
            refreshAll();

        }

        private void lbl_Nome_Click(object sender, EventArgs e)
        {
            this.txt_NomePrancheta.ReadOnly = false;
            this.txt_NomePrancheta.Visible = true;
            this.lbl_Nome.Visible = false;
        }

        private void txt_NomePrancheta_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)

            {
                this.txt_NomePrancheta.ReadOnly = true;
                this.txt_NomePrancheta.Visible = false;
                this.lbl_Nome.Text = this.txt_NomePrancheta.Text;
                this.lbl_Nome.Visible = true;

            }
        }

        private void txt_NomePrancheta_Leave(object sender, EventArgs e)
        {
            this.txt_NomePrancheta.ReadOnly = true;
            this.txt_NomePrancheta.Visible = false;
            this.lbl_Nome.Text = this.txt_NomePrancheta.Text;
            this.lbl_Nome.Visible = true;
        }

        // Drag and Drop do Top Panel
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void pnl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void pnl_Top_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pnl_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
                Form N = Globals.NaN;
                N.Location = Location;
            }
        }

        private void frmNovaPrancheta_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                if (newform == 0)
                {
                    frmLogin LoginForm = (frmLogin)_frm;
                    LoginForm.Close();
                }
        }

        public void Fechar(Form New)
        {
            if (saved == 0)
            {
                DialogResult result = MessageBox.Show("Deseja sair do editor? (Todo o progresso não salvo será perdido)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (newform == 1)
                    {
                        New.Show();
                    }
                    this.Close();
                }
                else
                {
                    if (newform == 1)
                    {
                        New.Close();
                    }
                }
            } else
            {
                if (newform == 1)
                {
                    New.Show();
                }
                this.Close();
            }

            
        }

        // Botões do Menu
        private void btn_Config_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmConfig FormNew = new frmConfig(LoginForm, pos);
            Fechar(FormNew);
        }

        private void btn_Simbolo_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmSimbolo FormNew = new frmSimbolo(LoginForm, pos);
            Fechar(FormNew);
        }

        private void btn_Pranchetas_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmPranchetas FormNew = new frmPranchetas(LoginForm, pos);
            Fechar(FormNew);
        }

        private void btn_NovaPranch_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmNovaPrancheta FormNew = new frmNovaPrancheta(LoginForm, pos);
            Fechar(FormNew);
        }

        private void btn_Importar_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmImportar FormNew = new frmImportar(LoginForm, pos);
            Fechar(FormNew);
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            Fechar(null);
        }


        //Interações com os Símbolos

        private void grid_Simb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridCellClick(e);
        }

        int Cell { get; set; } // Variável para enviar e receber informações da célula selecionada

        public void GridCellClick(DataGridViewCellEventArgs CellInfo)  // Chamada para adição de símbolos na prancheta
        {
            if (CellInfo.RowIndex >= 0) {
                Cell = CellInfo.RowIndex;
                saved = 0;
                TransferSymb();
                pnl_Add.Visible = true;  // Ativa a visibilidade da group box com os símbolos de adição
            }

            // Chamada: GridCellClick(e);    e: Variável padrão de informações de celulas de um evento de grid

        }

        string[] Falas = new string[6];

        public void getinfo(int num) // Coletor de informações do símbolo adicionado
        {
            string info = null;
            string[] dir = Cfg.LoadinfoSimb();
            info = dir[Cell];
            criarArray(info, num);
            Falas[num] = Cfg.Fala(info);
            pnl_Add.Visible = false; // Desativa a visibilidade da group box com símbolos de adição

        }

        private void criarArray(string info, int num)
        {
            array[num] = info;
            carregarSimbolos();
        }

        private void salvarPrancheta(string[] info)
        {
            string nome = lbl_Nome.Text;
            saved = 1;
            Cfg.SalvarPrancheta(info, nome);


        }
        public void TransferSymb()
        {
            pic_Add1.BackgroundImage = pic_Simb1.Image;
            pic_Add2.BackgroundImage = pic_Simb2.Image;
            pic_Add3.BackgroundImage = pic_Simb3.Image;
            pic_Add4.BackgroundImage = pic_Simb4.Image;
            pic_Add5.BackgroundImage = pic_Simb5.Image;
            pic_Add6.BackgroundImage = pic_Simb6.Image;
        }

        public void refreshAll()
        {
            CarregarGrid();
            carregarSimbolos();
        }

        // Carregamento

        string[] array = Globals.Array;
        private void carregarSimbolos()
        {
            if (array != null)
            {
                if (array[0] != string.Empty || array[0] != null) { pic_Simb1.Image = Cfg.readImg(array[0]); Falas[0] = Cfg.Fala(array[0]); }
                if (array[1] != string.Empty || array[1] != null) { pic_Simb2.Image = Cfg.readImg(array[1]); Falas[1] = Cfg.Fala(array[1]); }
                if (array[2] != string.Empty || array[2] != null) { pic_Simb3.Image = Cfg.readImg(array[2]); Falas[2] = Cfg.Fala(array[2]); }
                if (array[3] != string.Empty || array[3] != null) { pic_Simb4.Image = Cfg.readImg(array[3]); Falas[3] = Cfg.Fala(array[3]); }
                if (array[4] != string.Empty || array[4] != null) { pic_Simb5.Image = Cfg.readImg(array[4]); Falas[4] = Cfg.Fala(array[4]); }
                if (array[5] != string.Empty || array[5] != null) { pic_Simb6.Image = Cfg.readImg(array[5]); Falas[5] = Cfg.Fala(array[5]); }
                if (Globals.nomePranch != string.Empty && Globals.nomePranch != null && Globals.nomePranch != "" )
                {
                    lbl_Nome.Text = Globals.nomePranch;
                    Globals.nomePranch = string.Empty;
                }
                Globals.Array = new string[6];
            }
        }

        private void CarregarGrid()
        {
            string[] dir = Cfg.LoadinfoSimb();

            if (dir != null)
            {
                for (int i = 0; i < dir.Length; i++)
                { //<-- Para carregar todas as imagens
                    string dirinf = dir[i];
                    if (dirinf != null)
                    {

                        Image img = Cfg.readImg(dirinf);


                        grid_Simb.Rows.Insert(i, img);
                    }
                }
            }
        }
        int saved = 0;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (saved == 0)
            {

            }
        }

        private void pic_Add1_Click(object sender, EventArgs e)
        {
            getinfo(0);
        }

        private void pic_Add2_Click(object sender, EventArgs e)
        {
            getinfo(1);
        }

        private void pic_Add3_Click(object sender, EventArgs e)
        {
            getinfo(2);
        }

        private void pic_Add4_Click(object sender, EventArgs e)
        {
            getinfo(3);
        }

        private void pic_Add5_Click(object sender, EventArgs e)
        {
            getinfo(4);
        }

        private void pic_Add6_Click(object sender, EventArgs e)
        {
            getinfo(5);
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            salvarPrancheta(array);
        }

        private void pnl_Add_Click(object sender, EventArgs e)
        {
            pnl_Add.Hide();
        }

        private void frmNovaPrancheta_Click(object sender, EventArgs e)
        {
            pnl_Add.Hide();
        }


        private void pnl_Calt_Click(object sender, EventArgs e)
        {
            pnl_Add.Hide();
        }

        private void btn_Emular_Click(object sender, EventArgs e)
        {
            frmEmulador Emulador = new frmEmulador(array, Falas);
            Emulador.Show();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmExportar FormNew = new frmExportar(LoginForm, pos);
            FormNew.Show();
            this.Close();
        }
    }
}
