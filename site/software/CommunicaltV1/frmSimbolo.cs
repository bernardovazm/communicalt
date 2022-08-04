using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.IO;
using System.Speech.Synthesis;
using CaltCfg;

namespace CommunicaltV1
{
    public partial class frmSimbolo : Form
    {
        Form _frm;
        int newform = 0;
        public frmSimbolo(Form frm, Point pos)
        {
            _frm = frm;
            InitializeComponent();
            Location = pos;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmSimbolo_Load(object sender, EventArgs e)
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

        private void frmSimbolo_FormClosed(object sender, FormClosedEventArgs e)
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
        
        string img = string.Empty;
        private void pic_Simbolo_Click(object sender, EventArgs e)
        {

            Config symb = new Config();
            OpenFileDialog ImageDialog = new OpenFileDialog();
            ImageDialog.Multiselect = false;
            ImageDialog.Filter = "Image Files(*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";

            if (ImageDialog.ShowDialog() == DialogResult.OK)
            {
                img = ImageDialog.FileName;
                pic_Simbolo.Image= new Bitmap(ImageDialog.FileName);


              }
        }



        private void chk_Audio_CheckStateChanged(object sender, EventArgs e)
        {
            /*if (chk_Audio.Checked == true)
            {
                txt_Fala.Enabled = false;
                pnl_Audio.Enabled = true;
                btn_Select.Visible = true;
            } else
            {
                txt_Fala.Enabled = true;
                pnl_Audio.Enabled = false;
                btn_Select.Visible = false;
            }*/
            MessageBox.Show("Função desabilitada temporariamente");
        }


        string wav = string.Empty;
        private void btn_Select_Click(object sender, EventArgs e)
        {
            Config symb = new Config();
            OpenFileDialog AudioDialog = new OpenFileDialog();
            AudioDialog.Multiselect = false;
            AudioDialog.DefaultExt = "wav";
            AudioDialog.Filter = "Arquivo de áudio do Windows(*.wav)|*.wav";

            if (AudioDialog.ShowDialog() == DialogResult.OK)
            {
                wav = AudioDialog.FileName;
                lbl_Audio.Text = AudioDialog.FileName;


            }
        }

        private void btn_Criar_Click(object sender, EventArgs e)
        {
            string nome = txt_Nome.Text;
            string fala = "%wav%";
            /*if (chk_Audio.Checked != true)
            {
               fala = txt_Fala.Text;
            } Remover a linha abaixo */
            fala = txt_Fala.Text;

            string target = Globals.Save_Directory + @"\Symbols\" + nome;
            string infofile = target + @"\init.calt";
            string ext = Path.GetExtension(img);
            if (Directory.Exists(target))
            {
                DirectoryInfo di = new DirectoryInfo(target);
                di.Delete(true);
            }
            Directory.CreateDirectory(target);

            File.Copy(img, target + @"\" + nome + ext, true);
            File.AppendAllText(infofile, "Criado por: " + Globals.Usuario);
            File.AppendAllText(infofile, Environment.NewLine);
            File.AppendAllText(infofile, nome);
            File.AppendAllText(infofile, Environment.NewLine);
            File.AppendAllText(infofile, "Fala:");
            File.AppendAllText(infofile, Environment.NewLine);
            File.AppendAllText(infofile, fala);
            File.AppendAllText(infofile, Environment.NewLine);
            File.AppendAllText(infofile, nome + ext);
            File.AppendAllText(infofile, Environment.NewLine);
            if (chk_Audio.Checked == true)
            {
                File.Copy(wav, target + @"\" + nome + ".wav", true);
                File.AppendAllText(infofile, nome + ".wav");
            }

            string caltiinfofile = Globals.Save_Directory + @"\Symbols\symb.caltinfo";

            if (File.Exists(caltiinfofile))
            {

                string[] testinfo = File.ReadAllLines(caltiinfofile);
                string infocalt = string.Empty;
                int ok = 0;
                for (int f = 0; f < testinfo.Length; f++)
                {
                    infocalt = testinfo[f];
                    if (infocalt != target + @"\")
                    {
                        ok++;
                    }
                }
                if (ok == testinfo.Length)
                {
                    File.AppendAllText(caltiinfofile, Environment.NewLine);
                    File.AppendAllText(caltiinfofile, target + @"\");
                }


            }
            else
            {
                File.AppendAllText(caltiinfofile, target + @"\");
            }

            MessageBox.Show("Simbolo '" + nome + "' criado com sucesso!");
        }

        private void btn_Ouvir_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Speaker = new SpeechSynthesizer();
            Speaker.GetInstalledVoices();
            Speaker.SelectVoice("Microsoft Server Speech Text to Speech Voice (pt-BR, Heloisa)");
            Speaker.Speak(txt_Fala.Text);
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
