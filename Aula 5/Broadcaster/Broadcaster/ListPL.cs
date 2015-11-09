/*
*   Windows Form para a criação de playlists.
*   Version 1.0 
*/

using System;
using System.IO;
using System.Windows.Forms;

namespace Broadcaster
{
    public partial class ListPL : Form
    {
        //Variáveis:
        private string category;            //Nome / Categoria da playlist.
        private bool editMode;              //Caso a playlist seja uma existente entra em modo edição, caso contrário passa a modo de criação.
        private string parentDirectory;     //Caminho para o diretório da aplicação.
        private string LFpath;              //Caminho para o diretório com a lista de ficheiros locais.
        private string YTpath;              //Caminho para o diretório com a lista de links Youtube.
        private string PLpath;              //Caminho para o diretório das Playlists.

        public ListPL(string existingCategory)
        {
            InitializeComponent();
            checkExistingCategory(existingCategory);
            LoadFilePaths();
            LoadPlaylist();
            LoadLocalFilesList();
            LoadYoutubeList();
        }

        /*============================================================================================
        *= Funções Auxliares
        *=============================================================================================*/
        /*
        *   Função para caso seja para editar uma playlist já existente ativar o modo de edição.
        */
        private void checkExistingCategory(string existingCategory)
        {
            if (existingCategory != "")
            {
                category    = existingCategory;
                editMode    = true;
                PLname.Text = category;
            }
            else
            {
                editMode    = false;
            }
        }

        /*
        *   Função para carregar os caminhos e ficheiros que contêm as listas.
        */
        private void LoadFilePaths()
        {
            //Obter o diretório da aplicação.
            parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            //Definir os caminhos para cada uma das listas.
            LFpath = parentDirectory + "\\Videos\\LF\\";
            YTpath = parentDirectory + "\\Videos\\YT\\";
            PLpath = parentDirectory + "\\Videos\\PL\\";
        }

        /*
        *   Função para carregar a playlist (caso esteja no modo de edição de uma existente)
        */
        private void LoadPlaylist()
        {
            if (editMode == true)
            {
                //...
            }
        }

        /*
        *   Função para carregar a lista de ficheiros locais.
        */
        private void LoadLocalFilesList()
        {
            //Definir o ficheiro a carregar e a sua localização.
            string fileName = "videos.txt";
            string filePath = LFpath + fileName;

            //Verificar se o ficheiro existe
            bool fileExists = checkFile(filePath);

            if (fileExists == true)
            {
                //Obter os valores dentro do ficheiro
                //Todos os ficheiros estão separados por ; então fazemos split para obter cada um dos ficheiros
                string[] values = File.ReadAllText(filePath).Split(';');    

                //Se existirem ficheiros para inserir na lista
                if (values.Length > 0)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] != "")
                        {
                            //Output para a consola (Apenas para testes).
                            Console.WriteLine("Info: Adding " + values[i] + " to Local Files List.");

                            //Adicionar a lista o item.
                            ListViewItem itm = new ListViewItem(values[i]);
                            listBox2.Items.Add(itm.Text);
                        }
                    }
                }
            }            
        }

        /*
        *   Função para carregar a lista de Youtube
        */
        private void LoadYoutubeList()
        {
            //...
        }

        /*
        *   Função para verificar se o ficheiro existe.
        */
        private bool checkFile(string file)
        {
            if (File.Exists(file))
            {
                //Output para a consola (Apenas para testes).
                Console.WriteLine("Info: " + file + " was found. Loading File.");

                return true;
            }
            else
            {
                //Output para a consola (Apenas para testes).
                Console.WriteLine("Info: " + file + " wasn't found. Ignoring this step.");

                return false;
            }
        }

        /*
        *   Função para validar a playlist 
        */
        private void validatePlaylist()
        {
            //...
        }

        /*
        *   Função para escrever no ficheiro de texto a Playlist
        */
        private void writeFile()
        {
            //...
        }

        /*============================================================================================
        *= Botões
        *=============================================================================================*/
        /*
        *   Função para adicionar das listas à Playlits.
        */
        private void addBtn_Click(object sender, EventArgs e)
        {
            //...
        }

        /*
        *   Função para remover da Playlit.
        */
        private void removeBtn_Click(object sender, EventArgs e)
        {
            //...
        }

        /*
        *   Função para guardar a Playlist.
        */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //...
        }

        /*
        *   Função para cancelar.
        */
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to cancel? Any changes done will be lost.",
                      "Playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            switch (confirmation)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
