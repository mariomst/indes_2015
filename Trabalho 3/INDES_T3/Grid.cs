using System;

namespace INDES_T3
{
    //MST: classe responsável para tudo que seja relacionado com as grelhas
    class Grid
    {
        //MST: definição da grelha
        private int rows;
        private int columns;
        private string[,] grid;

        //MST: construtor sem argumentos
        public Grid()
        {
            rows = 0;
            columns = 0;
            grid = new string[rows, columns];
        }

        //MST: construtor com argumentos
        public Grid(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            grid = new string[rows, columns];
        }

        //MST: retorna o número de linhas da grelha
        public int getRows()
        {
            return rows;
        }

        //MST: retorna o número de colunas da grelha
        public int getColumns()
        {
            return columns;
        }

        //MST: retorna o valor existente naquela posição da grelha
        public string getValue(int row, int column)
        {
            return grid[row, column];
        }

        //MST: define valores na grelha
        public void setValue(string shipIdentifier, int row, int column)
        {
            grid[row, column] = shipIdentifier;
        }

        //MST: validações para garantir que o navio pode ser posicionado naquela área da grelha
        public bool validate(int shipLength, int rowPos, int colPos, int direction)
        {
            //MST: alguns dados da grelha que são necessários para as verificações
            int rowLimit  = getRows() - 1;        //MST: menos 1 porque estamos a trabalhar com um array multidimensional e a posição inicial é [0,0]
            int colLimit  = getColumns() - 1;     //MST: menos 1 porque estamos a trabalhar com um array multidimensional e a posição inicial é [0,0]

            //MST: 1ª verificação -> o navio encaixa na posição escolhida?
            int rowsAvaiable = getRows() - rowPos;
            int colsAvaiable = getColumns() - colPos;
            bool firstValidation = validateShipSpace(shipLength, rowsAvaiable, colsAvaiable, direction);

            if (firstValidation == true)
            {
                //MST: 2ª verificação -> existem navios na posição onde o novo navio vai ser inserido?
                bool secondValidation = validateShipCollision(shipLength, rowPos, colPos, direction);

                if (secondValidation == true)
                {
                    //MST: 3ª verificação -> existem navios que vão ficar "colados" ao novo navio?
                    bool thirdValidation = validateSpaceBetweenShips();

                    if (thirdValidation == true) { return true; }
                    else { return false; }
                }
                else { return false; }
            }
            else { return false; }
        }

        //MST: primeira validação -> verificar se o navio pode ser inserido naquela posição
        private bool validateShipSpace(int shipLength, int rowsAvaiable, int colsAvaiable, int direction)
        {
            Console.WriteLine("INFO: Executing first verification.");

            if (direction == 0) //MST: Se a direcção do navio é na horizontal
            {
                if (shipLength < colsAvaiable)
                {
                    Console.WriteLine("INFO: The ship has enough space.");
                    return true;
                }
                else
                {
                    Console.WriteLine("INFO: The ship doesn't have enough space.");
                    return false;
                }
            }
            else //MST: Se a direcção do navio é na vertical
            {
                if (shipLength < rowsAvaiable)
                {
                    Console.WriteLine("INFO: The ship has enough space.");
                    return true;
                }
                else
                {                    
                    Console.WriteLine("INFO: The ship doesn't have enough space.");
                    return false;
                }
            }
        }

        //MST: segunda validação -> verificar se o navio não colide com outro navio
        private bool validateShipCollision(int shipLength, int rowPos, int colPos, int direction)
        {
            Console.WriteLine("INFO: Executing second verification.");

            if (direction == 0)
            {
                int row = rowPos;
                int col = colPos;

                //MST: ciclo que verifica cada bloco do navio não colide com outro navio
                for (int i = 0; i < shipLength; i++)
                {
                    string cellValue = "";  //MST: armazena o valor da célula da grelha do jogador

                    cellValue = getValue(row, col);    //MST: obtém o valor existente naquela célula

                    if(cellValue != null) //MST: caso exista colisão
                    {                        
                        Console.WriteLine("INFO: The ship collided with another ship");
                        return false;
                    }

                    col++;  //MST: passamos para o bloco seguinte
                }

                //MST: se percorrer o ciclo sem colisões então passa para a verificação seguinte
                Console.WriteLine("INFO: The ship didn't had any collisions.");
                return true;
            }
            else
            {
                int row = rowPos;
                int col = colPos;

                //MST: ciclo que verifica cada bloco do navio não colide com outro navio
                for (int i = 0; i < shipLength; i++)
                {
                    string cellValue = "";  //MST: armazena o valor da célula da grelha do jogador

                    cellValue = getValue(row, col);    //MST: obtém o valor existente naquela célula

                    if (cellValue != null) //MST: caso exista colisão
                    {                        
                        Console.WriteLine("INFO: The ship collided with another ship");
                        return false;
                    }

                    row++;  //MST: passamos para o bloco seguinte
                }

                //MST: se percorrer o ciclo sem colisões então passa para a verificação seguinte
                Console.WriteLine("INFO: The ship didn't had any collisions.");
                return true;
            }
        }

        //MST: terceira validação -> verificar se existe 1 bloco de espaço entre navios
        private bool validateSpaceBetweenShips()
        {
            return true;
        }

        //MST: desenhar a grelha na consola (para debug)
        public void drawGridInConsole()
        {
            Console.WriteLine("INFO: Drawing Grid");

            for (int i = 0; i < getRows(); i++)
            {
                for (int j = 0; j < getColumns(); j++)
                {
                    Console.Write("[{0}]", getValue(i, j));
                }
                Console.WriteLine();
            }
        }
    }
}
