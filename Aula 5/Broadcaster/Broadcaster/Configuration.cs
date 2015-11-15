using AForge.Video.DirectShow;
using System;
using System.IO;
using System.Windows.Forms;

namespace Broadcaster
{
    public partial class Configuration : Form
    {
        // Variáveis globais
        private string configPath;
        private string selectedFileLogo = "";
        private string selectedFileWallpaper = "";
        private string newConfig;
        private string userImagesPath;

        // WebCam
        private FilterInfoCollection webcamDevices;
        private bool webcamExist = false;

        public Configuration()
        {
            InitializeComponent();
            getCamList();
            getConfigPath();
            getUserImagesPath();
            loadConfigFile();
        }

        /*============================================================================================
        *= Funções auxiliares
        *=============================================================================================*/
        /*
        *   Função para obter a lista de cameras
        */
        private void getCamList()
        {
            try
            {
                webcamDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                wbBox.Items.Clear();
                wbBox2.Items.Clear();

                if (webcamDevices.Count == 0)
                {
                    throw new ApplicationException();
                }

                webcamExist = true;

                foreach (FilterInfo webcam in webcamDevices)
                {
                    wbBox.Items.Add(webcam.Name);
                    wbBox2.Items.Add(webcam.Name);
                }
            }
            catch (ApplicationException)
            {
                webcamExist = false;
                wbBox.Items.Add("< No WebCams found >");
                wbBox2.Items.Add("< No WebCams found >");
            }
        }

        /*
        *   Função para obter o diretório de configuração da aplicação
        */
        private void getConfigPath()
        {
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            configPath = parentDirectory + "\\Config\\";
        }

        /*
        *   Função para obter o diretório de imagens do utilizador
        */
        private void getUserImagesPath()
        {
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            userImagesPath = parentDirectory + "\\Images\\User\\";
        }

