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
        
        private int players_ativo; //Número de Jogadores no momento
        private int players_total; //Número de Jogadores no total

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

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
                panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
                btnDiscordServer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDiscordServer.Width, btnDiscordServer.Height, 20, 20));
                btnEntrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEntrar.Width, btnEntrar.Height, 20, 20));
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Há um problema no launcher! Contacta um administrador!\nErro : " + ex);
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(fivemServer);
                openNotification();
                Thread.Sleep(3000);
                Close();
            }
            catch (Exception)
            {
                btnEntrar.Enabled = false;
                MessageBox.Show("Não tens o FiveM instalado!");
            }
            
        }

        private void btnDiscordServer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(discordServer);
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void openNotification()
        {
            var title = "Portugália RP";
            var message = "O FiveM está a ser aberto, aguarda!";

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

            players_ativo = servidor.Data.clients;
            players_total = servidor.Data.sv_maxclients;

            label3.Text = "Jogadores : " + players_ativo + " / " + players_total;

            if((players_ativo == 0))
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Offline";
            } else
            {
                label4.ForeColor = Color.Green;
                label4.Text = "Online11";
            }
        }

   
    }
}