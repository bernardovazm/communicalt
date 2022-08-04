using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class Globals // Variáveis Globais
{
    public static String Save_Directory = @"C:\CommunicAlt"; // Modificável
    public static readonly String CODE_PREFIX = "US-"; // Não Modificável
}

namespace CaltCfg
{
    class Symbols
    {
        public string[] Loadinfo() // Carrega informações do arquivo .caltinfo
        {
            if (File.Exists(Globals.Save_Directory + @"\Symbols\symb.caltinfo")) // Testa se o Arquivo existe
            {
                string[] Info = File.ReadAllLines(Globals.Save_Directory + @"\Symbols\symb.caltinfo"); // Leitura do Arquivo


                // Carregar o Arquivo para um Array

                string[] dir = new string[Info.Length]; // Define o tamanho do Array de acordo com o numero de linhas do Arquivo
                int i = 0;
                var stream = File.OpenRead(Globals.Save_Directory + @"\Symbols\symb.caltinfo"); // Captura informações de cada linha do arquivo
                string line;
                using (var reader = new StreamReader(stream)) // Grava as informações do Arquivo para o Array
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        dir[i] = line;
                        i++;
                    }
                }

                return dir; // Retorna o Array
            }
            else // Caso o arquivo não exista
            {
                string[] dir = null; // Insere informações nulas no Array
                return dir; // Retorna o Array Nulo
            }
        }

        public Image readImg(string dir)  // Adicionar imagem de Símbolo
        {
            if (File.Exists(dir + "init.calt")) // Testa se o Arquivo de Configuração existe
            {
                string[] allLines = File.ReadAllLines(dir + "init.calt"); // Faz a leitura do Arquivo de Configuração
                string imagem = string.Empty; // Cria uma string vazia para receber o diretório da imagem
                if (allLines.Length >= 5)
                {
                    if (allLines[4] != null)
                    {
                        imagem = allLines[4]; // Pega o diretório da imagem na linha correspondente do Arquivo de Configuração
                    }
                }
                if (File.Exists(dir + "" + imagem)) // Testa se a imagem existe
                {
                    Image img; // Cria a variável de imagem
                    using (var bmpTemp = new Bitmap(dir + "" + imagem)) // Especifica o diretório do Bitmap
                    {
                        img = new Bitmap(bmpTemp, new Size(150, 150)); // Cria a imagem e define o tamanho
                    }
                    return img; // Retorna a imagem
                }
                else // Caso a imagem não exista
                {
                    Image img = null;
                    return img; // Retorna uma imagem nula
                }

            }
            else // Caso o Arquivo de Configuração não exista
            {
                Image img = null;
                return img; // Retorna uma imagem nula
            } 

            
        }

        public void SalvarPrancheta(string[] info , string nome)
        {
            string Diretorio = Globals.Save_Directory + @"\Pranchetas\" + nome;
            if (!Directory.Exists(Diretorio))
            {
                Directory.CreateDirectory(Diretorio);
            }
            string infofile = Diretorio + @"\info.calt";
            if (File.Exists(infofile))
            {
                string[] allLines = File.ReadAllLines(infofile);
                string[] l = new string[6];
                if (allLines.Length >= 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (info[i] == string.Empty)
                        {
                            l[i] = allLines[i];
                        }
                        else
                        {
                            l[i] = info[i];
                        }
                    }
                }

                File.Delete(infofile);

                for (int i = 0; i < 6; i++)
                {
                    if (info[i] == string.Empty || info[i] == "")
                    {
                        File.AppendAllText(infofile, "Nan");
                        File.AppendAllText(infofile, Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(infofile, l[i]);
                        File.AppendAllText(infofile, Environment.NewLine);
                    }
                }
                


            }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    if (info[i] == string.Empty || info[i] == "")
                    {
                        File.AppendAllText(infofile, "Nan");
                        File.AppendAllText(infofile, Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(infofile, info[i]);
                        File.AppendAllText(infofile, Environment.NewLine);
                    }
                }
            }

 

        }

        public void addSymb(string Arquivo)
        {
           
            //string[] Arquivo = (string[])e.Data.GetData(DataFormats.FileDrop, false); Ignorar
                if (Path.GetExtension(Arquivo) == ".caltcfg")
            {


                    
                    string[] allLines = File.ReadAllLines(Arquivo);
                    string line = string.Empty;
                    string arq = string.Empty;
                    string rmv = string.Empty;
                    if (allLines.Length >= 3)
                    {
                        line = allLines[0];
                        arq = allLines[1];
                        rmv = allLines[2];
                    }
                    var rmove = Arquivo;
                    string file = rmove.Replace(rmv, arq);
                    string Diretorio = Globals.Save_Directory + @"\Symbols\" + line;
                    if (Directory.Exists(Diretorio))
                    {
                        System.IO.DirectoryInfo di = new DirectoryInfo(Diretorio);
                        di.Delete(true);
                    }else if (!Directory.Exists(Diretorio))
                    {
                        Directory.CreateDirectory(Diretorio);
                    }


                try
                {
                    ZipFile.ExtractToDirectory(file, Diretorio);
                }
                catch
                {
                    throw;
                }

                string infofile = Globals.Save_Directory + @"\Symbols\symb.caltinfo";

                if (File.Exists(infofile))
                {
                    
                    string[] testinfo = File.ReadAllLines(infofile);
                    string info = string.Empty;
                    int ok = 0;
                    for (int f = 0; f < testinfo.Length; f++)
                    {
                        info = testinfo[f];
                        if (info != Diretorio + @"\")
                        {
                            ok++;
                        }
                    }
                    if (ok == testinfo.Length)
                    {
                        File.AppendAllText(infofile, Environment.NewLine);
                        File.AppendAllText(infofile, Diretorio + @"\");
                    }


                }
                else
                {
                    File.AppendAllText(infofile, Diretorio + @"\");
                }


                

            }
            else
            {
                MessageBox.Show("Formato de arquivo inválido");
            }

            
        }

        // Old
        /*public void init()
        {
            string[] Info = File.ReadAllLines(Globals.Save_Directory + @"\Symbols\symb.caltinfo");

            var stream = File.OpenRead(Globals.Save_Directory + @"\Symbols\symb.caltinfo");
            string line;
            using (var reader = new StreamReader(stream))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] allLines = File.ReadAllLines(line + "init.calt");

                    string line2 = string.Empty;
                    string imagem = string.Empty;
                    if (allLines.Length >= 5)
                    {
                        line2 = allLines[3];
                        imagem = allLines[4];
                    }

                    Image img = Image.FromFile(line + "" + imagem);

                }
            }
        }*/







    }

}

