//Libs de Sistema
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO.Ports;
using System.Net;
using System.Drawing;
using Broadcaster.Properties;
using System.IO;

//Libs de Aforge
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;

//Libs Adicionais
using MjpegProcessor;

namespace Broadcaster
{
    public partial class Form1 : Form
    {
        // Variáveis globais  
        private string configPath;
        private string ImagesPath;
        private string userImagesPath;
        private string lfPath;
        private string ytPath;
        
        // WebCam
        private FilterInfoCollection webcamDevices;
        private VideoCaptureDevice webcamSource     = null;
        private Bitmap image;
        private bool webcamExist                    = false;
        private int selectedWebCam;

        // IP WebCam
        private string WebCamIP;

        // Botões
        private bool LA1state = false;
        private bool LA2state = false;
        private bool LA3state = false;

        private bool LC1state = false;
        private bool LC2state = false;
        private bool PLstate  = false;
                
        public Form1()
        {
            InitializeComponent();
            this.Activated += new EventHandler(loadConfig);

            getPaths();
            getWebCamList();

            this.Activated += new EventHandler(fillLists);
            
            LocalCamera.Image = Resources.offline;
            lfPicture.Image   = Resources.offline;
            ytPicture.Image   = Resources.offline;
            livePicture.Image = Resources.offline;
        }

        /*============================================================================================
        *= Funções auxiliares
        *=============================================================================================*/
        /*
        *   Função para obter os diretórios da aplicação
        */
        private void getPaths()
        {
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            configPath = parentDirectory + "\\Config\\";
            userImagesPath = parentDirectory + "\\Images\\User\\";
            ImagesPath = parentDirectory + "\\Images\\";
            lfPath = parentDirectory + "\\Videos\\LF\\";
            ytPath = parentDirectory + "\\Videos\\YT\\";            
        }

        /*
        *   Função para carregar as configurações da aplicação
        */
        private void loadConfig(object sender, EventArgs e)
        {
            // Obter o caminho do ficheiro de configuração
            string configFile     = "config.txt";
            string configFilePath = configPath + configFile;

            // Verificar se o ficheiro existe
            if(File.Exists(configFilePath))
            {
                Console.WriteLine("Info: File " + configFile + " exists. Loading configuration.");

                //Ler valores dentro do ficheiro
                string[] values = File.ReadAllText(configFilePath).Split(';');

                if (values.Length > 0)
                {
                    // Titulo
                    titleLabel.Text = values[0];

                    // Fundo
                    if (values[2] != "wallpaper1.jpg")
                    {
                        Console.WriteLine("Info: Custom background detected. Using custom images directory.");
                        string backgroundImage = userImagesPath + values[2];
                        this.BackgroundImage = Image.FromFile(backgroundImage);
                    }
                    else
                    {
                        Console.WriteLine("Info: Using default images directory.");
                        string backgroundImage = ImagesPath + values[2];
                        this.BackgroundImage = Image.FromFile(backgroundImage);
                    }

                    // Logo
                    // ...

                    // Webcam
                    selectedWebCam = Int32.Parse(values[3]);

                    // IP Webcam 
                    WebCamIP = values[4];        
                }
            }
            else
            {
                Console.WriteLine("Info: File " + configFile + " exists. Using default configuration.");
            }
        }

        /*
        *   Função para obter a lista de WebCams
        */
        private void getWebCamList()
        {
            try
            {
                webcamDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);                

                if (webcamDevices.Count == 0)
                {
                    throw new ApplicationException();
                }

                webcamExist = true;                
            }
            catch (ApplicationException)
            {
                webcamExist = false;                
            }
        }
        
        /*
        *   Função para obter novos frames da webcam e mostrar no ecrã
        */
        void webcam_newframe(object sender, NewFrameEventArgs eventargs)
        {
            image = (Bitmap)eventargs.Frame.Clone();
            //image.RotateFlip(RotateFlipType.RotateNoneFlipY); //Fix hardcoded para o caso da camara aparecer invertida
            LocalCamera.Image = image;
        }

        /*
         * Função para preencher as listas
         */
        private void fillLists(object sender, EventArgs e)
        {
            string lfList = "videos.txt";
            string ytList = "youtube.txt";
            string lfPathList = lfPath + lfList;
            string ytPathList = ytPath + ytList;

            if (File.Exists(lfPathList))
            {
                Console.WriteLine("Info: File " + lfPathList + " exists.");

                //Ler valores dentro do ficheiro
                string[] values = File.ReadAllText(lfPathList).Split(';');

                if (values.Length > 0)
                {
                    LFList.Items.Clear();
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] != "")
                        {
                            LFList.Items.Add(values[i]);
                        }
                    }

