using System;
using System.Windows.Forms;

namespace INDES_T3
{
    public partial class Score : Form
    {
        //HFS: Variável a ser usado no New Game
        int getDifficulty;

        //MST: Variáveis a serem usadas no Send Data
        int    sendPlayerHits   = 0;
        int    sendPlayerMisses = 0;
        float  sendPlayerHPerc  = 0;
        string sendWinner       = "";

        public Score(int playerHits, int playerMisses, float playerHPerc, int computerHits, int computerMisses, 
                        float computerHPerc, string winner, int difficulty)
        {
            InitializeComponent();

            getDifficulty = difficulty;

            sendPlayerHits = playerHits;
            sendPlayerMisses = playerMisses;
            sendPlayerHPerc = playerHPerc;
            sendWinner = winner;

            //HFS:Calcula todos os scores

            //HFS: Calculo de scores de jogador
            int[] pHits   = calculateHitsMisses(playerHits);
            int[] pMisses = calculateHitsMisses(playerMisses);
            int[] pPerc   = calculateHitsMisses((int)playerHPerc);
            hitsp1.Text   = pHits[0].ToString();
            hitsp2.Text   = pHits[1].ToString();
            hitsp3.Text   = pHits[2].ToString();
            missesp1.Text = pMisses[0].ToString();
            missesp2.Text = pMisses[1].ToString();
            missesp3.Text = pMisses[2].ToString();
            hpp1.Text     = pPerc[0].ToString();
            hpp2.Text     = pPerc[1].ToString();
            hpp3.Text     = pPerc[2].ToString();

            //HFS: Calculo de scores do PC
            int[] cpuHits   = calculateHitsMisses(computerHits);
            int[] cpuMisses = calculateHitsMisses(computerMisses);
            int[] cpuPerc   = calculateHitsMisses((int)computerHPerc);
            hitsc1.Text     = cpuHits[0].ToString();
            hitsc2.Text     = cpuHits[1].ToString();
            hitsc3.Text     = cpuHits[2].ToString();
            missesc1.Text   = cpuMisses[0].ToString();
            missesc2.Text   = cpuMisses[1].ToString();
            missesc3.Text   = cpuMisses[2].ToString();
            hpc1.Text       = cpuPerc[0].ToString();
            hpc2.Text       = cpuPerc[1].ToString();
            hpc3.Text       = cpuPerc[2].ToString();

            //HFS:Define vencedor
            winnerlabel.Text = winner;            

            //HFS:Esconder ou mostrar o button de envio de score para permitir apenas quando o User ganha
            if (winner == "computer")
            {
                sendData.Enabled = false;
            }
            else 
            {
                sendData.Enabled = true;
            }

        }

        //HFS:Função para cálculo de casas décimais de tiros acertados e falhados, 
        //genérica para ser usada para tudo.
        private int[] calculateHitsMisses(int hits)
        {
            int [] hitsAux= new int[3];

            if (hits > 99)
            {
            
                hitsAux[0] = (hits / 100);
                int hitsPart1aux = (hits / 10);
                hitsAux[1] = (hitsPart1aux % 10);
                hitsAux[2] = (hits % 10);
            }
            else if (hits > 9)
            {
                hitsAux[0] = 0;
                hitsAux[1] = (hits / 10);
                hitsAux[2] = (hits % 10);
            }
            else
            {
                hitsAux[0] = 0;
                hitsAux[1] = 0;
                hitsAux[2] = hits;
            }
            return hitsAux;
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            this.Close();
            Game novoJogo = new Game(getDifficulty);
            novoJogo.Show();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Main novoJogo = new Main();
            novoJogo.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendData_Click(object sender, EventArgs e)
        {
            SendData snd = new SendData(sendPlayerHits, sendPlayerMisses, sendPlayerHPerc, sendWinner);
            snd.Show();
            sendData.Enabled = false;
        }

    }
}
