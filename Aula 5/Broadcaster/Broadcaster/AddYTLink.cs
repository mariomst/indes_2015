using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadcaster
{
    public partial class AddYTLink : Form
    {

        string path;
        public AddYTLink()
        {
            InitializeComponent();
            label3.Hide();
            getYTPath();
        }

        private void getYTPath()
        {
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            path = parentDirectory + "\\Videos\\YT\\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileList = "links.txt";
            string fullPathList = path + fileList;


            //Criar novo ficheiro de configuração
            

            Regex regex = new Regex(@"^(https?\:\/\/)?(www\.)?(youtube\.com|youtu\.?be)\/.+$");
	        Match match = regex.Match(textBox2.Text);
	        if (match.Success)
	        {
	            Console.WriteLine(match.Value);
                TextWriter tw = new StreamWriter(fullPathList, true);
                tw.Write(textBox1.Text + " # " + textBox2.Text + ";");
                tw.Close();
                this.Close();
            }
            else { label3.Show(); }
            
            

            
        }

    }
}
