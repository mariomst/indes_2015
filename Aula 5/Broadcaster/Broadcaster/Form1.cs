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
        private FilterInfoCollection webcamDevices;
        private VideoCaptureDevice webcamSource     = null;
        private Bitmap image;
        private bool webcamExist                    = false;
        private bool LC1state                       = false;
        private bool LC2state                       = false;
        private bool LA1state                       = false;
        private bool LA2state                       = false;
        private bool LA3state                       = false;

        private string lfPath;
        private string ytPath;
        private string configPath;

        
        public Form1()
        {
            InitializeComponent();
            getCamList();
            getBluetoothList();
            getPath();
            this.Activated += new EventHandler(fillLists);
            
            LocalCamera.Image = Resources.Static;
            lfPicture.Image   = Resources.Static;
            ytPicture.Image   = Resources.Static;
            livePicture.Image = Resources.Static;
        }

        private void getPath()
        {
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            lfPath = parentDirectory + "\\Videos\\LF\\";
            ytPath = parentDirectory + "\\Videos\\YT\\";
            configPath = parentDirectory + "\\Config\\";
        }
        //Função para obter a lista de cameras
        private void getCamList()
        {
            try
            {
                webcamDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                WCconfig.Items.Clear();

                if (webcamDevices.Count == 0)
                {
                    throw new ApplicationException();
                }

                webcamExist = true;

                foreach (FilterInfo webcam in webcamDevices)
                {
                    WCconfig.Items.Add(webcam.Name);
                }
            }
            catch (ApplicationException)
            {
                webcamExist = false;
                WCconfig.Items.Add("< 0 WebCams found >");
            }

            WCconfig.SelectedIndex = 0;
        }

        //Função para obter a lista de COMs de bluetooth
        private void getBluetoothList()
        {
            List<string> btList = new List<string>();

            Btconfig.Items.Clear();

            foreach (string com in SerialPort.GetPortNames())
            {
                btList.Add(com);
            }

            if(btList.Count < 1)
            {
                btList.Add("< 0 COM ports found >");
            }

            btList.Sort();
            Btconfig.Items.AddRange(btList.ToArray());
            Btconfig.SelectedIndex = 0;
        }

        void webcam_newframe(object sender, NewFrameEventArgs eventargs)
        {
            image = (Bitmap)eventargs.Frame.Clone();
            //image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            LocalCamera.Image = image;
        }

        //Botão que liga ou desliga a webcam
        private void LC1Btn_Click(object sender, EventArgs e)
        {
            //Mudar a cor para indicar se esta ON ou OFF
            if(LC1state == false)
            {
                LC1Btn.BackColor = System.Drawing.Color.Green;
                LC1state         = true;
                webcamSource     = new VideoCaptureDevice(webcamDevices[WCconfig.SelectedIndex].MonikerString);
                webcamSource.NewFrame += new NewFrameEventHandler(webcam_newframe);
            }
            else
            {
                LC1Btn.BackColor = System.Drawing.Color.Red;
                LC1state = false;
                webcamSource.Stop();
            }
        }

        private void LC2Btn_Click(object sender, EventArgs e)
        {
            //Mudar a cor para indicar se esta ON ou OFF
            if (LC2state == false)
            {
                LC2Btn.BackColor = System.Drawing.Color.Green;
                LC2state = true;
            }
            else
            {
                LC2Btn.BackColor = System.Drawing.Color.Red;
                LC2state = false;
            }

           // string fulladdress = "";
           // LocalCamera.BackgroundImage = Image.FromFile(fulladdress);

            var request = WebRequest.Create("http://192.168.1.4:8080/video");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                LocalCamera.BackgroundImage = Bitmap.FromStream(stream);
            }

            //Caso tenha um endereço IP da prioridade a esse, se não utiliza o de bluetooth:
            if (WCaddress.Text != "")
            {
                string input = WCaddress.Text;
                //string fulladdress = "http://192.168.1.4:8080/video";
                //LC2.Movie = fulladdress;

                //IPAddress address;
                /*if (IPAddress.TryParse(input, out address))
                {
                    switch (address.AddressFamily)
                    {
                        case System.Net.Sockets.AddressFamily.InterNetwork:
                           
                            break;
                        default:
                            break;
                    }
                }*/
            }
            else
            {
                //Realizar ligação com o dispositivo associado a porta escolhida
                if (Btconfig.SelectedText != "< 0 COM ports found >")
                {
                    if (!serialPortBT.IsOpen)
                    {
                        serialPortBT.BaudRate = 9600;
                        serialPortBT.ReadTimeout = 1000;
                        serialPortBT.Open();
                    }
                    else
                    {
                        serialPortBT.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error: No COM Port selected!", "Broadcaster Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } 
        }

        private void Btconfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortBT.PortName = (string)Btconfig.SelectedItem;
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

        /*
         * Abrir janela com a lista de Videos Locais
         */
        private void editLF_Click(object sender, EventArgs e)
        {
            ListLF ListLF = new ListLF();
            ListLF.Show();
        }

        /*
         * Abrir janela com a lista de Videos Youtube
         */
        private void editYT_Click(object sender, EventArgs e)
        {
            ListYT ListYT = new ListYT();
            ListYT.Show();
        }

        /*
         * Função para ativar o preview da webcam
         */
        private void LA1_Click(object sender, EventArgs e)
        {
            //Mudar a cor para indicar se esta ON ou OFF
            if (LA1state == false)
            {
                LA1state = true;
                LA1.BackColor = System.Drawing.Color.Green;

                if (LC1state == true)
                {
                    
                    webcamSource.Start();
                }
                else if (LC2state == true)
                {

                }
            }
            else
            {
                LA1state = false;
                LA1.BackColor = System.Drawing.Color.Red;
                LocalCamera.Image = Resources.Static;
            }      
        }

        /*
         * Função para ativar o preview dos videos locais
         */
        private void LA2_Click(object sender, EventArgs e)
        {
            if(LA2state == false)
            {
                LA2state = true;
                LA2.BackColor = System.Drawing.Color.Green;

                string video = LFList.SelectedItem.ToString();
                string videoPath = lfPath + video;

                lfPicture.Hide();
                LFiles.URL = videoPath;
                LFiles.settings.mute = true;
            }
            else 
            {
                LA2state = false;
                LA2.BackColor = System.Drawing.Color.Red;
                WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)LFiles.Ctlcontrols;
                controls.stop();
                lfPicture.Show();
            }            
        }

        /*
         * Função para ativar o preview dos videos Web
         */
        private void LA3_Click(object sender, EventArgs e)
        {
            ytPicture.Hide();
            YTFiles.URL = "https://www.youtube.com/v/3cj-hjYEASk?autoplay=1&showinfo=0&controls=0";
            YTFiles.settings.volume = 0;
        }        
    }
}
