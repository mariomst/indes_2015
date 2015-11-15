﻿//Libs de Sistema
using System;
using System.Windows.Forms;
using System.Drawing;
using Broadcaster.Properties;
using System.IO;

//Libs de Aforge
using AForge.Video;
using AForge.Video.DirectShow;

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
        private string plPath;
        private int indexPL;

        // WebCam
        private FilterInfoCollection webcamDevices;
        private VideoCaptureDevice webcamSource     = null;
        private Bitmap image1;
        private Bitmap image2;
        private bool webcamExist                    = false;
        private int selectedWebCam;
        private int selectedWebCamLC2;

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

            livePicture.Show();
            LiveCamera.Hide();            
            live.Hide();

            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            header.Width = PLList.Width;
            PLList.Columns.Add(header);
            PLList.HeaderStyle = ColumnHeaderStyle.None;
            PLList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
            configPath     = parentDirectory + "\\Config\\";
            userImagesPath = parentDirectory + "\\Images\\User\\";
            ImagesPath     = parentDirectory + "\\Images\\";
            lfPath         = parentDirectory + "\\Videos\\LF\\";
            ytPath         = parentDirectory + "\\Videos\\YT\\";
            plPath         = parentDirectory + "\\Videos\\PL\\";       
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
                    this.Text = values[0];

                    // Logo
                    if (values[1] != "logo1.png" || values[1] != "")
                    {
                        Console.WriteLine("Info: Custom Logo detected. Using custom images directory.");
                        string logoImage = userImagesPath + values[1];
                        if (File.Exists(logoImage))
                        {
                            Console.WriteLine("Info: Loading logo image.");
                            logoBox.Image = Image.FromFile(logoImage);
                        }
                        else
                        {
                            Console.WriteLine("Info: Couldn't find logo image.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Info: Using default images directory.");
                        string logoImage = ImagesPath + values[1];
                        if (File.Exists(logoImage))
                        {
                            Console.WriteLine("Info: Loading logo image.");
                            logoBox.Image = Image.FromFile(logoImage);
                        }
                    }

                    // Fundo
                    if (values[2] != "wallpaper1.jpg" || values[2] != "")
                    {
                        Console.WriteLine("Info: Custom background detected. Using custom images directory.");
                        string backgroundImage = userImagesPath + values[2];
                        if (File.Exists(backgroundImage))
                        {
                            Console.WriteLine("Info: Loading background image.");
                            this.BackgroundImage = Image.FromFile(backgroundImage);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Info: Using default images directory.");
                        string backgroundImage = ImagesPath + values[2];
                        if (File.Exists(backgroundImage))
                        {
                            this.BackgroundImage = Image.FromFile(backgroundImage);
                        }
                    }                                                          

                    // Webcam
                    selectedWebCam = Int32.Parse(values[3]);

                    // IP Webcam 
                    selectedWebCamLC2 = Int32.Parse(values[4]);
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
            image1 = (Bitmap)eventargs.Frame.Clone();
            image2 = (Bitmap)eventargs.Frame.Clone();
            //image1.RotateFlip(RotateFlipType.RotateNoneFlipY); //Fix hardcoded para o caso da camara aparecer invertida
            //image2.RotateFlip(RotateFlipType.RotateNoneFlipY); //Fix hardcoded para o caso da camara aparecer invertida
            LocalCamera.Image = image1;
            LiveCamera.Image = image2;
        }

        /*
         * Função para preencher as listas
         */
        private void fillLists(object sender, EventArgs e)
        {
            string lfList = "videos.txt";
            string ytList = "links.txt";
            string catList = "categories.txt";

            string lfPathList = lfPath + lfList;
            string ytPathList = ytPath + ytList;
            string catPathList = plPath + catList;

            string[] values;

            if (File.Exists(lfPathList))
            {
                Console.WriteLine("Info: File " + lfList + " exists.");

                //Ler valores dentro do ficheiro               
                if(new FileInfo(lfPathList).Length > 0)
                {
                    values = File.ReadAllText(lfPathList).Split(';');

                    if (values.Length > 0)
                    {
                        comboBox1.Items.Clear();
                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i] != "")
                            {
                                string item = values[i].ToString();
                                comboBox1.Items.Add(item);
                            }
                        }

                        comboBox1.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Info: File " + lfList + " doesn't exist.");
            }

            if (File.Exists(ytPathList))
            {
                Console.WriteLine("Info: File " + ytList + " exists.");

                //Ler valores dentro do ficheiro               
                if (new FileInfo(ytPathList).Length > 0)
                {
                    //Ler valores dentro do ficheiro
                    values = File.ReadAllText(ytPathList).Split(';');

                    if (values.Length > 0)
                    {
                        YTList.Items.Clear();
                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i] != "")
                            {
                                string[] aux = values[i].Split('#');
                                string listItem = aux[0] + " - " + aux[1];
                                YTList.Items.Add(listItem);
                            }
                        }

                        YTList.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Info: File " + ytList + " doesn't exist.");
            }

            if (File.Exists(catPathList))
            {
                Console.WriteLine("Info: File " + catList + " exists.");

                //Ler valores dentro do ficheiro               
                if (new FileInfo(catPathList).Length > 0)
                {
                    //Ler valores dentro do ficheiro
                    values = File.ReadAllText(catPathList).Split(';');

                    if (values.Length > 0)
                    {
                        categoryList.Items.Clear();
                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i] != "")
                            {
                                categoryList.Items.Add(values[i]);
                            }
                        }

                        categoryList.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Info: File " + catList + " doesn't exist.");
            }
        }

        /*
        *   Função para preencher a playlist de acordo com a categoria
        */
        private void loadPlaylist()
        {
            string category     = categoryList.SelectedItem.ToString();
            string playlist     = category + ".txt";
            string plFilePath   = plPath + playlist;

            //Limpar a playlist antes de carregar novos itens.
            PLList.Items.Clear();

            if (File.Exists(plFilePath))
            {
                Console.WriteLine("Info: File " + playlist + " exists.");

                //Ler valores dentro do ficheiro
                string[] values = File.ReadAllText(plFilePath).Split(';');

                if (values.Length > 0)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] != "")
                        {
                            PLList.Items.Add(values[i]);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Info: File " + playlist + " doesn't exist.");
            }
        }

        /*
        *   Função para carregar o ficheiro video ou url
        */
        private void loadPlaylistItem()
        {
            WMPLib.IWMPPlaylist playlist = live.playlistCollection.newPlaylist("pl");
            WMPLib.IWMPMedia media;

            foreach (ListViewItem item in PLList.Items)
            {
                string itemText = item.Text;

                if (itemText.Contains("[LF]"))
                {
                    //é um ficheiro local
                    //tratar da string
                    string[] result = itemText.Split(new string[] { "[LF] " }, StringSplitOptions.None);
                    string localFile = result[1];

                    string videoPath = lfPath + localFile;

                    media = live.newMedia(videoPath);
                    playlist.appendItem(media);
                }
                if (itemText.Contains("[YT]"))
                {
                    //é um ficheiro youtube
                    //tratar da string
                    string urlAux = itemText.Substring(itemText.IndexOf("=") + 1);
                    string newUrl = "https://www.youtube.com/v/" + urlAux + "?autoplay=1&showinfo=0&controls=0";

                    media = live.newMedia(newUrl);
                    playlist.appendItem(media);
                }
            }

            livePicture.Hide();
            live.currentPlaylist = playlist;
            live.Ctlcontrols.play();
            live.Show();
        }

        /*
        *   Função para mudar a playlist caso seja alterado a categoria
        */
        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexPL = 0;
            loadPlaylist();
        }

        /*
        *   Função para mudar a preview caso seja alterado
        */
        private void LFList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obter o caminho do ficheiro de video
            string video = comboBox1.SelectedItem.ToString();
            string videoPath = lfPath + video;

            // Iniciar live dos videos locais
            LFiles.URL = videoPath;
            LFiles.Show();
            lfPicture.Hide();
            LFiles.settings.mute = true;

            if(LA2state == true)
            {
                live.URL = videoPath;
            }
        }

        /*
        *   Função para mudar a preview caso seja alterado
        */
        private void YTList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Processar o URL
            string url = YTList.SelectedItem.ToString();
            if (url != "")
            {
                string urlAux = url.Substring(url.IndexOf("=") + 1);
                string newUrl = "https://www.youtube.com/v/" + urlAux + "?autoplay=1&showinfo=0&controls=0";

                // Iniciar preview do video
                YTFiles.URL = newUrl;
                ytPicture.Hide();
                YTFiles.Show();               
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
                    LC2Btn.BackColor = System.Drawing.Color.Red;
                    LC2state = false;

                    //Desativar a camara
                    webcamSource.Stop();
                }               

                //Ativar a WebCam
                if(webcamExist == true)
                { 
                    webcamSource = new VideoCaptureDevice(webcamDevices[selectedWebCam].MonikerString);
                    webcamSource.NewFrame += new NewFrameEventHandler(webcam_newframe);

                    //Mudar a cor para indicar que esta ON
                    LC1Btn.BackColor = System.Drawing.Color.Green;
                    LC1state = true;

                    //Mostrar na preview a webcam local
                    webcamSource.Start();
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

                LocalCamera.Image = Resources.offline;
            }
        }

        /*
        *   Função para a IP WebCam 
        */
        private void LC2Btn_Click(object sender, EventArgs e)
        {            
            if (LC2state == false)
            {
                //Caso o LC1 esteja ativo, desativa
                if (LC1state == true)
                {
                    LC1Btn.BackColor = System.Drawing.Color.Red;
                    LC1state = false;

                    //Desativar a camara
                    webcamSource.Stop();
                }

                //Ativar a WebCam
                if (webcamExist == true)
                {
                    webcamSource = new VideoCaptureDevice(webcamDevices[selectedWebCamLC2].MonikerString);
                    webcamSource.NewFrame += new NewFrameEventHandler(webcam_newframe);

                    //Mudar a cor para indicar que esta ON
                    LC2Btn.BackColor = System.Drawing.Color.Green;
                    LC2state = true;

                    //Mostrar na preview a webcam local
                    webcamSource.Start();
                }
                else
                {
                    Console.WriteLine("INFO: Failed to start the local webcam. Is there any webcam?");
                }
            }
            else
            {
                //Mudar a cor para indicar que esta OFF
                LC2Btn.BackColor = System.Drawing.Color.Red;
                LC2state = false;

                //Desactivar a WebCam
                webcamSource.Stop();

                LocalCamera.Image = Resources.offline;
            }
        }

        /*
        *   Função para o botão PL
        */
        private void PLBtn_Click(object sender, EventArgs e)
        {
            if (PLstate == false)
            {
                // Desativar todos os outros botões
                LA1state = false;
                LA2state = false;
                LA3state = false;
                LA1.BackColor = System.Drawing.Color.Red;
                LA2.BackColor = System.Drawing.Color.Red;
                LA3.BackColor = System.Drawing.Color.Red;

                // Mudar o estado do botão
                PLstate = true;
                PLBtn.BackColor = System.Drawing.Color.Green;

                loadPlaylistItem();
            }
            else
            {
                // Mudar o estado do botão
                PLstate = false;
                PLBtn.BackColor = System.Drawing.Color.Red;

                // Parar o video
                live.Ctlcontrols.stop();

                // Alterar a janela live
                livePicture.Image = Resources.offline;
                livePicture.Show();

                indexPL = 0;
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

                    //Mudar cor dos outros botões
                    LA2state = false;
                    LA3state = false;
                    LA2.BackColor = System.Drawing.Color.Red;
                    LA3.BackColor = System.Drawing.Color.Red;

                    //Mostrar na live area a camera
                    LiveCamera.Show();
                    livePicture.Hide();
                    live.Hide();

                }
                else if (LC2state == true)
                {
                    //Mudar a cor para indicar que esta ON
                    LA1state = true;
                    LA1.BackColor = System.Drawing.Color.Green;

                    //Mudar cor dos outros botões
                    LA2state = false;
                    LA3state = false;
                    LA2.BackColor = System.Drawing.Color.Red;
                    LA3.BackColor = System.Drawing.Color.Red;

                    //Mostrar na live area a camera
                    LiveCamera.Show();
                    livePicture.Hide();
                    live.Hide();
                }    
            }
            else
            {
                LA1state = false;
                LA1.BackColor = System.Drawing.Color.Red;

                LiveCamera.Hide();
                livePicture.Show();
                live.Hide();
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
                if (comboBox1.Items.Count > 0)
                {
                    // Mudar o estado do botão
                    LA2state = true;
                    LA2.BackColor = System.Drawing.Color.Green;

                    // Obter o caminho do ficheiro de video
                    string video = comboBox1.SelectedItem.ToString();
                    string videoPath = lfPath + video;

                    //Mudar cor dos outros botões
                    LA1state = false;
                    LA3state = false;
                    LA1.BackColor = System.Drawing.Color.Red;
                    LA3.BackColor = System.Drawing.Color.Red;

                    // Iniciar live dos videos locais
                    LiveCamera.Hide();
                    livePicture.Hide();
                    live.URL = videoPath;
                    live.Show();
                }
                else
                {
                    Console.WriteLine("INFO: There is no local videos to show");
                }          
            }
            else
            {
                // Mudar o estado do botão
                LA2state = false;
                LA2.BackColor = System.Drawing.Color.Red;

                // Parar o video
                WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)live.Ctlcontrols;
                controls.stop();

                // Alterar a janela preview
                livePicture.Image = Resources.offline;
                livePicture.Show();
                live.Hide();
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

                    //Mudar cor dos outros botões
                    LA2state = false;
                    LA1state = false;
                    LA2.BackColor = System.Drawing.Color.Red;
                    LA1.BackColor = System.Drawing.Color.Red;

                    // Processar o URL
                    string url = YTList.SelectedItem.ToString();
                    if (url != "")
                    {
                        string urlAux = url.Substring(url.IndexOf("=") + 1);
                        string newUrl = "https://www.youtube.com/v/" + urlAux + "?autoplay=1&showinfo=0&controls=0";

                        // Iniciar preview do video
                        live.URL = newUrl;
                        live.Show();
                        LiveCamera.Hide();
                        livePicture.Hide();
                    }
                }                              
            }
            else
            {
                // Mudar o estado do botão
                LA3state = false;
                LA3.BackColor = System.Drawing.Color.Red;

                // Parar o video
                WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)live.Ctlcontrols;
                controls.stop();

                // Alterar a janela preview
                live.Hide();
                LiveCamera.Hide();
                livePicture.Show();
            }
        }

        /*
        *   Função para abrir uma janela de criação de playlist
        */
        private void newPLBtn_Click(object sender, EventArgs e)
        {
            ListPL listPL = new ListPL("");
            listPL.Show();
        }

        /*
        *   Função para abrir uma janela de edição de playlist
        */
        private void editPLBtn_Click(object sender, EventArgs e)
        {
            string category = categoryList.SelectedItem.ToString();
            ListPL listPL = new ListPL(category);
            listPL.Show();
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
