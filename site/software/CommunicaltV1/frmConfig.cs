using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDeInteracoes;


namespace CommunicaltV1 
{
    public partial class frmConfig : Form
    {
        Form _frm;
        int newform = 0;
        public frmConfig(Form frm, Point pos)
        {
            InitializeComponent();
            _frm = frm;
            Location = pos;
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (newform == 0)
            {
                frmLogin LoginForm = (frmLogin)_frm;
                LoginForm.Close();
            }
        }


        private void pnl_Logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lbl_Fechar_MouseClick(object sender, MouseEventArgs e)
        {

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

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Deslogar_Click(object sender, EventArgs e)
        {
            newform = 1;
            frmLogin LoginForm = (frmLogin)_frm;
            Form N = Globals.NaN;
            
            LoginForm.Show();
            N.Close();
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtMessage.Text != "" && txtInstituicao.Text != "")
            {
                BLL_Feedback fed = new BLL_Feedback();
                fed.EnviarFeedback(txtNome.Text, txtInstituicao.Text, txtMessage.Text);
                txtNome.Clear();
                txtMessage.Clear();
                txtInstituicao.Clear();

                MessageBox.Show("Mensagem enviada! Agradecemos Pelo Feedback!");
            } else
            {
                MessageBox.Show("Campo(s) Vazio(s)!");
            }
        }
    }
}
