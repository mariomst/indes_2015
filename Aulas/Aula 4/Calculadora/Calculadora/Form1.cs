using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class formCalc : Form
    {
        string  input        = string.Empty;
        string  operand1     = string.Empty;
        string  operand2     = string.Empty;
        char    operation;
        double  result       = 0.0;

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

        /*
        *   Ação para o botão 0
        */
        private void button0_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                input += "0";
                labelScreen.Text = input;
            }
        }

        /*
        *   Ação para o botão 1
        */
        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            labelScreen.Text = input;
        }

        /*
        *   Ação para o botão 2
        */
        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            labelScreen.Text = input;
        }

        /*
        *   Ação para o botão 3
        */
        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
            labelScreen.Text = input;
        }

        /*
        *   Ação para o botão 4
        */
        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
            labelScreen.Text = input;
        }

        /*
        *   Ação para o botão 5
        */
        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            labelScreen.Text = input;
        }

        /*
        *   Ação para o botão 6
        */
        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
            labelScreen.Text = input;
        }

        /*
        *   Ação para o botão 7
        */
        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
            labelScreen.Text = input;
        }

        /*
        *   Ação para o botão 8
        */
        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            labelScreen.Text = input;
        }

        /*
        *   Ação para o botão 9
        */
        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            labelScreen.Text = input;
        }

        /*
        *   Ação para o botão .
        */
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

        /*
        *   Ação para o botão BackSpace
        */
        private void buttonBS_Click(object sender, EventArgs e)
        {
            if(input.Length > 0)
            {
                string removeLast = input.Substring(0, input.Length - 1);
                input = removeLast;
                labelScreen.Text = input;
            }
            if(input.Length == 0)
            {
                input = "";
                labelScreen.Text = "0";
            }            
        }

        /*
        *   Ação para o botão CE
        */
        private void buttonCE_Click(object sender, EventArgs e)
        {            
            input         = string.Empty;
            operand1      = string.Empty;
            operand2      = string.Empty;
            result        = 0.0;
        }

        /*
        *   Ação para o botão C
        */
        private void buttonC_Click(object sender, EventArgs e)
        {
            labelOperations.Text    = "";
            input                   = string.Empty;
            operand1                = string.Empty;
            operand2                = string.Empty;
            labelScreen.Text        = "0";
        }

        /*
        *   Ação para o botão +/-
        */
        private void buttonPN_Click(object sender, EventArgs e)
        {
            if(input != "0" && input != "")
            {
                if(input.Contains("-"))
                {
                    input = input.Substring(1);
                    labelScreen.Text = input;
                }
                else
                {
                    input = "-" + input;
                    labelScreen.Text = input;
                }
            }            
        }

        /*
        *   Ação para o botão /
        */
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            labelOperations.Text    = input + " / ";
            labelScreen.Text        = "0";
            operand1                = input;
            operation               = '/';            
            input                   = string.Empty;
        }

        /*
        *   Ação para o botão *
        */
        private void buttonMult_Click(object sender, EventArgs e)
        {
            labelOperations.Text    = input + " * ";
            labelScreen.Text        = "0";
            operand1                = input;
            operation               = '*';
            input                   = string.Empty;
        }

        /*
        *   Ação para o botão -
        */
        private void buttonMin_Click(object sender, EventArgs e)
        {
            labelOperations.Text    = input + " - ";
            labelScreen.Text        = "0";
            operand1                = input;
            operation               = '-';
            input                   = string.Empty;
        }

        /*
        *   Ação para o botão +
        */
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            labelOperations.Text    = input + " + ";
            labelScreen.Text        = "0";
            operand1                = input;
            operation               = '+';
            input                   = string.Empty;
        }

        /*
        *   Ação para o botão 1/x
        */
        private void buttonRat_Click(object sender, EventArgs e)
        {
            double num;

            if(result != 0)
            {
                labelOperations.Text = "(1 / " + result + ")";
                num  = result;
            }
            else
            {
                labelOperations.Text = "(1 / " + input + ")";
                operand1 = input;
                input = string.Empty;

                double.TryParse(operand1, out num);
            }            

            if(num != 0)
            {
                result = (1 / num);
                labelScreen.Text = result.ToString("#0.000");
            }
            else
            {
                labelScreen.Text = "Division by Zero!!!";
            }
        }

        /*
        *   Ação para o botão sqrt
        */
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if(result != 0)
            {
                labelOperations.Text = "sqrt(" + result + ")";
                result = Math.Sqrt(result);
            }
            else
            {
                labelOperations.Text = "sqrt(" + input + ")";
                operand1 = input;
                input = string.Empty;

                double num;
                double.TryParse(operand1, out num);

                result = Math.Sqrt(num);
            }           
           
            labelScreen.Text = result.ToString("#0.000");
        }

        /*
        *   Ação para o botão =
        */
        private void buttonRes_Click(object sender, EventArgs e)
        {
            operand2 = input;

            double num1, num2;          
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            labelOperations.Text = operand1 + " " + operation + " " + operand2;

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
