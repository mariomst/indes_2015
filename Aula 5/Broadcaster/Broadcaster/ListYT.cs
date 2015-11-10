using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadcaster
{
    public partial class ListYT : Form
    {
        string path;
        public ListYT()
        {
            InitializeComponent();
            getYTPath();
            this.Activated += new EventHandler(fillList);

        }

        private void getYTPath()
        {
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            path = parentDirectory + "\\Videos\\YT\\";
        }

        private void fillList(object sender, EventArgs e)
        {
            string ytList = "links.txt";
            string ytPathList = path + ytList;

            if (File.Exists(ytPathList))
            {
                Console.WriteLine("Info: File " + ytPathList + " exists.");

                //Ler valores dentro do ficheiro
                string[] values = File.ReadAllText(ytPathList).Split(';');

                if (values.Length > 0)
                {
                    listView1.Items.Clear();
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] != "")
                        {
                            ListViewItem item1 = new ListViewItem("Something");
                            item1.SubItems.Add("SubItem1a");
                            item1.SubItems.Add("SubItem1a");
                            
                            ListViewItem item2 = new ListViewItem("Something2");
                            item2.SubItems.Add("SubItem2a");
                            
                            listView1.Items.AddRange(new ListViewItem[] { item1, item2});
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("Info: File " + ytPathList + " doesn't exist.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddYTLink addyt = new AddYTLink();
            addyt.Show();

        }
    }
}
