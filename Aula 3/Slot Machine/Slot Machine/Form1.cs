using Slot_Machine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine
{
    public partial class SlotMachine : Form
    {
        int saldo = 20; //Saldo inicial

        public SlotMachine()
        {
            InitializeComponent();
            saldoValor.Text = saldo.ToString();           
        }        

        /*
        *   Função para associar o numero gerado aleatóriamente a uma imagem.
        */
        private void setBoxImage(int boxNumber, PictureBox box)
        {   
            if (boxNumber == 1)
            {
                box.BackgroundImage = Resources.apple;
                box.Refresh();
            }
            if (boxNumber == 2)
            {
                box.BackgroundImage = Resources.bananas;
                box.Refresh();
            }
            if (boxNumber == 3)
            {
                box.BackgroundImage = Resources.cherry;
                box.Refresh();
            }
            if (boxNumber == 4)
            {
                box.BackgroundImage = Resources.grapes;
                box.Refresh();
            }
            if (boxNumber == 5)
            {
                box.BackgroundImage = Resources.pear;
                box.Refresh();
            }
            if (boxNumber == 6)
            {
                box.BackgroundImage = Resources.watermelon;
                box.Refresh();
            }
            if (boxNumber == 7)
            {
                box.BackgroundImage = Resources.orange;
                box.Refresh();
            }
            if (boxNumber == 8)
            {
                box.BackgroundImage = Resources.strawberry;
                box.Refresh();
            }
        }

        /*
        *   Função para gerar imagens aleatóriamente com um efeito 
        */
        private void randomImageEffect()
        {
            Random random   = new Random();
            Stopwatch sw    = new Stopwatch();

            int rand1_number = 0;
            int rand2_number = 0;
            int rand3_number = 0;

            //Quando é feito uma jogada o botão fica desativo até o evento do stopwatch terminar.
            button1.Enabled = false;
            sw.Start();
            while (sw.Elapsed < TimeSpan.FromSeconds(2))
            {
                //Gera 3 números aleatórios
                rand1_number = random.Next(1, 8);
                rand2_number = random.Next(1, 8);
                rand3_number = random.Next(1, 8);

                //Para a alternação de imagens não ser tão rápida
                System.Threading.Thread.Sleep(100);

                //Muda as imageBoxes com imagens aleatórias
                setBoxImage(rand1_number, Box1);
                setBoxImage(rand2_number, Box2);
                setBoxImage(rand3_number, Box3);
            }
            sw.Stop();
            button1.Enabled = true;          
        }

        /*
        *   Função para verificar o resultado da aposta
        */
        private void gameResult(int aposta, int box1_number, int box2_number, int box3_number)
        {
            if (box1_number == 7 && box2_number == 7 && box3_number == 7)    //aposta decuplicada
            {
                aposta = aposta * 10;
                saldo = saldo + aposta;
                result.Text = "Parabéns! Ganhou Jackpot.";
            }
            else if (box1_number != box2_number && box1_number != box3_number && box2_number != box3_number)
            {
                aposta = aposta * 5;
                saldo = saldo + aposta;
                result.Text = "Parabéns! Aposta quintuplicada.";
            }
            else if ((box1_number == 7 && box2_number == 7) || (box1_number == 7 && box3_number == 7) || (box2_number == 7 && box3_number == 7))  //aposta triplicada
            {
                aposta = aposta * 3;
                saldo = saldo + aposta;
                result.Text = "Parabéns! Aposta triplicada.";
            }
            else if (box1_number == 7 || box2_number == 7 || box3_number == 7)  //aposta dobrada
            {
                aposta = aposta * 2;
                saldo = saldo + aposta;
                result.Text = "Parabéns! Aposta dobrada.";
            }            

            saldoValor.Text = saldo.ToString(); //atualiza o valor do saldo
        }
        
        /*
        *   Instruções a executar quando o botão "Play" é pressionado
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Random random   = new Random();            
            int aposta      = (int)apostaBox.Value;  //Obter valor da aposta            

            result.Text = "";   //Limpa a caixa de texto do resultado

            if (aposta > 0 && aposta <= saldo) //Apenas é aceite a aposta se o valor for menor ou igual ao saldo
            {
                saldo = saldo - aposta; //retira o valor da aposta ao saldo

                //Gera três números aleatóriamente
                int box1_number = random.Next(1, 8);
                int box2_number = random.Next(1, 8);
                int box3_number = random.Next(1, 8);

                //Para o efeito de rotação é gerado imagens aleatórias
                randomImageEffect();               

                //Define uma imagem conforme o número gerado
                setBoxImage(box1_number, Box1);
                setBoxImage(box2_number, Box2);
                setBoxImage(box3_number, Box3);

                gameResult(aposta, box1_number, box2_number, box3_number);
            }
            else
            {
                if (aposta == 0)
                {
                    result.Text = "A aposta tem que ser maior que 0.";
                }
                else
                {
                    result.Text = "Não tem saldo suficiente para jogar.";
                }                
            }         
        }
        
        /*
        *   Ecrã sobre
        */
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();

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
