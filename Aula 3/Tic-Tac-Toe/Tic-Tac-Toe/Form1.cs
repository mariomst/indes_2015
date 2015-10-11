using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class formTicTacToe : Form
    {
        int[,] boardMatrix  = new int[3, 3];
        int playerTurn      = 0;

        public formTicTacToe()
        {
            InitializeComponent();
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
            Application.Exit();
        }

        /*
        *   Inicia um novo jogo
        */
        private void buttonNG_Click(object sender, EventArgs e)
        {
            playerTurn = 0;

            // Limpar as caixas
            box1.BackgroundImage = null; box4.BackgroundImage = null; box7.BackgroundImage = null;
            box2.BackgroundImage = null; box5.BackgroundImage = null; box8.BackgroundImage = null;
            box3.BackgroundImage = null; box6.BackgroundImage = null; box9.BackgroundImage = null;

            // Ativar as caixas
            box1.Enabled = true;    box4.Enabled = true;    box7.Enabled = true;
            box2.Enabled = true;    box5.Enabled = true;    box8.Enabled = true;
            box3.Enabled = true;    box6.Enabled = true;    box9.Enabled = true;

            // Limpar a matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardMatrix[i, j] = 0;
                }
            }

            faceBox.BackgroundImage = Resources.face1;

            textStatus.Text = "";
        }

        /*
        *   Termina a aplicação
        */
        private void buttonQ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
        *   Define na caixa a imagem X ou a imagem O
        */
        private void setPlay(PictureBox box)
        {
            if (playerTurn == 0)
            {
                box.BackgroundImage = Resources.cross;
                box.Enabled = false;
            }
            else
            {
                box.BackgroundImage = Resources.circle;
                box.Enabled = false;
            }
        }

        /*
        *   Função para inserir os valores na matriz, esta matriz depois vai ser usada para verificações
        */
        private void setMatrixValues(int posX, int posY)
        {
            if(playerTurn == 0)
            {
                boardMatrix[posX, posY] = 1;
            }
            if (playerTurn == 1)
            {
                boardMatrix[posX, posY] = 2;
            }
        }

        /*
        *   Função auxiliar para inserir a jogada do computador no ecrã
        */
        private void setBoxPicked(int posX, int posY)
        {
            if (posX == 0 && posY == 0)
            {
                setPlay(box1);
            }
            if (posX == 0 && posY == 1)
            {
                setPlay(box2);
            }
            if (posX == 0 && posY == 2)
            {
                setPlay(box3);
            }
            if (posX == 1 && posY == 0)
            {
                setPlay(box4);
            }
            if (posX == 1 && posY == 1)
            {
                setPlay(box5);
            }
            if (posX == 1 && posY == 2)
            {
                setPlay(box6);
            }
            if (posX == 2 && posY == 0)
            {
                setPlay(box7);
            }
            if (posX == 2 && posY == 1)
            {
                setPlay(box8);
            }
            if (posX == 2 && posY == 2)
            {
                setPlay(box9);
            }
        }

        /*
        *   Função para executar a jogada do computador
        */
        private void computerPlay()
        {            
            Random random   = new Random();

            int flag        = 0;
            int rMin        = 0;
            int rMax        = 3;

            do
            {
                int posX = random.Next(rMin, rMax);
                int posY = random.Next(rMin, rMax);

                //Verifica se essa posição esta disponível
                if (boardMatrix[posX, posY] == 0)
                {
                    setMatrixValues(posX, posY);
                    setBoxPicked(posX, posY);
                    flag = 1;
                }
                else
                {
                    Console.WriteLine("oops");
                }

                Console.WriteLine("posX: " + posX + " posY: " + posY);
                

            } while (flag == 0);

            changeTurn();
        }

        /*
        *   Função para verificar se todos os campos da matriz estão preenchidos
        */
        private void checkNrPlaysRemaining()
        {
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(boardMatrix[i,j] == 0)
                    {
                        count++;
                    }
                }               
            }

            Console.WriteLine(count);

            if (count > 0)
            {
                changeTurn();
            }
            else
            {
                endGame(false, 0);
            }
        }

        /*
        *   Função para verificar se existe um vencedor
        */
        private void checkWinner(int player)
        {
            bool winnerExists = false;

            if(boardMatrix[0,0] == player && boardMatrix[0, 1] == player && boardMatrix[0, 2] == player)
            {
                winnerExists = true;
            }
            if (boardMatrix[1, 0] == player && boardMatrix[1, 1] == player && boardMatrix[1, 2] == player)
            {
                winnerExists = true;
            }
            if (boardMatrix[2, 0] == player && boardMatrix[2, 1] == player && boardMatrix[2, 2] == player)
            {
                winnerExists = true;
            }            
            if (boardMatrix[0, 0] == player && boardMatrix[1, 0] == player && boardMatrix[2, 0] == player)
            {
                winnerExists = true;
            }
            if (boardMatrix[0, 1] == player && boardMatrix[1, 1] == player && boardMatrix[2, 1] == player)
            {
                winnerExists = true;
            }
            if (boardMatrix[0, 2] == player && boardMatrix[1, 2] == player && boardMatrix[2, 2] == player)
            {
                winnerExists = true;
            }
            if (boardMatrix[0, 0] == player && boardMatrix[1, 1] == player && boardMatrix[2, 2] == player)
            {
                winnerExists = true;
            }
            if (boardMatrix[0, 2] == player && boardMatrix[1, 1] == player && boardMatrix[2, 0] == player)
            {
                winnerExists = true;
            }

            if (winnerExists == true)
            {
                endGame(winnerExists, player);
            }
        }

        /*
        *   Função para terminar o jogo caso de vitória de um dos jogadores ou empate
        */
        private void endGame(bool winnerExists, int player)
        {
            // Em caso de empate
            if(winnerExists == false)
            {
                faceBox.BackgroundImage = Resources.face2;
                textStatus.Text = "EVERYONE LOSES!!!";
            }
            else if(winnerExists == true && player == 1)
            {
                faceBox.BackgroundImage = Resources.face2;
                textStatus.Text = "YOU WIN!!!";
                endGameBlock();
            }
            else if (winnerExists == true && player == 2)
            {
                faceBox.BackgroundImage = Resources.face3;
                textStatus.Text = "YOU LOOSE!!!";
                endGameBlock();
            }
        }

        /*
        *   Função para desativar todas as caixas caso existe um vencedor
        */
        private void endGameBlock()
        {
            // Desativar as caixas
            box1.Enabled = false; box4.Enabled = false; box7.Enabled = false;
            box2.Enabled = false; box5.Enabled = false; box8.Enabled = false;
            box3.Enabled = false; box6.Enabled = false; box9.Enabled = false;
        }
        
        /*
        *   Função para indicar qual é o jogador a jogar.
        */
        private void changeTurn()
        {
            if(playerTurn == 0)
            {
                playerTurn = 1; //computador
                checkWinner(1);
                computerPlay();
            }  
            else
            {
                playerTurn = 0;
                checkWinner(2);
            }          
        }

        /*
        *   Funções para cada uma das caixas na mesa
        */
        private void box1_Click(object sender, EventArgs e)
        {
            setPlay(box1);
            setMatrixValues(0, 0);            
            checkNrPlaysRemaining();
        }

        private void box2_Click(object sender, EventArgs e)
        {
            setPlay(box2);
            setMatrixValues(0, 1);            
            checkNrPlaysRemaining();
        }

        private void box3_Click(object sender, EventArgs e)
        {
            setPlay(box3);
            setMatrixValues(0, 2);           
            checkNrPlaysRemaining();
        }

        private void box4_Click(object sender, EventArgs e)
        {
            setPlay(box4);
            setMatrixValues(1, 0);
            checkNrPlaysRemaining();
        }

        private void box5_Click(object sender, EventArgs e)
        {
            setPlay(box5);
            setMatrixValues(1, 1);
            checkNrPlaysRemaining();
        }

        private void box6_Click(object sender, EventArgs e)
        {
            setPlay(box6);
            setMatrixValues(1, 2);
            checkNrPlaysRemaining();
        }

        private void box7_Click(object sender, EventArgs e)
        {
            setPlay(box7);
            setMatrixValues(2, 0);
            checkNrPlaysRemaining();
        }

        private void box8_Click(object sender, EventArgs e)
        {
            setPlay(box8);
            setMatrixValues(2, 1);
            checkNrPlaysRemaining();
        }

        private void box9_Click(object sender, EventArgs e)
        {
            setPlay(box9);
            setMatrixValues(2, 2);
            checkNrPlaysRemaining();
        }

        /*
        *   Apenas para efeitos de teste
        */
        private void consoleOutput()
        {
            Console.WriteLine("Info: Printing the values on the matrix");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("["+i+"]["+j+"] = " + boardMatrix[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
