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
        private string fileWriter;          //Texto a ser escrito no ficheiro da playlist.

        public ListPL(string existingCategory)
        {
            InitializeComponent();
            LoadFilePaths();
            checkExistingCategory(existingCategory);            
            LoadLocalFilesList();
            LoadYoutubeList();

            plList.Scrollable = true;
            plList.View = View.Details;

            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            header.Width = plList.Width;
            plList.Columns.Add(header);
            plList.HeaderStyle = ColumnHeaderStyle.None;
            plList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
                category = existingCategory;
                editMode = true;
                PLname.Text = category;
                LoadPlaylist(category);
            }
            else
            {
                editMode = false;
            }
        }

        /*
        *   Função para carregar os caminhos e ficheiros que contêm as listas.
        */
        private void LoadFilePaths()
        {
            //Obter o diretório da aplicação.
            //parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string parentDirectory = Directory.GetCurrentDirectory();

            //Definir os caminhos para cada uma das listas.
            LFpath = parentDirectory + "\\Videos\\LF\\";
            YTpath = parentDirectory + "\\Videos\\YT\\";
            PLpath = parentDirectory + "\\Videos\\PL\\";
        }

        /*
        *   Função para carregar a playlist (caso esteja no modo de edição de uma existente)
        */
        private void LoadPlaylist(string category)
        {
            string playlist = category + ".txt";
            string plFilePath = PLpath + playlist;

            //Limpar a playlist antes de carregar novos itens.
            plList.Items.Clear();

            if (File.Exists(plFilePath))
            {
                Console.WriteLine("Info: File " + playlist + " exists.");

                //Ler valores dentro do ficheiro
                string[] values = File.ReadAllText(plFilePath).Split(';');

                if (values.Length > 0)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        Console.WriteLine(values[i]);
                        if (values[i] != "")
                        {
                            plList.Items.Add(values[i]);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Info: File " + playlist + " doesn't exist.");
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
                            lfList.Items.Add(itm.Text);
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
            //Definir o ficheiro a carregar e a sua localização.
            string fileName = "links.txt";
            string filePath = YTpath + fileName;

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
                            //Separar o nome do url
                            string[] info = values[i].Split('#');
                            string item = info[0] + " - " + info[1];

                            //Output para a consola (Apenas para testes).
                            Console.WriteLine("Info: Adding youtube url: " + info[1] + " to Youtube List.");

                            //Adicionar a lista o item.
                            ListViewItem itm = new ListViewItem(item);
                            ytList.Items.Add(itm.Text);
                        }
                    }
                }
            }
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
        *   Função para validações 
        */
        private bool validate(string type, string args)
        {
            switch (type)
            {
                case "ListSize":
                    //Verificar se a lista tem items.
                    if (args == "LF")
                    {
                        int sizeLF = lfList.Items.Count;
                        if (sizeLF > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (args == "YT")
                    {
                        int sizeYT = ytList.Items.Count;
                        if (sizeYT > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return false;
                default:
                    //Output para a consola (Apenas para testes).
                    Console.WriteLine("Info: Validation option invalid. Returning false.");
                    return false;
            }
        }

        /*
        *   Função para escrever no ficheiro de texto a Playlist
        */
        private void writeFile()
        {
            //Guardar ficheiros video numa lista
            string plfile = PLname.Text + ".txt";
            string catfile = "categories.txt";
            string plpath = PLpath + plfile;
            string catpath = PLpath + catfile;

            //Se a lista tiver items.
            if (plList.Items.Count > 0)
            {
                foreach (ListViewItem item in plList.Items)
                {
                    fileWriter += item.Text + ";";
                }

                //Criar ficheiro de playlist
                TextWriter tw1 = new StreamWriter(plpath, true);
                tw1.Write(fileWriter);
                tw1.Close();

                fileWriter = PLname.Text + ";";

                //Criar ficheiro de categorias
                TextWriter tw2 = new StreamWriter(catpath, true);
                tw2.Write(fileWriter);
                tw2.Close();

                DialogResult information = MessageBox.Show("Playlist saved. Closing window.",
                      "Playlist", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                //Output para a consola (Apenas para testes).
                Console.WriteLine("Info: Validation option invalid. Returning false.");

                DialogResult information = MessageBox.Show("The Playlist is empty.",
                      "Playlist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /*============================================================================================
        *= Botões
        *=============================================================================================*/
        /*
        *   Função para adicionar da lista Local Files à Playlits.
        */
        private void addLFBtn_Click(object sender, EventArgs e)
        {
            //Variáveis
            bool check = false;

            //Verificar se existem elementos na lista Local Files
            check = validate("ListSize", "LF");

            if (check == true)
            {
                try
                {
                    //Obter os items selecionados    
                    foreach (ListViewItem item in lfList.SelectedItems)
                    {
                        //Anexar indicativo que o vídeo é local.
                        string localFile = "[LF] " + item.Text;

                        //Adicionar a lista o item.
                        ListViewItem itm = new ListViewItem(localFile);
                        plList.Items.Add(itm.Text);
                        plList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    }
                }
                catch (ApplicationException)
                {
                    //Output para a consola (Apenas para testes).
                    Console.WriteLine("Info: No selected item.");
                }
            }
            else
            {
                DialogResult information = MessageBox.Show("No local files to add to playlist.",
                      "Playlist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /*
        *   Função para adicionar da lista Youtube à Playlits.
        */
        private void addYTBtn_Click(object sender, EventArgs e)
        {
            //Variáveis
            bool check = false;

            //Verificar se existem elementos na lista Local Files
            check = validate("ListSize", "YT");

            if (check == true)
            {
                try
                {
                    //Obter os items selecionados    
                    foreach (ListViewItem item in ytList.SelectedItems)
                    {
                        //Anexar indicativo que o vídeo é local.
                        string webVideo = "[YT] " + item.Text;

                        //Adicionar a lista o item.
                        ListViewItem itm = new ListViewItem(webVideo);
                        plList.Items.Add(itm.Text);
                        plList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    }
                }
                catch (ApplicationException)
                {
                    //Output para a consola (Apenas para testes).
                    Console.WriteLine("Info: No selected item.");
                }
            }
            else
            {
                DialogResult information = MessageBox.Show("No youtube videos to add to playlist.",
                      "Playlist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /*
        *   Função para remover os items da lista
        */
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in plList.SelectedItems)
            {
                //Apagar da lista
                plList.Items.Remove(eachItem);
            }

        }

        /*
        *   Função para mover um item para cima
        */
        private void upBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var currentIndex = plList.SelectedItems[0].Index;
                var item = plList.Items[currentIndex];
                if (currentIndex > 0)
                {
                    plList.Items.RemoveAt(currentIndex);
                    plList.Items.Insert(currentIndex - 1, item);
                }
            }
            catch (ApplicationException) { Console.WriteLine("nada selecionado"); }
        }

        /*
        *   Função para mover um item para baixo
        */
        private void downBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var currentIndex = plList.SelectedItems[0].Index;
                var item = plList.Items[currentIndex];
                if (currentIndex < plList.Items.Count - 1)
                {
                    plList.Items.RemoveAt(currentIndex);
                    plList.Items.Insert(currentIndex + 1, item);
                }
            }
            catch (ApplicationException) { Console.WriteLine("nada selecionado"); }
        }

        /*
        *   Função para guardar a Playlist.
        */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (PLname.Text != "")
                writeFile();
            else
            {
                DialogResult error = MessageBox.Show("Playlist Name can't be empty. Insert name please.",
                      "Playlist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
