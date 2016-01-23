using Domotica.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domotica
{
    public partial class Form1 : Form
    {
        string path = Application.StartupPath;

        int lampada1state = 0;  int alarme1state = 0;   int temp1state = 0;   int fogao3state = 0;
        int lampada2state = 0;  int alarme2state = 0;   int temp2state = 0;   int fogao4state = 0;
        int lampada3state = 0;  int alarme3state = 0;   int temp3state = 0;
        int lampada4state = 0;  int alarme4state = 0;   int fogao1state = 0;
        int lampada5state = 0;  int alarme5state = 0;   int fogao2state = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lampada1_Click(object sender, EventArgs e)
        {
            if (lampada1state == 0) //se a lampada estiver desligada
            {
                lampada1state = 1;
                lampada1.BackgroundImage = Resources.LUZON;                
            }
            else
            {
                lampada1state = 0;
                lampada1.BackgroundImage = Resources.LUZ_OFF;                
            }
        }

        private void lampada2_Click(object sender, EventArgs e)
        {
            if (lampada2state == 0) //se a lampada estiver desligada
            {
                lampada2state = 1;
                lampada2.BackgroundImage = Resources.LUZON;                
            }
            else
            {
                lampada2state = 0;
                lampada2.BackgroundImage = Resources.LUZ_OFF;                
            }
        }

        private void lampada3_Click(object sender, EventArgs e)
        {
            if (lampada3state == 0) //se a lampada estiver desligada
            {
                lampada3state = 1;
                lampada3.BackgroundImage = Resources.LUZON;                
            }
            else
            {
                lampada3state = 0;
                lampada3.BackgroundImage = Resources.LUZ_OFF;                
            }
        }

        private void lampada4_Click(object sender, EventArgs e)
        {
            if (lampada4state == 0) //se a lampada estiver desligada
            {
                lampada4state = 1;
                lampada4.BackgroundImage = Resources.LUZON;                
            }
            else
            {
                lampada4state = 0;
                lampada4.BackgroundImage = Resources.LUZ_OFF;               
            }
        }

        private void lampada5_Click(object sender, EventArgs e)
        {
            if (lampada5state == 0) //se a lampada estiver desligada
            {
                lampada5state = 1;
                lampada5.BackgroundImage = Resources.LUZON;                
            }
            else
            {
                lampada5state = 0;
                lampada5.BackgroundImage = Resources.LUZ_OFF;                
            }
        }

        private void alarme1_Click(object sender, EventArgs e)
        {
            if (alarme1state == 0) //se o alarme estiver desligado
            {
                alarme1state = 1;
                alarme1.BackgroundImage = Resources.alarmeon;
            }
            else
            {
                alarme1state = 0;
                alarme1.BackgroundImage = Resources.alarmeoff;
            }
        }

        private void alarme2_Click(object sender, EventArgs e)
        {
            if (alarme2state == 0) //se o alarme estiver desligado
            {
                alarme2state = 1;
                alarme2.BackgroundImage = Resources.alarmeon;
            }
            else
            {
                alarme2state = 0;
                alarme2.BackgroundImage = Resources.alarmeoff;
            }
        }

        private void alarme3_Click(object sender, EventArgs e)
        {
            if (alarme3state == 0) //se o alarme estiver desligado
            {
                alarme3state = 1;
                alarme3.BackgroundImage = Resources.alarmeon;
            }
            else
            {
                alarme3state = 0;
                alarme3.BackgroundImage = Resources.alarmeoff;
            }
        }

        private void alarme4_Click(object sender, EventArgs e)
        {
            if (alarme4state == 0) //se o alarme estiver desligado
            {
                alarme4state = 1;
                alarme4.BackgroundImage = Resources.alarmeon;
            }
            else
            {
                alarme4state = 0;
                alarme4.BackgroundImage = Resources.alarmeoff;
            }
        }

        private void alarme5_Click(object sender, EventArgs e)
        {
            if (alarme5state == 0) //se o alarme estiver desligado
            {
                alarme5state = 1;
                alarme5.BackgroundImage = Resources.alarmeon;
            }
            else
            {
                alarme5state = 0;
                alarme5.BackgroundImage = Resources.alarmeoff;
            }
        }

        private void temp1_Click(object sender, EventArgs e)
        {
            if (temp1state == 0) //se o termometro estiver desligado
            {
                temp1state = 1;
                temp1label.Text = "23º";
                temp1.BackgroundImage = Resources.temphot;
            }
            else
            {
                temp1state = 0;
                temp1label.Text = "";
                temp1.BackgroundImage = Resources.tempcold;
            }
        }

        private void temp2_Click(object sender, EventArgs e)
        {
            if (temp2state == 0) //se o termometro estiver desligado
            {
                temp2state = 1;
                temp2label.Text = "19º";
                temp2.BackgroundImage = Resources.temphot;
            }
            else
            {
                temp2state = 0;
                temp2label.Text = "";
                temp2.BackgroundImage = Resources.tempcold;
            }
        }

        private void temp3_Click(object sender, EventArgs e)
        {
            if (temp3state == 0) //se o termometro estiver desligado
            {
                temp3state = 1;
                temp3label.Text = "33º";
                temp3.BackgroundImage = Resources.temphot;
            }
            else
            {
                temp3state = 0;
                temp3label.Text = "";
                temp3.BackgroundImage = Resources.tempcold;
            }
        }

        private void fogao1_Click(object sender, EventArgs e)
        {
            if (fogao1state == 0) //se o fogao estiver desligado
            {
                fogao1state = 1;
                fogao1.BackgroundImage = Resources.fogao1;
            }
            else if (fogao1state == 1)
            {
                fogao1state = 2;
                fogao1.BackgroundImage = Resources.fogao2;
            }
            else if (fogao1state == 2)
            {
                fogao1state = 3;
                fogao1.BackgroundImage = Resources.fogao3;
            }
            else if (fogao1state == 3)
            {
                fogao1state = 0;
                fogao1.BackgroundImage = Resources.fogao0;
            }
        }

        private void fogao2_Click(object sender, EventArgs e)
        {
            if (fogao2state == 0) //se o fogao estiver desligado
            {
                fogao2state = 1;
                fogao2.BackgroundImage = Resources.fogao1;
            }
            else if (fogao2state == 1)
            {
                fogao2state = 2;
                fogao2.BackgroundImage = Resources.fogao2;
            }
            else if (fogao2state == 2)
            {
                fogao2state = 3;
                fogao2.BackgroundImage = Resources.fogao3;
            }
            else if (fogao2state == 3)
            {
                fogao2state = 0;
                fogao2.BackgroundImage = Resources.fogao0;
            }
        }

        private void fogao3_Click(object sender, EventArgs e)
        {
            if (fogao3state == 0) //se o fogao estiver desligado
            {
                fogao3state = 1;
                fogao3.BackgroundImage = Resources.fogao1;
            }
            else if (fogao3state == 1)
            {
                fogao3state = 2;
                fogao3.BackgroundImage = Resources.fogao2;
            }
            else if (fogao3state == 2)
            {
                fogao3state = 3;
                fogao3.BackgroundImage = Resources.fogao3;
            }
            else if (fogao3state == 3)
            {
                fogao3state = 0;
                fogao3.BackgroundImage = Resources.fogao0;
            }
        }

        private void fogao4_Click(object sender, EventArgs e)
        {
            if (fogao4state == 0) //se o fogao estiver desligado
            {
                fogao4state = 1;
                fogao4.BackgroundImage = Resources.fogao1;
            }
            else if (fogao4state == 1)
            {
                fogao4state = 2;
                fogao4.BackgroundImage = Resources.fogao2;
            }
            else if (fogao4state == 2)
            {
                fogao4state = 3;
                fogao4.BackgroundImage = Resources.fogao3;
            }
            else if (fogao4state == 3)
            {
                fogao4state = 0;
                fogao4.BackgroundImage = Resources.fogao0;
            }
        }
    }
}
