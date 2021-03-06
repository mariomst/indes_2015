﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

                Box1.Text = box1_number.ToString();
                Box2.Text = box2_number.ToString();
                Box3.Text = box3_number.ToString();

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
