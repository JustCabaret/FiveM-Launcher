using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FiveM_Launcher
{
    public partial class Main : Form
    {
        private static string fivemAPI = "https://servers-frontend.fivem.net/api/servers/single/b4opvp"; //API do servidor FiveM
        private static string fivemServer = "fivem://connect/cfx.re/join/b4opvp"; //Link do servidor FiveM

        private static string discordServer = "https://discord.gg/GWZsjkJ"; //Link do servidor Discord
        private String players_ativo; //Número de Jogadores no momento

        private String players_total; //Número de Jogadores no total

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                loadData();
                panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
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
            openNotification();
            Thread.Sleep(3000);
            Close();
        }

        private void btnDiscordServer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(discordServer);
        }

        private void openNotification()
        {
            var title = "Portugália RP";
            var message = "O FiveM está a ser aberto, aguarda! 😊";

            var iconUri = "file:///" + Path.GetFullPath("Images/logo-top.png");
            var imageUri = "file:///" + Path.GetFullPath("Images/logo-top.jpg");

            new ToastContentBuilder()
            .AddArgument("action", "viewConversation")
            .AddArgument("conversationId", 9813)
            .AddAppLogoOverride(new Uri(iconUri), ToastGenericAppLogoCrop.Circle)
            .AddHeroImage(new Uri(imageUri))
            .AddText(title)
            .AddText(message)

            .Show();
        }

        private void loadData()
        {
            var result = "";
            var httpRequest = (HttpWebRequest)WebRequest.Create(fivemAPI);

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