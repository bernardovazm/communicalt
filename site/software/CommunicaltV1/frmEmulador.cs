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
using System.Media;
using System.Speech.Synthesis;
using CaltCfg;


namespace CommunicaltV1
{
    public partial class frmEmulador : Form
    {

        string[] fals;
        public frmEmulador(string[] imagens, string[] falas)
        {
            Config Cfg = new Config();
            InitializeComponent();
            pic_Simb1.Image = Cfg.readImg(imagens[0]);
            pic_Simb2.Image = Cfg.readImg(imagens[1]);
            pic_Simb3.Image = Cfg.readImg(imagens[2]);
            pic_Simb4.Image = Cfg.readImg(imagens[3]);
            pic_Simb5.Image = Cfg.readImg(imagens[4]);
            pic_Simb6.Image = Cfg.readImg(imagens[5]);
            fals = falas;

            Falar();
        }


        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected SpeechSynthesizer Speaker { get; set; }
        public void Falar()
        {
            Speaker = new SpeechSynthesizer();
            Speaker.GetInstalledVoices();
            Speaker.SelectVoice("Microsoft Server Speech Text to Speech Voice (pt-BR, Heloisa)");
        }


        private void pic_Simb1_Click(object sender, EventArgs e)
        {
            if (fals[0] != null){
                string Directory = Globals.Save_Directory + @"\Symbols\" + fals[0];
                if (File.Exists(Directory))
                {
                    SoundPlayer Som = new SoundPlayer(Directory);
                    Som.Play();

                } else { 
                    Speaker.Speak(fals[0]);
                }
            }
        }

        private void pic_Simb2_Click(object sender, EventArgs e)
        {
            if (fals[1] != null)
            {
                Speaker.Speak(fals[1]);
            }
        }

        private void pic_Simb3_Click(object sender, EventArgs e)
        {
            if (fals[2] != null)
            {
                Speaker.Speak(fals[2]);
            }
        }

        private void pic_Simb4_Click(object sender, EventArgs e)
        {
            if (fals[3] != null)
            {
                Speaker.Speak(fals[3]);
            }
        }

        private void pic_Simb5_Click(object sender, EventArgs e)
        {
            if (fals[4] != null)
            {
                Speaker.Speak(fals[4]);
            }
        }

        private void pic_Simb6_Click(object sender, EventArgs e)
        {
            if (fals[5] != null)
            {
                Speaker.Speak(fals[5]);
            }
        }


    }
}
