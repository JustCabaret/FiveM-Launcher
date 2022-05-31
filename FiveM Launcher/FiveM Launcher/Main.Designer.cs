
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.nplayers = new System.Windows.Forms.Label();
            this.totalplayers = new System.Windows.Forms.Label();
            this.btnDiscordServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(73, 91);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(160, 88);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // nplayers
            // 
            this.nplayers.AutoSize = true;
            this.nplayers.Location = new System.Drawing.Point(104, 41);
            this.nplayers.Name = "nplayers";
            this.nplayers.Size = new System.Drawing.Size(35, 13);
            this.nplayers.TabIndex = 1;
            this.nplayers.Text = "label1";
            // 
            // totalplayers
            // 
            this.totalplayers.AutoSize = true;
            this.totalplayers.Location = new System.Drawing.Point(169, 40);
            this.totalplayers.Name = "totalplayers";
            this.totalplayers.Size = new System.Drawing.Size(35, 13);
            this.totalplayers.TabIndex = 2;
            this.totalplayers.Text = "label1";
            // 
            // btnDiscordServer
            // 
            this.btnDiscordServer.Location = new System.Drawing.Point(73, 219);
            this.btnDiscordServer.Name = "btnDiscordServer";
            this.btnDiscordServer.Size = new System.Drawing.Size(160, 88);
            this.btnDiscordServer.TabIndex = 3;
            this.btnDiscordServer.Text = "Entrar";
            this.btnDiscordServer.UseVisualStyleBackColor = true;
            this.btnDiscordServer.Click += new System.EventHandler(this.btnDiscordServer_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiscordServer);
            this.Controls.Add(this.totalplayers);
            this.Controls.Add(this.nplayers);
            this.Controls.Add(this.btnEntrar);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label nplayers;
        private System.Windows.Forms.Label totalplayers;
        private System.Windows.Forms.Button btnDiscordServer;
    }
}

