//Libs de Sistema
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO.Ports;

//Libs de Aforge
using AForge.Video;
using AForge.Video.DirectShow;

//Libs Adicionais
using MjpegProcessor;
using System.Net;
using System.Drawing;
using Broadcaster.Properties;
using AForge.Video.FFMPEG;

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

        MjpegDecoder mjpeg;

        public Form1()
        {
            InitializeComponent();
            getCamList();
            getBluetoothList();

            LocalCamera.Image = Resources.Static;
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
            image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            LocalCamera.Image = image;
        }

        //Botão que liga ou desliga a webcam
        private void LC1Btn_Click(object sender, EventArgs e)
        {
            //Mudar a cor para indicar se esta ON ou OFF
            if(LC1state == false)
            {
                LC1Btn.BackColor = System.Drawing.Color.Green;
                LC1state = true;
                webcamSource = new VideoCaptureDevice(webcamDevices[WCconfig.SelectedIndex].MonikerString);
                webcamSource.NewFrame += new NewFrameEventHandler(webcam_newframe);
                webcamSource.Start();
            }
            else
            {
                LC1Btn.BackColor = System.Drawing.Color.Red;
                LC1state = false;
                webcamSource.Stop();
                LocalCamera.Image = Resources.Static;
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

        private void Play_Click(object sender, EventArgs e)
        {
            YTFiles.Movie = "https://www.youtube.com/v/3cj-hjYEASk?autoplay=1&showinfo=0&controls=0";
        }

        private void Btconfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortBT.PortName = (string)Btconfig.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LFiles.URL = "D:/Workspace/indes_2015/Aula 5/Broadcaster/CIMG9865.AVI";
        }
    }
}
