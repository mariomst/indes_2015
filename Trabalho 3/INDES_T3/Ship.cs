namespace INDES_T3
{
    class Ship
    {
        //MST: definição dos navios
        private string identifier;
        private string type;
        private int length;
        private int life;

        //MST: construtor sem argumentos
        public Ship()
        {
            identifier = "?";
            type = "unknown";
            length = 0;
            life = 0;
        }

        //MST: construtor com argumentos
        public Ship(string identifier, string type, int length, int life)
        {
            this.identifier = identifier;
            this.type = type;
            this.length = length;
            this.life = life;
        }

        //MST: definir o identificador do navio
        public void setIdentifier(string identifier)
        {
            this.identifier = identifier;
        }

        //MST: definir o tipo de navio
        public void setType(string type)
        {
            this.type = type;
        }

        //MST: definir o comprimento de navio
        public void setLength(int length)
        {
            this.length = length;
        }

        //MST: definir a vida do navio
        public void setLife(int life)
        {
            this.life = life;
        }

        //MST: retorna o identificador do navio
        public string getIdentifier()
        {
            return identifier;
        }

        //MST: retorna o tipo de navio
        public string getType()
        {
            return type;
        }

        //MST: retorna o comprimento de navio
        public int getLength()
        {
            return length;
        }

        //MST: retorna a vida do navio
        public int getLife()
        {
            return life;
        }
    }
}
