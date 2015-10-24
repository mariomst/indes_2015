using System;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

namespace Broadcaster
{
    public partial class Form1 : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;
        
        public Form1()
        {
            InitializeComponent();
            getCamList();
        }

        //Função para obter a lista de cameras
        private void getCamList()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                LCconfig.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    LCconfig.Items.Add(device.Name);
                }
                LCconfig.SelectedIndex = 0; //Usar a primeira camera da lista
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                LCconfig.Items.Add("No capture device on your system");
            }
        }

        private void LCBtn_Click(object sender, EventArgs e)
        {
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
    }
}
