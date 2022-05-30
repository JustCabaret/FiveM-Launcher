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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveM_Launcher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/cfx.re/join/kx5la6");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //var result = "";
            //var uri = "https://servers-frontend.fivem.net/api/servers/single/kx5la6";
            //var httpRequest = (HttpWebRequest)WebRequest.Create(uri);
            //httpRequest.Method = "GET";
            //httpRequest.Headers.Add("User-Agent:", "Mozilla/5.0");
            //httpRequest.Accept = "application/json";
            //httpRequest.ContentType = "application/json";

            //var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    result = streamReader.ReadToEnd();
            //}

            ////DataTable dt = JsonConvert.DeserializeObject<DataTable>(result);

            //MessageBox.Show(result);

            var url = "https://servers-frontend.fivem.net/api/servers/single/kx5la6";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Headers.Add("admin", "admin");

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);
        }
    }
}