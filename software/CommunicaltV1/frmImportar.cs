using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaltCfg;

namespace CommunicaltV1
{
    public partial class frmImportar : Form
    {
        Form _frm;
        int newform = 0;
        public frmImportar(Form frm, Point pos)
        {
            _frm = frm;
            InitializeComponent();
            Location = pos;
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

        private void frmImportar_FormClosed(object sender, FormClosedEventArgs e)
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

        string Simb { get; set; } // Variável para enviar e receber informações do Arquivo selecionada

        private void btn_SelectSymb_Click(object sender, EventArgs e)
        {
            Config Cfg = new Config();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "caltcfg";
            openFileDialog1.Filter = "CommunicAlt config files(*.caltcfg)|*.caltcfg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                lbl_ArqSymb.Text = openFileDialog1.FileName;
                Simb = openFileDialog1.FileName;
                
            }
        }

        private void btn_ImpSimb_Click(object sender, EventArgs e)
        {
            if (Simb != "" && Simb != null)
            {
                Config Cfg = new Config();
                Cfg.addSymb(Simb);
            } else
            {
                MessageBox.Show("Nenhum Arquivo Selecionado");
            }
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

        private void btn_ImpPranch_Click(object sender, EventArgs e)
        {
            if (Pranch != "" && Pranch != null)
            {
                Config Cfg = new Config();
                Cfg.ImportarPrancheta(Pranch);
            }
            else
            {
                MessageBox.Show("Nenhum Arquivo Selecionado");
            }
        }


        string Pranch { get; set; } // Variável para enviar e receber informações do Arquivo selecionada
        private void btn_SelectPranch_Click(object sender, EventArgs e)
        {
            Config Cfg = new Config();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "caltpcfg";
            openFileDialog1.Filter = "CommunicAlt config files(*.caltpcfg)|*.caltpcfg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                lbl_ArqPranch.Text = openFileDialog1.FileName;
                Pranch = openFileDialog1.FileName;

            }
        }
    }



}
