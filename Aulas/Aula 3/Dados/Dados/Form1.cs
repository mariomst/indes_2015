using Dados.Properties;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Dados
{
    public partial class formDados : Form
    {
        DataTable   stats   = new DataTable("Stats");
        Stopwatch   sw      = new Stopwatch();
        Random      random  = new Random();

        int freq_1 = 0; String perc_1 = "0.00"; double perc_1_aux = 0;
        int freq_2 = 0; String perc_2 = "0.00"; double perc_2_aux = 0;
        int freq_3 = 0; String perc_3 = "0.00"; double perc_3_aux = 0;
        int freq_4 = 0; String perc_4 = "0.00"; double perc_4_aux = 0;
        int freq_5 = 0; String perc_5 = "0.00"; double perc_5_aux = 0;
        int freq_6 = 0; String perc_6 = "0.00"; double perc_6_aux = 0;
        double total = 0;

        public formDados()
        {
            InitializeComponent();
            CreateDataTable();
        }

        /*
        *   Função para criar uma tabela para armazenar os dados da frequência e percentagem de cada face
        *   @version    1.0
        */
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

        /*
        *   Função para criar um efeito de dados rolar
        *   @version    1.0
        */
        private void randomRollEffect()
        {            
            int rand_dice1 = 0; int rand_dice7  = 0;
            int rand_dice2 = 0; int rand_dice8  = 0;
            int rand_dice3 = 0; int rand_dice9  = 0;
            int rand_dice4 = 0; int rand_dice10 = 0;
            int rand_dice5 = 0; int rand_dice11 = 0;
            int rand_dice6 = 0; int rand_dice12 = 0;

            //Quando é feito uma jogada o botão fica desativo até o evento do stopwatch terminar.
            roll.Enabled = false;
            sw.Start();
            while (sw.Elapsed < TimeSpan.FromSeconds(2))
            {
                //Gera faces aleatóriass
                rand_dice1 = random.Next(1, 7); rand_dice7  = random.Next(1, 7);
                rand_dice2 = random.Next(1, 7); rand_dice8  = random.Next(1, 7);
                rand_dice3 = random.Next(1, 7); rand_dice9  = random.Next(1, 7);
                rand_dice4 = random.Next(1, 7); rand_dice10 = random.Next(1, 7);
                rand_dice5 = random.Next(1, 7); rand_dice11 = random.Next(1, 7);
                rand_dice6 = random.Next(1, 7); rand_dice12 = random.Next(1, 7);

                //Para a alternação de imagens não ser tão rápida
                System.Threading.Thread.Sleep(50);

                //Muda as imageBoxes com imagens aleatórias
                setDiceFaceImage(dice1img, rand_dice1); setDiceFaceImage(dice7img, rand_dice7);
                setDiceFaceImage(dice2img, rand_dice2); setDiceFaceImage(dice8img, rand_dice8);
                setDiceFaceImage(dice3img, rand_dice3); setDiceFaceImage(dice9img, rand_dice9);
                setDiceFaceImage(dice4img, rand_dice4); setDiceFaceImage(dice10img, rand_dice10);
                setDiceFaceImage(dice5img, rand_dice5); setDiceFaceImage(dice11img, rand_dice11);
                setDiceFaceImage(dice6img, rand_dice6); setDiceFaceImage(dice12img, rand_dice12);

            }
            sw.Stop();
            sw.Reset();
            roll.Enabled = true;
        }

        /*
        *   Função para definir a imagem da face no dado
        *   @param      PictureBox      dice    Indicação de qual Dado deve ser atualizado com a face
        *   @param      int             face    A face que saiu quando foi pressionado o botão "roll"
        *   @version    1.0
        */
        private void setDiceFaceImage(PictureBox dice, int face)
        {
            if(face == 1)
            {
                dice.BackgroundImage = Resources.dice_1;
                dice.Refresh();
            }
            if (face == 2)
            {
                dice.BackgroundImage = Resources.dice_2;
                dice.Refresh();
            }
            if (face == 3)
            {
                dice.BackgroundImage = Resources.dice_3;
                dice.Refresh();
            }
            if (face == 4)
            {
                dice.BackgroundImage = Resources.dice_4;
                dice.Refresh();
            }
            if (face == 5)
            {
                dice.BackgroundImage = Resources.dice_5;
                dice.Refresh();
            }
            if (face == 6)
            {
                dice.BackgroundImage = Resources.dice_6;
                dice.Refresh();
            }
        }
        
        /*
        *   Função para somar a quantidade de vezes que saiu uma determinada face
        *   @param      int             face    A face que saiu quando foi pressionado o botão "roll"
        *   @version    1.0
        */
        private void calculateQuantity(int face)
        {
            if (face == 1)
            {
                freq_1++;
            }
            if (face == 2)
            {
                freq_2++;
            }
            if (face == 3)
            {
                freq_3++;
            }
            if (face == 4)
            {
                freq_4++;
            }
            if (face == 5)
            {
                freq_5++;
            }
            if (face == 6)
            {
                freq_6++;
            }
        }

        /*
        *   Função para calcular a percentagem de cada face.
        *   @param      int            face    A face que saiu quando foi pressionado o botão "roll"
        *   @version    1.0
        */
        private void calculatePercentage(int face)
        {
            if(face == 1)
            {
                perc_1_aux = (freq_1 / total) * 100;
                perc_1 = String.Format("{0:0.00}%", perc_1_aux);
                stats.Rows[0].SetField("Frequency", freq_1);
                stats.Rows[0].SetField("Percent", perc_1);
            }
            if(face == 2)
            {
                perc_2_aux = (freq_2 / total) * 100;
                perc_2 = String.Format("{0:0.00}%", perc_2_aux);
                stats.Rows[1].SetField("Frequency", freq_2);
                stats.Rows[1].SetField("Percent", perc_2);
            }
            if(face == 3)
            {
                perc_3_aux = (freq_3 / total) * 100;
                perc_3 = String.Format("{0:0.00}%", perc_3_aux);
                stats.Rows[2].SetField("Frequency", freq_3);
                stats.Rows[2].SetField("Percent", perc_3);
            }
            if(face == 4)
            {
                perc_4_aux = (freq_4 / total) * 100;
                perc_4 = String.Format("{0:0.00}%", perc_4_aux);
                stats.Rows[3].SetField("Frequency", freq_4);
                stats.Rows[3].SetField("Percent", perc_4);
            }
            if(face == 5)
            {
                perc_5_aux = (freq_5 / total) * 100;
                perc_5 = String.Format("{0:0.00}%", perc_5_aux);
                stats.Rows[4].SetField("Frequency", freq_5);
                stats.Rows[4].SetField("Percent", perc_5);
            }
            if(face == 6)
            {
                perc_6_aux = (freq_6 / total) * 100;
                perc_6 = String.Format("{0:0.00}%", perc_6_aux);
                stats.Rows[5].SetField("Frequency", freq_6);
                stats.Rows[5].SetField("Percent", perc_6);
            }
        }
        
        /*
        *   Evento quando é pressionado o botão roll
        */
        private void roll_Click(object sender, EventArgs e)
        {
            int dice1 = random.Next(1, 7); int dice7  = random.Next(1, 7);
            int dice2 = random.Next(1, 7); int dice8  = random.Next(1, 7);
            int dice3 = random.Next(1, 7); int dice9  = random.Next(1, 7);
            int dice4 = random.Next(1, 7); int dice10 = random.Next(1, 7);
            int dice5 = random.Next(1, 7); int dice11 = random.Next(1, 7);
            int dice6 = random.Next(1, 7); int dice12 = random.Next(1, 7);

            // Incrementa sempre que for pressionado o botão
            total = total + 12;

            // Efeito de dados a rolar
            randomRollEffect();

            // Define a face para cada dado
            setDiceFaceImage(dice1img, dice1); setDiceFaceImage(dice7img, dice7);
            setDiceFaceImage(dice2img, dice2); setDiceFaceImage(dice8img, dice8);
            setDiceFaceImage(dice3img, dice3); setDiceFaceImage(dice9img, dice9);
            setDiceFaceImage(dice4img, dice4); setDiceFaceImage(dice10img, dice10);
            setDiceFaceImage(dice5img, dice5); setDiceFaceImage(dice11img, dice11);
            setDiceFaceImage(dice6img, dice6); setDiceFaceImage(dice12img, dice12);

            // Calcular a quantidade de vezes que saiu cada face em cada dado
            calculateQuantity(dice1);   calculateQuantity(dice7);
            calculateQuantity(dice2);   calculateQuantity(dice8);
            calculateQuantity(dice3);   calculateQuantity(dice9);
            calculateQuantity(dice4);   calculateQuantity(dice10);
            calculateQuantity(dice5);   calculateQuantity(dice11);
            calculateQuantity(dice6);   calculateQuantity(dice12);

            // Calcular a quantidade de vezes que saiu cada face em cada dado
            for(int i = 0; i < 6; i++)
            {
                calculatePercentage((i+1));
            }
        }

        /*
        *   Ecrã about
        */
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            formAbout about = new formAbout();

            about.Show();
        }

        /*
        *   Termina a aplicação
        */
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            //Terminar aplicação
            Application.Exit();
        }
    }
}
