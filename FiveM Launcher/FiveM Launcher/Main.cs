﻿using Newtonsoft.Json;
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

            Console.WriteLine(servidor.Data.clients);
        }
    }
}