        /*
        *   Função para carregar o ficheiro de configurações
        */
        private void loadConfigFile()
        {
            // Obter o caminho do ficheiro de configuração
            string file = "config.txt";
            string fullFilePath = configPath + file;

            if (File.Exists(fullFilePath))
            {
                Console.WriteLine("Info: File " + fullFilePath + " exists.");
                
                //Ler valores dentro do ficheiro
                string[] values = File.ReadAllText(fullFilePath).Split(';');

                if (values.Length > 0)
                {
                    titleBox.Text          = values[0];
                    logoBox.Text           = values[1];
                    bgBox.Text             = values[2];
                    try
                    {
                        wbBox.SelectedIndex = Int32.Parse(values[3]);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("INFO: The webcam doesn't exist!");
                        wbBox.SelectedIndex = 0;
                    }
                    try
                    {
                        wbBox2.SelectedIndex = Int32.Parse(values[4]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("INFO: The webcam doesn't exist!");
                        wbBox2.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Info: File " + fullFilePath + " doesn't exist.");
            }
        }

        /*============================================================================================
        *= Botões
        *=============================================================================================*/
        /*
        *   Função para abrir o explorador e escolher um novo logo
        */
        private void lOpenBtn_Click(object sender, EventArgs e)
        {
            //Explorador
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files|*.jpeg|JPG Files|*.jpg|PNG Files|*.png";
            dialog.FilterIndex = 1;

            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileLogo = dialog.FileName;
            }
            else
            {
                selectedFileLogo = "";
            }

            if (selectedFileLogo != "")
            {
                string imageFile = selectedFileLogo.Substring(selectedFileLogo.LastIndexOf("\\") + 1);
                logoBox.Text     = imageFile;
            }
        }

        /*
        *   Função para abrir o explorador e escolher um novo fundo
        */
        private void wOpenBtn_Click(object sender, EventArgs e)
        {
            //Explorador
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files|*.jpeg|JPG Files|*.jpg|PNG Files|*.png";
            dialog.FilterIndex = 1;

            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileWallpaper = dialog.FileName;
            }
            else
            {
                selectedFileWallpaper = "";
            }

            if (selectedFileWallpaper != "")
            {
                string imageFile = selectedFileWallpaper.Substring(selectedFileWallpaper.LastIndexOf("\\") + 1);
                bgBox.Text = imageFile;
            }
        }        

        /*
        *   Função para gravar o ficheiro das novas configurações
        */
        private void saveConf_Click(object sender, EventArgs e)
        {
            // Definir o nome do ficheiro config e do default
            string configFile  = "config.txt";
            string defaultFile = "default.txt";

            // Definir os caminhos para os ficheiros
            string configFilePath  = configPath + configFile;
            string defaultFilePath = configPath + defaultFile;
            
            if (!File.Exists(defaultFilePath))
            {
                //Se não existir cria o ficheiro default
                File.Move(configFilePath, defaultFilePath);
            }
            else
            {
                //Limpa o ficheiro de configuração
                File.WriteAllText(configFilePath, "");
            }

            // Copiar nova imagem logotipo
            if (selectedFileLogo != "")
            {
                string imageFile = selectedFileLogo.Substring(selectedFileLogo.LastIndexOf("\\") + 1);
                string destination = userImagesPath + imageFile;

                if (!File.Exists(destination))
                {
                    File.Copy(selectedFileLogo, destination);
                }                          
            }

            // Copiar nova imagem wallpaper
            if (selectedFileWallpaper != "")
            {
                string imageFile = selectedFileWallpaper.Substring(selectedFileWallpaper.LastIndexOf("\\") + 1);
                string destination = userImagesPath + imageFile;

                if (!File.Exists(destination))
                {
                    File.Copy(selectedFileWallpaper, destination);
                }                             
            }

            //Criar novo ficheiro de configuração
            TextWriter tw = new StreamWriter(configFilePath, true);
            newConfig = titleBox.Text + ";";
            newConfig += logoBox.Text + ";";
            newConfig += bgBox.Text + ";";
            newConfig += wbBox.SelectedIndex + ";";
            newConfig += wbBox2.SelectedIndex + ";";
            tw.Write(newConfig);
            tw.Close();

            statusBox.Text = "Configuration saved successfully!";
        }

        /*
        *   Função para carregar o ficheiro de configurações default
        */
        private void defaultConf_Click(object sender, EventArgs e)
        {
            // Definir o nome do ficheiro config e do default
            string configFile = "config.txt";
            string defaultFile = "default.txt";

            // Definir os caminhos para os ficheiros
            string configFilePath = configPath + configFile;
            string defaultFilePath = configPath + defaultFile;

            if (File.Exists(defaultFile))
            {
                //Voltar a definir os valores default
                string[] values = File.ReadAllText(defaultFile).Split(';');

                titleBox.Text = values[0];
                logoBox.Text  = values[1];
                bgBox.Text    = values[2];
                try
                {
                    wbBox.SelectedIndex = Int32.Parse(values[3]);
                }
                catch (Exception e2)
                {
                    Console.WriteLine("INFO: The webcam doesn't exist!");
                    wbBox.SelectedIndex = 0;
                }
                try
                {
                    wbBox2.SelectedIndex = Int32.Parse(values[3]);
                }
                catch (Exception e2)
                {
                    Console.WriteLine("INFO: The 2nd webcam doesn't exist!");
                    wbBox2.SelectedIndex = 0;
                }

                File.Move(configFilePath, defaultFilePath);
            }
            else
            {
                titleBox.Text       = "INDES - BROADCASTER";
                logoBox.Text        = "logo1.png";
                bgBox.Text          = "wallpaper1.jpg";
                wbBox.SelectedIndex = 0;
                wbBox2.SelectedIndex = 0;

                //Limpa o ficheiro de configuração
                File.WriteAllText(configFilePath, "");

                //Escreve no ficheiro de configuração
                TextWriter tw = new StreamWriter(configFilePath, true);
                newConfig  = titleBox.Text + ";";
                newConfig += logoBox.Text  + ";";
                newConfig += bgBox.Text + ";";
                newConfig += wbBox.SelectedIndex + ";";
                newConfig += wbBox2.SelectedIndex + ";";
                tw.Write(newConfig);
                tw.Close();
            }

            statusBox.Text = "Default values restored!";
        }    
    }
}
