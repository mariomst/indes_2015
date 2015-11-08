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
    public partial class ListLF : Form
    {
        string [] sSelectedFiles;
        private string videosPath;
        
        public ListLF()
        {
            InitializeComponent();
            getVideoPath();
            loadVideosFile();
        }

        //Obter o diretório Videos do programa
        private void getVideoPath()
        {
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            videosPath = parentDirectory + "\\Videos\\LF\\";
        }

        //Carregar ficheiro com os videos
        private void loadVideosFile()
        {
            string fileList     = "videos.txt";
            string fullPathList = videosPath + fileList;

            if (File.Exists(fullPathList))
            {
                Console.WriteLine("Info: File " + fullPathList + " exists.");
                
                //Ler valores dentro do ficheiro
                string[] values = File.ReadAllText(fullPathList).Split(';');

                if (values.Length > 0)
                {
                    for(int i=0; i < values.Length; i++)
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
                Console.WriteLine("Info: File " + fullPathList + " doesn't exist.");
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "avi files (*.avi)|*.avi";
            dialog.FilterIndex = 1;

            dialog.Multiselect = true;


            if (dialog.ShowDialog() == DialogResult.OK)
                sSelectedFiles = dialog.FileNames;
            else
                Array.Clear(sSelectedFiles,0,sSelectedFiles.Length);

            int totalSelected    = sSelectedFiles.Length;
            string videosList    = "";

            for(int i=0; i<totalSelected; i++)
            {
                string fullVideoPath = sSelectedFiles[i];
                string filename      = fullVideoPath.Substring(fullVideoPath.LastIndexOf("\\") + 1);

                string newVideoPath  = videosPath + filename;

                if (!File.Exists(newVideoPath))
                {
                    Console.WriteLine(newVideoPath);
                    File.Copy(fullVideoPath, newVideoPath);

                    ListViewItem itm = new ListViewItem(filename);
                    listView1.Items.Add(itm);

                    videosList += filename + ";";

                    Console.WriteLine("INFO: File " + filename + " added!");
                }
                else
                {               
                    Console.WriteLine("INFO: File " + filename + " already exists!");
                }
            }

            //Guardar ficheiros video numa lista
            string fileList     = "videos.txt";
            string fullPathList = videosPath + fileList;

            //Se não existir cria o backup
            if (File.Exists(fullPathList))
            {
                File.WriteAllText(fullPathList, "");
            }            

            //Criar novo ficheiro de configuração
            TextWriter tw = new StreamWriter(fullPathList, true);
            tw.Write(videosList);
            tw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //File.Delete
            string fileList     = "videos.txt";
            string fullPathList = videosPath + fileList;
            string videosList   = "";

            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                //Apagar o video
                string file = videosPath + eachItem.Text;
                File.Delete(file);
                
                //Apagar da lista
                listView1.Items.Remove(eachItem);
            }

            //Se não existir cria o backup
            if (File.Exists(fullPathList))
            {
                File.WriteAllText(fullPathList, "");
            }    

            foreach (ListViewItem item in listView1.Items)
            {
                videosList += item.Text + ";";
            }

            //Criar novo ficheiro de configuração
            TextWriter tw = new StreamWriter(fullPathList, true);
            tw.Write(videosList);
            tw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}

