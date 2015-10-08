using Slot_Machine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        *   Função para gerar imagens aleatóriamente com um efeito 
        */
        private void randomImageEffect()
        {
            Random random = new Random();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.Elapsed < TimeSpan.FromSeconds(5))
            {
                var rand_number1 = random.Next(0, 9);
                var rand_number2 = random.Next(0, 9);
                var rand_number3 = random.Next(0, 9);
                setBoxImage(rand_number1, Box1);
                setBoxImage(rand_number2, Box2);
                setBoxImage(rand_number3, Box3);
            }
            sw.Stop();
        }

        /*
        *   Função para associar o numero gerado aleatóriamente a uma imagem.
        */
        private void setBoxImage(int boxNumber, PictureBox box)
        {
            Console.WriteLine(boxNumber);
            if(boxNumber == 1)
            {
                box.BackgroundImage = Resources.apple;
            }
            if (boxNumber == 2)
            {
                box.BackgroundImage = Resources.cherry;
            }
            if (boxNumber == 3)
            {
                box.BackgroundImage = Resources.banana;
            }
            if (boxNumber == 4)
            {
                box.BackgroundImage = Resources.grapes;
            }
            if (boxNumber == 5)
            {
                box.BackgroundImage = Resources.lemon;
            }
            if (boxNumber == 6)
            {
                box.BackgroundImage = Resources.melon;
            }
            if (boxNumber == 7)
            {
                box.BackgroundImage = Resources.orange; //vence
            }
            if (boxNumber == 8)
            {
                box.BackgroundImage = Resources.apple;
            }
            if (boxNumber == 9)
            {
                box.BackgroundImage = Resources.cherry;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int aposta = (int)apostaBox.Value;  //Obter valor da aposta

            result.Text = "";   //Limpa a caixa de texto do resultado

            if (aposta > 0 && aposta <= saldo) //Apenas é aceite a aposta se o valor for menor ou igual ao saldo
            {
                saldo = saldo - aposta; //retira o valor da aposta ao saldo

                //gera tres numeros aleatóriamente
                var box1_number = random.Next(0, 9);
                var box2_number = random.Next(0, 9);
                var box3_number = random.Next(0, 9);

                randomImageEffect();

                setBoxImage(box1_number, Box1);
                setBoxImage(box2_number, Box2);
                setBoxImage(box3_number, Box3);

                if (box1_number == 7 && box2_number == 7 && box3_number == 7)    //aposta decuplicada
                {
                    aposta = aposta * 10;
                    saldo = saldo + aposta;
                    result.Text = "Parabéns! Ganhou Jackpot.";
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
    }
}
