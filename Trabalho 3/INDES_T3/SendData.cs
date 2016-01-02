using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDES_T3
{
    public partial class SendData : Form
    {
        //MST: Variáveis a serem usadas no Send Data
        int receivedPlayerHits = 0;
        int receivedPlayerMisses = 0;
        float receivedPlayerHPerc = 0;
        string receivedWinner = "";

        public SendData(int sendPlayerHits, int sendPlayerMisses, float sendPlayerHPerc, string sendWinner)
        {
            InitializeComponent();

            receivedPlayerHits   = sendPlayerHits;
            receivedPlayerMisses = sendPlayerMisses;
            receivedPlayerHPerc  = sendPlayerHPerc;
            receivedWinner       = sendWinner;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //MST: Função para enviar os dados do jogo por POST para o servidor ofbiz
        private void sendBtn_Click(object sender, EventArgs e)
        {
            //MST: Variáveis auxiliares
            Uri uriResult;
            string playerName  = textBox1.Text;
            string url         = textBox2.Text;
            string mstTitle    = "INDES: Battleships (Send Data)";
            string msgError001 = "Error 001: Please insert a player name.";
            string msgError002 = "Error 002: Please insert a valid address.";
            string msgError003 = "Error 003: The connection with OFBiz failed, please re-check the address (ex: http://localhost:8080).";

            //MST: Primeira validação para verificar se o utilizador inseriu um nome do jogador.
            if (textBox1.Text == "" || textBox1.Text == "Player Name Here")
            {               
                DialogResult error = MessageBox.Show(msgError001, mstTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MST: Verificar se o endereço inserido é válido                        
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                if (!result)
                {                   
                    DialogResult error = MessageBox.Show(msgError002, mstTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //MST: Adicionar o resto do url.
                    url += "/restcomponent/score";

                    //MST: Tentar enviar os dados por POST.
                    try
                    {
                        var httpWebRequest         = (HttpWebRequest)WebRequest.Create(url);
                        httpWebRequest.ContentType = "text/json";
                        httpWebRequest.Method      = "POST";

                        httpWebRequest.Headers.Add("login.username", "admin");
                        httpWebRequest.Headers.Add("login.password", "ofbiz");


                        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                        {
                            string json = "{\"username\":\"" + playerName + "\""
                                        + ", \"hits\":\"" + receivedPlayerHits + "\""
                                        + ", \"misses\":\"" + receivedPlayerMisses + "\""
                                        + ", \"hitsPercet\":\"" + receivedPlayerHPerc + "\""
                                        + ", \"winner\":\"" + receivedWinner + "\"}";

                            streamWriter.Write(json);
                            streamWriter.Flush();
                            streamWriter.Close();
                        }

                        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var resultPOST = streamReader.ReadToEnd();
                        }
                    }
                    catch(WebException ex)
                    {
                        Console.WriteLine(ex);
                        DialogResult error = MessageBox.Show(msgError003, mstTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                                    
                }
            }
        }
    }
}
