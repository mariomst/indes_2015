using Dados.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
        DataTable stats = new DataTable("Stats");
        Random random = new Random();

        int freq_1 = 0; String perc_1 = "0.00"; double perc_1_aux = 0;
        int freq_2 = 0; String perc_2 = "0.00"; double perc_2_aux = 0;
        int freq_3 = 0; String perc_3 = "0.00"; double perc_3_aux = 0;
        int freq_4 = 0; String perc_4 = "0.00"; double perc_4_aux = 0;
        int freq_5 = 0; String perc_5 = "0.00"; double perc_5_aux = 0;
        int freq_6 = 0; String perc_6 = "0.00"; double perc_6_aux = 0;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
            CreateDataTable();
        }

        private void CreateDataTable()
        {            
            stats.Columns.Add(new DataColumn("Face"));
            stats.Columns.Add(new DataColumn("Frequency"));
            stats.Columns.Add(new DataColumn("Percent"));

            stats.Rows.Add("1", freq_1, perc_1 + "%");
            stats.Rows.Add("2", freq_2, perc_2 + "%");
            stats.Rows.Add("3", freq_3, perc_3 + "%");
            stats.Rows.Add("4", freq_4, perc_4 + "%");
            stats.Rows.Add("5", freq_5, perc_5 + "%");
            stats.Rows.Add("6", freq_6, perc_6 + "%");
            
            statsView.DataSource = stats;
        }

        private void calculatePerc1(int dice1, int dice2, int dice3, int dice4, int dice5, int dice6, int dice7, int dice8, int dice9, int dice10, int dice11, int dice12)
        {
            if (dice1 == 1)
            {
                dice1img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice2 == 1)
            {
                dice2img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice3 == 1)
            {
                dice3img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice4 == 1)
            {
                dice4img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice5 == 1)
            {
                dice5img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice6 == 1)
            {
                dice6img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice7 == 1)
            {
                dice7img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice8 == 1)
            {
                dice8img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice9 == 1)
            {
                dice9img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice10 == 1)
            {
                dice10img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice11 == 1)
            {
                dice11img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }
            if (dice12 == 1)
            {
                dice12img.BackgroundImage = Resources.dice_1;
                freq_1++;
            }

            perc_1_aux = (freq_1 / total) * 100;
            perc_1 = String.Format("{0:0.00}%", perc_1_aux);
            stats.Rows[0].SetField("Frequency", freq_1);
            stats.Rows[0].SetField("Percent", perc_1);
        }

        private void calculatePerc2(int dice1, int dice2, int dice3, int dice4, int dice5, int dice6, int dice7, int dice8, int dice9, int dice10, int dice11, int dice12)
        {
            if (dice1 == 2)
            {
                dice1img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice2 == 2)
            {
                dice2img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice3 == 2)
            {
                dice3img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice4 == 2)
            {
                dice4img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice5 == 2)
            {
                dice5img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice6 == 2)
            {
                dice6img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice7 == 2)
            {
                dice7img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice8 == 2)
            {
                dice8img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice9 == 2)
            {
                dice9img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice10 == 2)
            {
                dice10img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice11 == 2)
            {
                dice11img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }
            if (dice12 == 2)
            {
                dice12img.BackgroundImage = Resources.dice_2;
                freq_2++;
            }

            perc_2_aux = (freq_2 / total) * 100;
            perc_2 = String.Format("{0:0.00}%", perc_2_aux);
            stats.Rows[1].SetField("Frequency", freq_2);
            stats.Rows[1].SetField("Percent", perc_2);
        }

        private void calculatePerc3(int dice1, int dice2, int dice3, int dice4, int dice5, int dice6, int dice7, int dice8, int dice9, int dice10, int dice11, int dice12)
        {
            if (dice1 == 3)
            {
                dice1img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice2 == 3)
            {
                dice2img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice3 == 3)
            {
                dice3img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice4 == 3)
            {
                dice4img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice5 == 3)
            {
                dice5img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice6 == 3)
            {
                dice6img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice7 == 3)
            {
                dice7img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice8 == 3)
            {
                dice8img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice9 == 3)
            {
                dice9img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice10 == 3)
            {
                dice10img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice11 == 3)
            {
                dice11img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }
            if (dice12 == 3)
            {
                dice12img.BackgroundImage = Resources.dice_3;
                freq_3++;
            }

            perc_3_aux = (freq_3 / total) * 100;
            perc_3 = String.Format("{0:0.00}%", perc_3_aux);
            stats.Rows[2].SetField("Frequency", freq_3);
            stats.Rows[2].SetField("Percent", perc_3);
        }

        private void calculatePerc4(int dice1, int dice2, int dice3, int dice4, int dice5, int dice6, int dice7, int dice8, int dice9, int dice10, int dice11, int dice12)
        {
            if (dice1 == 4)
            {
                dice1img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice2 == 4)
            {
                dice2img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice3 == 4)
            {
                dice3img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice4 == 4)
            {
                dice4img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice5 == 4)
            {
                dice5img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice6 == 4)
            {
                dice6img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice7 == 4)
            {
                dice7img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice8 == 4)
            {
                dice8img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice9 == 4)
            {
                dice9img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice10 == 4)
            {
                dice10img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice11 == 4)
            {
                dice11img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }
            if (dice12 == 4)
            {
                dice12img.BackgroundImage = Resources.dice_4;
                freq_4++;
            }

            perc_4_aux = (freq_4 / total) * 100;
            perc_4 = String.Format("{0:0.00}%", perc_4_aux);
            stats.Rows[3].SetField("Frequency", freq_4);
            stats.Rows[3].SetField("Percent", perc_4);
        }

        private void calculatePerc5(int dice1, int dice2, int dice3, int dice4, int dice5, int dice6, int dice7, int dice8, int dice9, int dice10, int dice11, int dice12)
        {
            if (dice1 == 5)
            {
                dice1img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice2 == 5)
            {
                dice2img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice3 == 5)
            {
                dice3img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice4 == 5)
            {
                dice4img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice5 == 5)
            {
                dice5img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice6 == 5)
            {
                dice6img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice7 == 5)
            {
                dice7img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice8 == 5)
            {
                dice8img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice9 == 5)
            {
                dice9img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice10 == 5)
            {
                dice10img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice11 == 5)
            {
                dice11img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }
            if (dice12 == 5)
            {
                dice12img.BackgroundImage = Resources.dice_5;
                freq_5++;
            }

            perc_5_aux = (freq_5 / total) * 100;
            perc_5 = String.Format("{0:0.00}%", perc_5_aux);
            stats.Rows[4].SetField("Frequency", freq_5);
            stats.Rows[4].SetField("Percent", perc_5);
        }

        private void calculatePerc6(int dice1, int dice2, int dice3, int dice4, int dice5, int dice6, int dice7, int dice8, int dice9, int dice10, int dice11, int dice12)
        {
            if (dice1 == 6)
            {
                dice1img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice2 == 6)
            {
                dice2img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice3 == 6)
            {
                dice3img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice4 == 6)
            {
                dice4img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice5 == 6)
            {
                dice5img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice6 == 6)
            {
                dice6img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice7 == 6)
            {
                dice7img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice8 == 6)
            {
                dice8img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice9 == 6)
            {
                dice9img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice10 == 6)
            {
                dice10img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice11 == 6)
            {
                dice11img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }
            if (dice12 == 6)
            {
                dice12img.BackgroundImage = Resources.dice_6;
                freq_6++;
            }

            perc_6_aux = (freq_6 / total) * 100;
            perc_6 = String.Format("{0:0.00}%", perc_6_aux);
            stats.Rows[5].SetField("Frequency", freq_6);
            stats.Rows[5].SetField("Percent", perc_6);
        }

        private void roll_Click(object sender, EventArgs e)
        {
            int dice1 = random.Next(1, 7); int dice7 = random.Next(1, 7);
            int dice2 = random.Next(1, 7); int dice8 = random.Next(1, 7);
            int dice3 = random.Next(1, 7); int dice9 = random.Next(1, 7);
            int dice4 = random.Next(1, 7); int dice10 = random.Next(1, 7);
            int dice5 = random.Next(1, 7); int dice11 = random.Next(1, 7);
            int dice6 = random.Next(1, 7); int dice12 = random.Next(1, 7);

            //incrementa sempre que for pressionado o botão
            total = total + 12;

            calculatePerc1(dice1, dice2, dice3, dice4, dice5, dice6, dice7, dice8, dice9, dice10, dice11, dice12);
            calculatePerc2(dice1, dice2, dice3, dice4, dice5, dice6, dice7, dice8, dice9, dice10, dice11, dice12);
            calculatePerc3(dice1, dice2, dice3, dice4, dice5, dice6, dice7, dice8, dice9, dice10, dice11, dice12);
            calculatePerc4(dice1, dice2, dice3, dice4, dice5, dice6, dice7, dice8, dice9, dice10, dice11, dice12);
            calculatePerc5(dice1, dice2, dice3, dice4, dice5, dice6, dice7, dice8, dice9, dice10, dice11, dice12);
            calculatePerc6(dice1, dice2, dice3, dice4, dice5, dice6, dice7, dice8, dice9, dice10, dice11, dice12);
        }
    }
}
