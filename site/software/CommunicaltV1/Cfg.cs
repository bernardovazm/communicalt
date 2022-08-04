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
using System.Security.AccessControl;
using System.Security.Principal;
using System.Diagnostics;

public static class Globals // Variáveis Globais
{
    public static String Save_Directory = @"C:\CommunicAlt"; // Modificável
    public static Point locNaN = new Point(0, 0);
    public static Form NaN;
    public static int New = 1;
    public static int Salv = 0;
    public static int PranchImp = 0;
    public static string[] Array = new string[6];
    public static string nomePranch = string.Empty;
    public static string Usuario = "BetaTester";
}

namespace CaltCfg
{
    class Config
    {
        public string[] LoadinfoSimb() // Carrega informações do arquivo .caltinfo
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


        public string[] LoadinfoPranch() // Carrega informações do arquivo .caltinfo
        {
            if (File.Exists(Globals.Save_Directory + @"\Pranchetas\pranch.caltinfo")) // Testa se o Arquivo existe
            {
                string[] Info = File.ReadAllLines(Globals.Save_Directory + @"\Pranchetas\pranch.caltinfo"); // Leitura do Arquivo


                // Carregar o Arquivo para um Array

                string[] dir = new string[Info.Length]; // Define o tamanho do Array de acordo com o numero de linhas do Arquivo
                int i = 0;
                var stream = File.OpenRead(Globals.Save_Directory + @"\Pranchetas\pranch.caltinfo"); // Captura informações de cada linha do arquivo
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

        public string namePranch(string dir)
        {
            if (File.Exists(dir + "info.calt")) // Testa se o Arquivo de Configuração existe
            {
                string[] allLines = File.ReadAllLines(dir + "info.calt"); // Faz a leitura do Arquivo de Configuração
                string text = string.Empty; // Cria uma string vazia para receber o nome
                if (allLines.Length >= 7)
                {
                    if (allLines[6] != null)
                    {
                        text = allLines[6]; // Pega o nome na linha correspondente do Arquivo de Configuração
                    }
                }
                return text;


            }
            else // Caso o Arquivo de Configuração não exista
            {
                string text = string.Empty;
                return text; // Retorna um nome nulo
            }

        }

        public void loadPranch(string dir)
        {
            if (File.Exists(dir + "info.calt")) // Testa se o Arquivo de Configuração existe
            {
                string[] allLines = File.ReadAllLines(dir + "info.calt"); // Faz a leitura do Arquivo de Configuração
                string[] l = new string[6];
                if (allLines.Length >= 6)
                {
                    for (int i = 0; i < 6; i++)
                    {

                            l[i] = allLines[i];
                    }
                }
                Globals.Array = l;
                Globals.nomePranch = namePranch(dir);

            }
            else // Caso o Arquivo de Configuração não exista
            {
                string[] l = new string[6];
                Globals.Array = l;
            }

        }

        public string Fala(string dir)
        {
            if (File.Exists(dir + "init.calt")) // Testa se o Arquivo de Configuração existe
            {
                string[] allLines = File.ReadAllLines(dir + "init.calt"); // Faz a leitura do Arquivo de Configuração
                string text = string.Empty; // Cria uma string vazia para receber a fala
                if (allLines.Length >= 5)
                {
                    if (allLines[3] != null)
                    {
                        text = allLines[3]; // Pega a fala na linha correspondente do Arquivo de Configuração
                        if (text == "%wav%")
                        {
                            text = allLines[5];
                        }
                    }
                }
                return text;


            }
            else // Caso o Arquivo de Configuração não exista
            {
                string text = string.Empty;
                return text; // Retorna uma fala nula
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
            int salv = 0;
            string Diretorio = Globals.Save_Directory + @"\Pranchetas\" + nome;
            if (!Directory.Exists(Diretorio))
            {
                Directory.CreateDirectory(Diretorio);
            }
            else
            {
                if (Globals.Salv == 0)
                {
                    DialogResult result = MessageBox.Show("Já existe uma prancheta com este nome. Deseja sobrepor a antiga informação com a nova?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Globals.Salv = 1;
                        salv = 1;
                    } else
                    {
                        salv = 0;
                    }

                } else
                {
                    salv = 1;
                }
            }
            if (salv == 1)
            {
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
                        if (info[i] == string.Empty || info[i] == "" || info[i] == null)
                        {
                            File.AppendAllText(infofile, "");
                            File.AppendAllText(infofile, Environment.NewLine);
                        }
                        else
                        {
                            File.AppendAllText(infofile, l[i]);
                            File.AppendAllText(infofile, Environment.NewLine);
                        }
                    }
                    File.AppendAllText(infofile, nome);
                    File.AppendAllText(infofile, Environment.NewLine);


                }
                else
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (info[i] == string.Empty || info[i] == "" || info[i] == null)
                        {
                            File.AppendAllText(infofile, "");
                            File.AppendAllText(infofile, Environment.NewLine);
                        }
                        else
                        {
                            File.AppendAllText(infofile, info[i]);
                            File.AppendAllText(infofile, Environment.NewLine);
                        }
                    }
                    File.AppendAllText(infofile, nome);
                    File.AppendAllText(infofile, Environment.NewLine);
                }

                string caltiinfofile = Globals.Save_Directory + @"\Pranchetas\pranch.caltinfo";

                if (File.Exists(caltiinfofile))
                {

                    string[] testinfo = File.ReadAllLines(caltiinfofile);
                    string infocalt = string.Empty;
                    int ok = 0;
                    for (int f = 0; f < testinfo.Length; f++)
                    {
                        infocalt = testinfo[f];
                        if (infocalt != Diretorio + @"\")
                        {
                            ok++;
                        }
                    }
                    if (ok == testinfo.Length)
                    {
                        File.AppendAllText(caltiinfofile, Environment.NewLine);
                        File.AppendAllText(caltiinfofile, Diretorio + @"\");
                    }


                }
                else
                {
                    File.AppendAllText(caltiinfofile, Diretorio + @"\");
                }

                MessageBox.Show("Prancheta Salva");
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

                if (Globals.PranchImp == 0)
                {
                    MessageBox.Show("Símbolo Adicionado com Sucesso!");
                }

            }
            else
            {
                MessageBox.Show("Formato de arquivo inválido");
            }

            
        }

        public void ExportarPrancheta(string info)
        {

            if (File.Exists(info + "info.calt")) // Testa se o Arquivo de Configuração existe
            {
                string[] allLines = File.ReadAllLines(info + "info.calt"); // Faz a leitura do Arquivo de Configuração
                string[] l = new string[6];
                if (allLines.Length >= 6)
                {
                    for (int i = 0; i < 6; i++)
                    {

                        l[i] = allLines[i];
                    }
                }
                
                
                string nomePranch = namePranch(info);
                Directory.CreateDirectory(Globals.Save_Directory + @"\Export\Pranchetas\" + nomePranch);
                Directory.CreateDirectory(Globals.Save_Directory + @"\Temp\" + nomePranch);
                File.Copy(info + "info.calt", Globals.Save_Directory + @"\Temp\" + nomePranch + @"\info.calt");

                for (int i = 0; i < 6; i++)
                {
                    if (l[i] != "" && l[i] != null)
                    {
                        string namef = l[i].Replace(Globals.Save_Directory + @"\Symbols", "");
                        string name = namef.Replace(@"\", "");
                        string exp = l[i].Replace(Globals.Save_Directory + @"\Symbols\" + name, Globals.Save_Directory + @"\Temp\" + nomePranch + @"\Simbolos");
                        if (!Directory.Exists(exp))
                        {
                            Directory.CreateDirectory(exp);
                        }

                        if (File.Exists(exp + name + ".calts"))
                        {
                            File.Delete(exp + name + ".calts");
                        }

                        ZipFile.CreateFromDirectory(l[i], exp + name + ".calts");
                        string infofile = exp + name + ".caltcfg";



                        if (File.Exists(infofile))
                        {
                            File.Delete(infofile);
                        }
                        File.AppendAllText(infofile, name);
                        File.AppendAllText(infofile, Environment.NewLine);
                        File.AppendAllText(infofile, name + ".calts");
                        File.AppendAllText(infofile, Environment.NewLine);
                        File.AppendAllText(infofile, name + ".caltcfg");
                    }

                    
                }
                if (File.Exists(Globals.Save_Directory + @"\Export\Pranchetas\" + nomePranch + @"\" + nomePranch + ".caltp"))
                {
                    File.Delete(Globals.Save_Directory + @"\Export\Pranchetas\" + nomePranch + @"\" + nomePranch + ".caltp");
                }
                ZipFile.CreateFromDirectory(Globals.Save_Directory + @"\Temp\" + nomePranch, Globals.Save_Directory + @"\Export\Pranchetas\" + nomePranch + @"\" + nomePranch + ".caltp");
                Directory.Delete(Globals.Save_Directory + @"\Temp\" + nomePranch, true);

                string infofile2 = Globals.Save_Directory + @"\Export\Pranchetas\" + nomePranch + @"\" + nomePranch + ".caltpcfg";



                if (File.Exists(infofile2))
                {
                    File.Delete(infofile2);
                }
                File.AppendAllText(infofile2, nomePranch);
                File.AppendAllText(infofile2, Environment.NewLine);
                File.AppendAllText(infofile2, nomePranch + ".caltp");
                File.AppendAllText(infofile2, Environment.NewLine);
                File.AppendAllText(infofile2, nomePranch + ".caltpcfg");

                System.Diagnostics.Process.Start("explorer.exe", Globals.Save_Directory + @"\Export\Pranchetas\" + nomePranch);


            }
            else // Caso o Arquivo de Configuração não exista
            {
                MessageBox.Show("A prancheta não existe");
            }

        }

        public void ExportarSimbolo(string info)
        {
            string exp = info.Replace(Globals.Save_Directory + @"\Symbols", Globals.Save_Directory + @"\Export\Simbolos");
            string namef = info.Replace(Globals.Save_Directory + @"\Symbols", "");
            string name = namef.Replace(@"\", "");
            if (!Directory.Exists(exp))
            {
                Directory.CreateDirectory(exp);
            } 

            if (File.Exists(exp + name + ".calts"))
            {
                File.Delete(exp + name + ".calts");
            }

            ZipFile.CreateFromDirectory(info, exp + name + ".calts");
            string infofile = exp + name + ".caltcfg";

            

            if (File.Exists(infofile))
            {
                File.Delete(infofile);
            }
            File.AppendAllText(infofile, name);
            File.AppendAllText(infofile, Environment.NewLine);
            File.AppendAllText(infofile, name + ".calts");
            File.AppendAllText(infofile, Environment.NewLine);
            File.AppendAllText(infofile, name + ".caltcfg");

            System.Diagnostics.Process.Start("explorer.exe", exp);
        }


        public void ImportarPrancheta(string Arquivo)
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
            string Diretoriotemp = Globals.Save_Directory + @"\Temp\Pranchetas\" + line;
            string Diretorio = Globals.Save_Directory + @"\Pranchetas\" + line;
            if (Directory.Exists(Diretoriotemp))
            {
                System.IO.DirectoryInfo di2 = new DirectoryInfo(Diretoriotemp);
                di2.Delete(true);
            }
            else if (!Directory.Exists(Diretoriotemp))
            {
                Directory.CreateDirectory(Diretoriotemp);
            }


            try
            {
                ZipFile.ExtractToDirectory(file, Diretoriotemp);
            }
            catch
            {
                throw;
            }
            

            string infofile = Globals.Save_Directory + @"\Pranchetas\pranch.caltinfo";

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
            if (Directory.Exists(Diretorio))
            {
                Directory.Delete(Diretorio, true);
            }
            Directory.CreateDirectory(Diretorio);
            File.Copy(Diretoriotemp + @"\info.calt", Diretorio + @"\info.calt");

            string temp = Diretoriotemp + @"\Simbolos\";


            DirectoryInfo di = new DirectoryInfo(temp);

            foreach (var fi in di.GetFiles("*.caltcfg"))
            {
                Globals.PranchImp = 1;
                addSymb(fi.FullName);
            }
            Globals.PranchImp = 0;
            Directory.Delete(Diretoriotemp, true);

            MessageBox.Show("Prancheta Adicionada com Sucesso!");



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

