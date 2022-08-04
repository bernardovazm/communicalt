using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CaltCfg;

namespace CommunicaltV1
{
    public partial class frmPranchetas : Form
    {
        Form _frm;
        int newform = 0;
        public frmPranchetas(Form frm, Point pos)
        {
            _frm = frm;
            InitializeComponent();
            Location = pos;

            
        }

        public void CarregarGrid()
        {
            grid_Pranchetas.AutoGenerateColumns = false;
            DataGridViewColumn nomeColuna = new DataGridViewTextBoxColumn();
            nomeColuna.Width = 200;
            nomeColuna.Name = "Nome";
            nomeColuna.HeaderText = "Nome";
            nomeColuna.Visible = true;
            grid_Pranchetas.Columns.Add(nomeColuna);
            grid_Pranchetas.Rows.Clear();

            DataGridViewColumn dirColuna = new DataGridViewTextBoxColumn();
            dirColuna.Width = 6000;
            dirColuna.Name = "Diretório";
            dirColuna.HeaderText = "Diretório";
            dirColuna.Visible = true;
            grid_Pranchetas.Columns.Add(dirColuna);
            grid_Pranchetas.Rows.Clear();


            Config Cfg = new Config();

            string[] dir = Cfg.LoadinfoPranch();

            if (dir != null)
            {
                for (int i = 0; i < dir.Length; i++)
                { //<-- Para carregar todas as imagens
                    string dirinf = dir[i];
                    if (dirinf != null)
                    {

                        string dirStr = dirinf;
                        string nome = Cfg.namePranch(dirinf);

                        
                        grid_Pranchetas.Rows.Add(nome,dirStr);
                    }
                }
            }

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

        private void frmPranchetas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (newform == 0)
            {
                frmLogin LoginForm = (frmLogin)_frm;
                LoginForm.Close();
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
            FormNew.Show();
            this.Close();
        }

        private void btn_Simbolo_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmSimbolo FormNew = new frmSimbolo(LoginForm, pos);
            FormNew.Show();
            this.Close();
        }

        private void btn_Pranchetas_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmPranchetas FormNew = new frmPranchetas(LoginForm, pos);
            FormNew.Show();
            this.Close();
        }

        private void btn_NovaPranch_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmNovaPrancheta FormNew = new frmNovaPrancheta(LoginForm, pos);
            FormNew.Show();
            this.Close();
        }

        private void btn_Importar_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmImportar FormNew = new frmImportar(LoginForm, pos);
            FormNew.Show();
            this.Close();
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPranchetas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Config Cfg = new Config();
            DataGridViewRow row = grid_Pranchetas.Rows[Cell];
            string dir = row.Cells[1].Value.ToString();
            Cfg.loadPranch(dir);

            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmNovaPrancheta FormNew = new frmNovaPrancheta(LoginForm, pos);
            FormNew.Show();
            this.Close();


        }

        int Cell { get; set; } // Variável para enviar e receber informações da célula selecionada
        private void grid_Pranchetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cell = e.RowIndex;
            }
            
        }

        private void btn_Emular_Click(object sender, EventArgs e)
        {
            Config Cfg = new Config();
            DataGridViewRow row = grid_Pranchetas.Rows[Cell];
            string dir = row.Cells[1].Value.ToString();
            Cfg.loadPranch(dir);
            string[] Falas = new string[6];

            string[] allLines = File.ReadAllLines(dir + "info.calt"); // Faz a leitura do Arquivo de Configuração
            if (allLines.Length >= 6)
            {
                for (int i = 0; i < 6; i++)
                {

                    Falas[i] = Cfg.Fala(allLines[i]);
                }
            }
            frmEmulador Emulador = new frmEmulador(Globals.Array, Falas);
            Emulador.Show();
        }

        private void grid_Pranchetas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Config Cfg = new Config();
            DataGridViewRow row = grid_Pranchetas.Rows[Cell];
            string dir = row.Cells[1].Value.ToString();
            Cfg.loadPranch(dir);

            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Point pos;
            pos = new Point(ActiveForm.Location.X, ActiveForm.Location.Y);
            frmNovaPrancheta FormNew = new frmNovaPrancheta(LoginForm, pos);
            FormNew.Show();
            this.Close();
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
