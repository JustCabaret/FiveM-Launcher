
namespace FiveM_Launcher
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.nplayers = new System.Windows.Forms.Label();
            this.totalplayers = new System.Windows.Forms.Label();
            this.btnDiscordServer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Location = new System.Drawing.Point(494, 164);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(219, 88);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar no Servidor";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // nplayers
            // 
            this.nplayers.AutoSize = true;
            this.nplayers.Location = new System.Drawing.Point(541, 47);
            this.nplayers.Name = "nplayers";
            this.nplayers.Size = new System.Drawing.Size(35, 13);
            this.nplayers.TabIndex = 1;
            this.nplayers.Text = "label1";
            // 
            // totalplayers
            // 
            this.totalplayers.AutoSize = true;
            this.totalplayers.Location = new System.Drawing.Point(606, 46);
            this.totalplayers.Name = "totalplayers";
            this.totalplayers.Size = new System.Drawing.Size(35, 13);
            this.totalplayers.TabIndex = 2;
            this.totalplayers.Text = "label1";
            // 
            // btnDiscordServer
            // 
            this.btnDiscordServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscordServer.Location = new System.Drawing.Point(494, 279);
            this.btnDiscordServer.Name = "btnDiscordServer";
            this.btnDiscordServer.Size = new System.Drawing.Size(219, 88);
            this.btnDiscordServer.TabIndex = 3;
            this.btnDiscordServer.Text = "Abrir o Discord";
            this.btnDiscordServer.UseVisualStyleBackColor = true;
            this.btnDiscordServer.Click += new System.EventHandler(this.btnDiscordServer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.totalplayers);
            this.panel1.Controls.Add(this.nplayers);
            this.panel1.Controls.Add(this.btnDiscordServer);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Location = new System.Drawing.Point(22, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 420);
            this.panel1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label nplayers;
        private System.Windows.Forms.Label totalplayers;
        private System.Windows.Forms.Button btnDiscordServer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

