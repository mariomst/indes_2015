using INDES_T3.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace INDES_T3
{
    public partial class Game : Form
    {
        //HFS: grid dos jogadores
        private PictureBox[,] playerGrid;
        private Button[,] pcGrid;
        //HFS: Variáveis para Location dos buttons na grid
        private int xPlayer=132;
        private int yPlayer = 220;
        private int xPC = 847;
        private int yPC = 220;
        //MST: Váriaveis auxiliares
        bool playerShipsAutoPlacement = true;
        int saveDifficulty = 0;

        //MST: Inicialização de váriaveis
        Player player;
        Player computer;

        public Game(int difficulty)
        {
            if (difficulty == 1)
            {
                this.Text = "INDES: Battleships (Game: Easy)";
            }
            else if (difficulty == 2)
            {
                this.Text = "INDES: Battleships (Game: Normal)";
            }
            else
            {
                this.Text = "INDES: Battleships (Game: Hard)";
            }

            saveDifficulty = difficulty;

            InitializeComponent();
            CreateGameGrids(difficulty);
            DebugMessages();
        }

        //HFS: Criação dinâmica de butões para jogo SIZE = Dimensão do button; FIELD = Dimensão do campo
        private void CreatePlayfield(int size, int field)
        {
            playerGrid       = new PictureBox[field, field];
            pcGrid           = new Button[field, field];
            Grid playerShips = player.getGrid();

            for (int i = 0; i < field; i++)
            {
                for (int j = 0; j < field; j++)
                {
                    //MST: por algum motivo a grelha do jogo e a grelha com os navios estao invertidas uma da outra.
                    string playerShip = playerShips.getValue(j,i);

                    playerGrid[i, j]                       = new PictureBox();
                    playerGrid[i, j].Size                  = new Size(size, size);
                    playerGrid[i, j].Location              = new Point(xPlayer + i * size, yPlayer + j * size);
                    playerGrid[i, j].BackColor             = Color.Cyan;
                    playerGrid[i, j].BorderStyle           = BorderStyle.None;

                    //MST: para desenhar os navios do jogador na interface.
                    if (playerShip == null)
                    {
                        playerGrid[i, j].BackgroundImage = Resources.Grid2;
                    }
                    else
                    {
                        if (playerShip == "a")
                        {
                            playerGrid[i, j].BackgroundImage = Resources.Grid4a;
                        }
                        else if (playerShip == "b")
                        {
                            playerGrid[i, j].BackgroundImage = Resources.Grid7a;
                        }
                        else if (playerShip == "c")
                        {
                            playerGrid[i, j].BackgroundImage = Resources.Grid5a;
                        }
                        else if (playerShip == "d1" || playerShip == "d2")
                        {
                            playerGrid[i, j].BackgroundImage = Resources.Grid6a;
                        }
                        else if (playerShip == "s1" || playerShip == "s2")
                        {
                            playerGrid[i, j].BackgroundImage = Resources.Grid3a;
                        }
                    }
                    
                    playerGrid[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    playerGrid[i, j].Name                  = "playerSquare_" + i + "_" + j;
                    //playerGrid[i, j].Click += new EventHandler(Tiro);
                    this.Controls.Add(playerGrid[i, j]);
                }

                for (int j = 0; j < field; j++)
                {
                    pcGrid[i, j] = new Button();
                    pcGrid[i, j].Size = new Size(size, size);
                    pcGrid[i, j].Location = new Point(xPC + i * size, yPC + j * size);
                    pcGrid[i, j].BackColor = Color.Green;
                    pcGrid[i, j].FlatAppearance.BorderSize = 0;
                    pcGrid[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    pcGrid[i, j].BackgroundImage = Resources.Grid2;
                    pcGrid[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    pcGrid[i, j].Name = "pcSquare_" + i + "_" + j;
                    pcGrid[i, j].Click += new EventHandler(Shot);
                    this.Controls.Add(pcGrid[i, j]);
                }
            }
        }

        //HFS: Função de teste para atribuição de funções aos buttons de forma dinâmica
        void Shot(object sender, EventArgs e)
        {
            Button bt          = (Button)sender;
            List<Ship> ships   = computer.getShips();
            int totalShots     = player.getTotalShots();
            string checkWinner = "";

            //Algoritmo para através do nome do button ir buscar coordenadas do mesmo/posição do array
            String input = bt.Name;
            String[] numbers = Regex.Split(input, @"\D+");
            int [] coord = new int[2];
            int j = 0;
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    int i = int.Parse(value);
                    coord[j] = i;
                    j++;
                }
            }
            int x      = coord[0];
            int y      = coord[1];
            int hits   = player.getHits();
            int misses = player.getMisses();

            Grid computerShips = computer.getGrid();

            if (computerShips.getValue(y, x) == null)
            {
                bt.Enabled = false; //desativa o botão.
                bt.BackgroundImage = Resources.gridMissa;
                misses += 1;
                player.setMisses(misses);
                computer.computerMove(player, playerGrid, labelInfo);        
            }
            else
            {
                bt.Enabled = false; //desativa o botão.
                bt.BackgroundImage = Resources.gridHitb;
                hits += 1;
                player.setHits(hits);
                player.updateShipList(ships, computerShips.getValue(y, x), labelInfo, "Player");
            }

            totalShots += 1;                    //MST: incrementa o número total de tiros do jogador.
            player.setTotalShots(totalShots);   //MST: atualiza o número total de tiros do jogador.

            updateScoreboard();

            checkWinner = player.checkRemainingShips(player, computer, labelInfo);

            if(checkWinner != "")
            {
                EndGame(checkWinner);
            }
        }

        //MST: Criação das grelhas consoante a dificuldade escolhida
        private void CreateGameGrids(int difficulty)
        {
            player   = new Player(difficulty, playerShipsAutoPlacement);
            computer = new Player(difficulty, true);

            if (difficulty == 1)
            {
                CreatePlayfield(56,5);
            }
            else if (difficulty == 2)
            {
                CreatePlayfield(28,10);
            }
            else
            {
                CreatePlayfield(19,15);
            }
        }

        //MST: Atualizar o scoreboard da aplicação
        private void updateScoreboard()
        {
            int hits   = player.getHits();
            int misses = player.getMisses();

            //Atualiza os hits:
            if (hits > 99)
            {
                int hitsPart0 = (hits / 100);
                string hitsTextP0 = hitsPart0.ToString();

                int hitsPart1aux = (hits / 10);
                int hitsPart1 = (hitsPart1aux % 10);
                string hitsTextP1 = hitsPart1.ToString();

                int hitsPart2 = (hits % 10);
                string hitsTextP2 = hitsPart2.ToString();

                hitsLabel3.Text = hitsTextP0;
                hitsLabel2.Text = hitsTextP1;
                hitsLabel1.Text = hitsTextP2;
            }
            else if (hits > 9)
            {
                int hitsPart0 = (hits / 10);
                string hitsTextP0 = hitsPart0.ToString();

                int hitsPart1 = (hits % 10);
                string hitsTextP1 = hitsPart1.ToString();

                hitsLabel2.Text = hitsTextP0;
                hitsLabel1.Text = hitsTextP1;
            }
            else
            {
                hitsLabel1.Text = hits.ToString();
            }

            //Atualiza os misses:
            if (misses > 99)
            {
                int missesPart0 = (misses / 100);
                string missesTextP0 = missesPart0.ToString();

                int missesPart1aux = (misses / 10);
                int missesPart1 = (missesPart1aux % 10);
                string missesTextP1 = missesPart1.ToString();

                int missesPart2 = (misses % 10);
                string missesTextP2 = missesPart2.ToString();

                missesLabel3.Text = missesTextP0;
                missesLabel2.Text = missesTextP1;
                missesLabel1.Text = missesTextP2;
            }
            else if (misses > 9)
            {
                int missesPart0 = (misses / 10);
                string missesTextP0 = missesPart0.ToString();

                int missesPart1 = (misses % 10);
                string missesTextP1 = missesPart1.ToString();

                missesLabel2.Text = missesTextP0;
                missesLabel1.Text = missesTextP1;
            }
            else
            {
                missesLabel1.Text = misses.ToString();
            }
        }
      
        //HFS: Chamada do form Score - Acrescentado parametro com a dificuldade
        //do jogo atual
        private void EndGame(string winner)
        {
            player.setHitsPercentage();
            computer.setHitsPercentage();

            Score endGame = new Score(player.getHits(), player.getMisses(), player.getHitsPercentage(), 
                                    computer.getHits(), computer.getMisses(), computer.getHitsPercentage(), 
                                    winner, saveDifficulty);
            endGame.Show();

            Close();  
        }

        //MST: Mensagens de DEBUG (apenas para testes)
        private void DebugMessages()
        {
            Grid playerGrid = player.getGrid();
            Grid computerGrid = computer.getGrid();

            int pRows = playerGrid.getRows();
            int pColumns = playerGrid.getColumns();

            int oRows = computerGrid.getRows();
            int oColumns = computerGrid.getColumns();

            Console.WriteLine("INFO: Player's grid dimensions are {0} x {1}.", pRows, pColumns);
            Console.WriteLine("INFO: Opponent's grid dimensions are {0} x {1}.", oRows, oColumns);

            Console.WriteLine("INFO: Showing players's grid.");
            for (int i = 0; i < pRows; i++)
            {
                for (int j = 0; j < pColumns; j++)
                {
                    Console.Write("[{0}]", playerGrid.getValue(i, j));
                }
                Console.WriteLine();
            }

            Console.WriteLine("INFO: Showing opponent's Grid.");
            for (int i = 0; i < oRows; i++)
            {
                for (int j = 0; j < oColumns; j++)
                {
                    Console.Write("[{0}]", computerGrid.getValue(i, j));
                }
                Console.WriteLine();
            }


        }
    }
}
