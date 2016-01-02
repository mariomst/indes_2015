using INDES_T3.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace INDES_T3
{
    //MST: classe responsável para tudo que seja relacionado com o jogador
    class Player
    {
        //MST: váriaveis auxiliares
        private int hits;
        private int misses;
        private int totalShots;
        private float hitsPercentage;
        private float missesPercentage;
        private List<Ship> playerShips = new List<Ship>();
        private Grid playerGrid;
        private Grid opponentsGrid;

        /************************************************************/
        /*  Construtores                                            */
        /************************************************************/

        //MST: construtor sem argumentos
        public Player()
        {
            hits             = 0;
            misses           = 0;
            totalShots       = 0;
            hitsPercentage   = 0;
            missesPercentage = 0;
            playerShips[0]   = new Ship();
            playerGrid       = new Grid();
            opponentsGrid    = new Grid();
        }

        //MST: construtor com argumentos
        public Player(int difficulty, bool autoPlacement)
        {
            //dificuldade define quantos barcos vai ter
            //autoPlacement define se os navios são postos automaticamente para o utilizador

            //MST: inicialização das variáveis
            hits             = 0;
            misses           = 0;
            totalShots       = 0;
            hitsPercentage   = 0;
            missesPercentage = 0;

            //MST: inicialização da frota
            Ship aircraft   = new Ship("a", "aircraft", 5, 5);
            Ship battleship = new Ship("b", "battleship", 4, 4);
            Ship cruiser    = new Ship("c", "cruiser", 3, 3);
            Ship destroyer1 = new Ship("d1", "destroyer", 2, 2);
            Ship destroyer2 = new Ship("d2", "destroyer", 2, 2);
            Ship submarine1 = new Ship("s1", "submarine", 1, 1);
            Ship submarine2 = new Ship("s2", "submarine", 1, 1);

            //MST: variaveis 
            int maxRows = 0;
            int maxCols = 0;

            //MST: definir as dimensoes da grelha
            if (difficulty == 1)
            {              
                maxRows = 5;
                maxCols = 5;                             
            }
            else if (difficulty == 2)
            {
                maxRows = 10;
                maxCols = 10;
            }
            else
            {
                maxRows = 15;
                maxCols = 15;
            }

            //MST: adicinar navios à lista consoante a dificudade
            if (difficulty == 1)
            {                
                playerShips.Add(cruiser);
                playerShips.Add(destroyer1);
                playerShips.Add(destroyer2);
                playerShips.Add(submarine1);
            }
            else
            {
                playerShips.Add(aircraft);
                playerShips.Add(battleship);
                playerShips.Add(cruiser);
                playerShips.Add(destroyer1);
                playerShips.Add(destroyer2);
                playerShips.Add(submarine1);
                playerShips.Add(submarine2);
            }

            //MST: inicialização da grelha
            playerGrid    = new Grid(maxRows, maxCols);
            opponentsGrid = new Grid(maxRows, maxCols);

            //MST: caso esteja ativo, insere os barcos de forma aleatória
            if (autoPlacement == true)
            {
                autoInsertShips(playerShips);
            }
        }

        /************************************************************/
        /*  Sets                                                    */
        /************************************************************/

        //MST: definir o número total de ataques
        public void setTotalShots(int totalShots)
        {
            this.totalShots = totalShots;
        }

        //MST: definir o número de ataques que acertaram
        public void setHits(int hits)
        {
            this.hits = hits;
        }

        //MST: definir o número de ataques que falharam
        public void setMisses(int misses)
        {
            this.misses = misses;
        }

        //MST: definir a percentagem de ataques que acertaram
        public void setHitsPercentage()
        {
            this.hitsPercentage = calculateHitsPercentage();
        }

        //MST: definir a percentagem de ataques que falharam
        public void setMissesPercentage()
        {
            this.missesPercentage = calculateMissesPercentage();
        }

        /************************************************************/
        /*  Gets                                                    */
        /************************************************************/

        //MST: retorna a grelha do jogador
        public Grid getGrid()
        {
            return playerGrid;
        }

        //MST: retorna os navios do jogador
        public List<Ship> getShips()
        {
            return playerShips;
        }
        
        //MST: retorna o número total de tiros
        public int getTotalShots()
        {
            return totalShots;
        }

        //MST: retorna o número de ataques que acertaram
        public int getHits()
        {
            return hits;
        }

        //MST: retorna o número de ataques que falharam
        public int getMisses()
        {
            return misses;
        }

        //MST: retorna a percentagem de ataques que acertaram
        public float getHitsPercentage()
        {
            return hitsPercentage;
        }

        //MST: retorna a percentagem de ataques que falharam
        public float getMissesPercentage()
        {
            return missesPercentage;
        }

        /************************************************************/
        /*  Funções                                                 */
        /************************************************************/

        //MST: inserção dos navios do computador de forma aleatória
        private void autoInsertShips(List<Ship> ships)
        {
            //MST: variáveis auxiliares
            Random random  = new Random();
            bool canInsert = false;
            int rowPos     = 0;
            int colPos     = 0;

            //MST: variáveis relacionadas com a grelha
            int rows = playerGrid.getRows();
            int cols = playerGrid.getColumns();

            //MST: para cada navio, tenta inserir na grelha
            for (int i = 0; i < ships.Count; i++)
            {
                //MST: determina a direção do navio (horizontal ou vertical)
                int direction = random.Next(0, 2);

                //MST: alguns dados do navio
                int shipLength = ships[i].getLength();
                string shipId  = ships[i].getIdentifier();

                //MST: enquanto não conseguir inserir, tenta várias posições
                while (canInsert == false)
                {
                    rowPos = random.Next(0, rows);
                    colPos = random.Next(0, cols);

                    canInsert = playerGrid.validate(shipLength, rowPos, colPos, direction);
                }

                //MST: insere o navio na grelha
                if (canInsert == true)
                {
                    if (direction == 0)
                    {
                        for (int j = 0; j < shipLength; j++)
                        {
                            playerGrid.setValue(shipId, rowPos, colPos);
                            colPos++;
                            //playerGrid.drawGridInConsole();
                        }
                    }
                    else
                    {
                        for (int j = 0; j < shipLength; j++)
                        {
                            playerGrid.setValue(shipId, rowPos, colPos);
                            rowPos++;
                            //playerGrid.drawGridInConsole();
                        }
                    }
                }

                canInsert = false;
            }
        }

        //MST: jogada do computador
        //Função computerMove alterada: estava a crashar logo a seguir à primeira jogada | Resolvido
        public void computerMove(Player human, PictureBox[,] playerGrid, Label info)
        {
            //MST: variáveis auxiliares
            Grid pGrid = human.getGrid();
            List<Ship> ships = human.getShips();
            Random random = new Random();
            int rowPos = 0;
            int colPos = 0;
            int totalShots = getTotalShots();
            int totalHits = getHits();
            int totalMisses = getMisses();

            //MST: se a posição estiver vazia, então o computador ainda não tinha escolhida aquela posição
            do
            {
                rowPos = random.Next(0, pGrid.getRows());
                colPos = random.Next(0, pGrid.getColumns());
            }
            while (opponentsGrid.getValue(rowPos, colPos) != null);

            //MST: obter o valor dessa posição usando a grelha do jogador
            string cellValue = pGrid.getValue(rowPos, colPos);

            if (cellValue != null)
            {
                this.setTotalShots(totalShots + 1);
                this.setHits(totalHits + 1);

                updateShipList(ships, cellValue, info, "Computer");

                opponentsGrid.setValue(cellValue, rowPos, colPos);
                pGrid.setValue("X", rowPos, colPos);
                playerGrid[colPos, rowPos].BackgroundImage = Resources.gridHitb;

                if (ships.Count > 0)
                {
                    computerMove(human, playerGrid, info);
                }                
            }
            else
            {
                this.setTotalShots(totalShots + 1);
                this.setMisses(totalMisses + 1);

                opponentsGrid.setValue("M", rowPos, colPos);
                pGrid.setValue("M", rowPos, colPos);
                playerGrid[colPos, rowPos].BackgroundImage = Resources.gridMissa;
            }
        }

        //MST: função para atualizar a lista dos navios de ambos os jogadores caso sejam atingidos e destruídos
        public void updateShipList(List<Ship> ships, string cellValue, Label info, string playerID)
        {
            foreach (Ship item in ships)
            {
                if (item.getIdentifier() == cellValue)
                {
                    if(playerID == "Computer")
                    {
                        info.Text = "The player's " + item.getType() + " was hit!";
                    }
                    else
                    {
                        info.Text = "The computer's " + item.getType() + " was hit!";
                    }
                    
                    item.setLife(item.getLife() - 1);

                    if (item.getLife() == 0)
                    {
                        if (playerID == "Computer")
                        {
                            info.Text = "The player's " + item.getType() + " was destroyed!";
                        }
                        else
                        {
                            info.Text = "The computer's " + item.getType() + " was destroyed!";
                        }
                        ships.Remove(item);
                    }
                    break;
                }
            }
        }

        //MST: função para verificar quantos navios restam para determinar se o jogo continua
        public string checkRemainingShips(Player player, Player computer, Label info)
        {
            List<Ship> playerShips   = player.getShips();
            List<Ship> computerShips = computer.getShips();
            string winner = "";

            if (playerShips.Count == 0)
            {
               info.Text = "All player's ships were destroyed! Game Over!";
               winner = "Computer";                 
            }
            else if (computerShips.Count == 0)
            {
                info.Text = "All computer's ships were destroyed!";
                winner = "Player";            
            }

            return winner;
        }

        //MST: cálculo da percentagem de tiros que acertaram
        private float calculateHitsPercentage()
        {
            //MST: váriaveis
            int totalShots = getTotalShots();
            int hits = getHits();
            float percentage = 0;

            //MST: cálculo
            percentage = ((hits * 100) / totalShots);      

            return percentage;
        }

        //MST: cálculo da percentagem de tiros que falharam
        private float calculateMissesPercentage()
        {
            //MST: váriaveis
            int totalShots = getTotalShots();
            int misses = getMisses();
            float percentage = 0;

            //MST: cálculo
            percentage = ((misses * 100) / totalShots);

            return percentage;
        }
    }
}
