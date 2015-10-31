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

namespace Broadcaster
{
    public partial class Form1 : Form
    {        
        private FilterInfoCollection webcamDevices;
        private VideoCaptureDevice webcamSource     = null;
        private bool webcamExist                    = false;
        private bool LC1state                       = false;
        private bool LC2state                       = false;

        MjpegDecoder mjpeg;

        public Form1()
        {
            InitializeComponent();
            getCamList();
            getBluetoothList();
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

        //Botão que liga ou desliga a webcam
        private void LC1Btn_Click(object sender, EventArgs e)
        {
            //Mudar a cor para indicar se esta ON ou OFF
            if(LC1state == false)
            {
                LC1Btn.BackColor = System.Drawing.Color.Green;
                LC1state = true;
            }
            else
            {
                LC1Btn.BackColor = System.Drawing.Color.Red;
                LC1state = false;
            }


            /*  if (DeviceExist)
              {
                   videoSource = new VideoCaptureDevice(videoDevices[LCconfig.SelectedIndex].MonikerString);
                   videoSource.NewFrame += new NewFrameEventHandler(LocalCamera);
                       CloseVideoSource();
                       videoSource.DesiredFrameSize = new Size(160, 120);
                       videoSource.DesiredFrameRate = 10;
                       videoSource.Start();
                       //label2.Text = "Device running...";
                       //start.Text = "&Stop";
                       //timer1.Enabled = true;
              }
              else
              {
                   //         label2.Text = "Error: No Device selected.";
                   }
               }
               else
               {
                   if (videoSource.IsRunning)
                   {
                       timer1.Enabled = false;
                       CloseVideoSource();
                       label2.Text = "Device stopped.";
                       start.Text = "&Start";
                   }
               }*/
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
            LFiles.Movie = "https://www.youtube.com/v/3cj-hjYEASk?autoplay=1&showinfo=0&controls=0";
        }

        private void Btconfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortBT.PortName = (string)Btconfig.SelectedItem;
        }
    }
}
