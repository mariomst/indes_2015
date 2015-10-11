using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class formCalc : Form
    {
        string  input        = string.Empty;
        string  operand1     = string.Empty;
        string  operand2     = string.Empty;
        char    operation;
        double result        = 0.0;

        public formCalc()
        {
            InitializeComponent();
        }

        /*
        *   Função para abrir o form about
        */
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            formAbout about = new formAbout();
            about.Show();
        }

        /*
        *   Função para fechar a aplicação
        */
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                input += "0";
                labelScreen.Text = input;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            labelScreen.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            labelScreen.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
            labelScreen.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
            labelScreen.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            labelScreen.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
            labelScreen.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
            labelScreen.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            labelScreen.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            labelScreen.Text = input;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                input += "0.";
            }
            else
            {
                input += ".";
            }
            labelScreen.Text = input;
        }

        private void buttonBS_Click(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }

        private void buttonPN_Click(object sender, EventArgs e)
        {

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operand1    = input;
            operation   = '+';
            input       = string.Empty;
        }

        private void buttonRat_Click(object sender, EventArgs e)
        {

        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            operand2 = input;

            double num1, num2;          
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                labelScreen.Text = result.ToString("#0.0");
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                labelScreen.Text = result.ToString("#0.0");
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                labelScreen.Text = result.ToString("#0.0");
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    labelScreen.Text = result.ToString("#0.0");
                }
                else
                {
                    labelScreen.Text = "Division by Zero!!!";
                }
            }
        }
    }
}
