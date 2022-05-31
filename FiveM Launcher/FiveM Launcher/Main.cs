using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveM_Launcher
{
    public partial class Main : Form
    {
        private static string fivemServer = "fivem://connect/cfx.re/join/kx5la6"; //Link do servidor FiveM
        private static string discordServer = "https://discord.gg/GWZsjkJ"; //Link do servidor Discord
        private String players_ativo; //Número de Jogadores no momento
        private String players_total; //Número de Jogadores no total

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Há um problema na aplicação! Contacta um administrador!\nErro : " + ex);
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(fivemServer);
            Thread.Sleep(3000);
            Close();
        }

        private void btnDiscordServer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(discordServer);
        }

        private void loadData()
        {
            var result = "";
            var url = "https://servers-frontend.fivem.net/api/servers/single/kx5la6";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);

            httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.67 Safari/537.36";
            httpRequest.Accept = "application/json";

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Servidor servidor = JsonConvert.DeserializeObject<Servidor>(result);

            players_ativo = Convert.ToString(servidor.Data.clients);
            players_total = Convert.ToString(servidor.Data.sv_maxclients);

            nplayers.Text = players_ativo;
            totalplayers.Text = players_total;
        }
    }
}