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

            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            header.Width = listView1.Width;
            listView1.Columns.Add(header);
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void getYTPath()
        {
            //string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string parentDirectory = Directory.GetCurrentDirectory();
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
                            ListViewItem itm = new ListViewItem(values[i]);
                            listView1.Items.Add(itm);
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            string fileList     = "links.txt";
            string fullPathList = path + fileList;
            string linksList   = "";
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {  
                //Apagar da lista
                listView1.Items.Remove(eachItem);
            }
            //Limpar o ficheiro com a lista
            if (File.Exists(fullPathList))
            {
                File.WriteAllText(fullPathList, "");
            }    
            //mete numa string todos os items da lista separados por um ";"
            foreach (ListViewItem item in listView1.Items)
            {
                 linksList   += item.Text + ";";
            }
            //Criar novo ficheiro com a lista
            TextWriter tw = new StreamWriter(fullPathList, true);
            tw.Write(linksList);
            tw.Close();
        }
    }
         
}
