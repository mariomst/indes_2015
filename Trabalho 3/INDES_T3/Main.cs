using System;
using System.Windows.Forms;

namespace INDES_T3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("INFO: Starting a game in easy difficulty.");
            Game game = new Game(1);
            game.Show();
            Hide();
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("INFO: Starting a game in normal difficulty.");
            Game game = new Game(2);
            game.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("INFO: Starting a game in hard difficulty.");
            Game game = new Game(3);
            game.Show();
            Hide();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("INFO: Showing help.");
        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("INFO: Closing application.");
            Close();
        }
    }
}