                    LFList.SelectedIndex = 0;
                }
            }
            else
            {
                Console.WriteLine("Info: File " + lfPathList + " doesn't exist.");
            }
        }

        /*============================================================================================
        *= Botões
        *=============================================================================================*/
        /*
        *   Função para a WebCam local
        */
        private void LC1Btn_Click(object sender, EventArgs e)
        {            
            if(LC1state == false)
            {
                //Caso o LC2 esteja ativo, desativa
                if(LC2state == true)
                {
                    LC2Btn.BackColor = System.Drawing.Color.Green;
                    LC2state = false;
                }               

                //Ativar a WebCam
                if(webcamExist == true)
                { 
                    webcamSource = new VideoCaptureDevice(webcamDevices[selectedWebCam].MonikerString);
                    webcamSource.NewFrame += new NewFrameEventHandler(webcam_newframe);

                    //Mudar a cor para indicar que esta ON
                    LC1Btn.BackColor = System.Drawing.Color.Green;
                    LC1state = true;
                }
                else
                {
                    Console.WriteLine("INFO: Failed to start the local webcam. Is there any webcam?");
                }                
            }
            else
            {
                //Mudar a cor para indicar que esta OFF
                LC1Btn.BackColor = System.Drawing.Color.Red;
                LC1state = false;
                
                //Desactivar a WebCam
                webcamSource.Stop();
            }
        }

        /*
        *   Função para a IP WebCam 
        */
        private void LC2Btn_Click(object sender, EventArgs e)
        {            
            if (LC2state == false)
            {               
                //Verificar se o endereço é válido
                if(WebCamIP != "")
                {
                    //Mudar a cor para indicar que esta ON
                    LC2Btn.BackColor = System.Drawing.Color.Green;
                    LC2state = true;

                    //Ligação por IP à webcam
                    Uri uri = new Uri(WebCamIP);
                    var request = WebRequest.Create(uri);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        LocalCamera.Image = Bitmap.FromStream(stream);
                    }
                }
                else
                {
                    Console.WriteLine("Info: No IP for the IP WebCam provided.");
                    LocalCamera.Image = Resources.offline;
                }
            }
            else
            {
                //Mudar a cor para indicar que esta OFF
                LC2Btn.BackColor = System.Drawing.Color.Red;
                LC2state = false;

                LocalCamera.Image = Resources.offline;
            }           
        }          

        /*
         *  Função para abrir janela com a lista de Videos Locais
         */
        private void editLF_Click(object sender, EventArgs e)
        {
            ListLF ListLF = new ListLF();
            ListLF.Show();
        }

        /*
         *  Função para abrir janela com a lista de Videos Youtube
         */
        private void editYT_Click(object sender, EventArgs e)
        {
            ListYT ListYT = new ListYT();
            ListYT.Show();
        }

        /*
         *  Função para ativar o preview da webcam
         */
        private void LA1_Click(object sender, EventArgs e)
        {             
            if (LA1state == false)
            {                
                if (LC1state == true)
                {
                    //Mudar a cor para indicar que esta ON
                    LA1state = true;
                    LA1.BackColor = System.Drawing.Color.Green;

                    //Mostrar na preview a webcam local
                    webcamSource.Start();
                }
                else if (LC2state == true)
                {
                    //Mudar a cor para indicar que esta ON
                    LA1state = true;
                    LA1.BackColor = System.Drawing.Color.Green;

                    //Mostrar na preview a IP webcam
                    //...
                }
            }
            else
            {
                LA1state = false;
                LA1.BackColor = System.Drawing.Color.Red;

                //Parar a webcam
                if (LC1state == true)
                {
                    webcamSource.Stop();
                }

                LocalCamera.Image = Resources.offline;
            }      
        }

        /*
         *  Função para ativar o preview dos videos locais
         */
        private void LA2_Click(object sender, EventArgs e)
        {
            if(LA2state == false)
            {
                // Verificar se a combobox dos ficheiros locais tem algum item antes de tentar reproduzir
                if (LFList.Items.Count > 0)
                {
                    // Mudar o estado do botão
                    LA2state = true;
                    LA2.BackColor = System.Drawing.Color.Green;

                    // Obter o caminho do ficheiro de video
                    string video = LFList.SelectedItem.ToString();
                    string videoPath = lfPath + video;

                    // Iniciar preview do video
                    lfPicture.Hide();
                    LFiles.URL = videoPath;
                    LFiles.settings.mute = true;
                }                
            }
            else
            {
                // Mudar o estado do botão
                LA2state = false;
                LA2.BackColor = System.Drawing.Color.Red;

                // Parar o video
                WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)LFiles.Ctlcontrols;
                controls.stop();

                // Alterar a janela preview
                lfPicture.Image = Resources.offline;
                lfPicture.Show();
            }
        }

        /*
         * Função para ativar o preview dos videos Web
         */
        private void LA3_Click(object sender, EventArgs e)
        {            
            if (LA3state == false)
            {               
                // Verificar se a combobox dos ficheiros locais tem algum item antes de tentar reproduzir
                if (YTList.Items.Count > 0)
                {
                    // Mudar o estado do botão
                    LA3state = true;
                    LA3.BackColor = System.Drawing.Color.Green;

                    // Processar o URL
                    string url = YTList.SelectedItem.ToString();
                    if (url != "")
                    {
                        string urlAux = url.Substring(url.IndexOf("=") + 1);
                        string newUrl = "https://www.youtube.com/v/" + urlAux + "?autoplay=1&showinfo=0&controls=0";
                        Console.WriteLine(newUrl);

                        // Iniciar preview do video
                        YTFiles.URL = newUrl;
                        ytPicture.Hide();
                    }
                }                              
            }
            else
            {
                // Mudar o estado do botão
                LA3state = false;
                LA3.BackColor = System.Drawing.Color.Red;

                // Parar o video
                WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)YTFiles.Ctlcontrols;
                controls.stop();

                // Alterar a janela preview
                ytPicture.Image = Resources.offline;
                ytPicture.Show();
            }

            
            //YTFiles.URL = "https://www.youtube.com/v/3cj-hjYEASk?autoplay=1&showinfo=0&controls=0";
            //YTFiles.settings.volume = 0;
        }

        /*============================================================================================
        *= MENU
        *=============================================================================================*/
        /*
        *   Função para chamar a janela de configuração
        */
        private void configurationMenuItem_Click(object sender, EventArgs e)
        {
            Configuration config = new Configuration();
            config.Show();
        }

        /*
        *   Função para chamar a janela "About"
        */
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        /*
        *   Função para terminar a aplicação
        */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
