namespace BlueTeamerRole
{
    partial class DesktopMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonValorant = new System.Windows.Forms.Button();
            this.buttonTorBrowser = new System.Windows.Forms.Button();
            this.buttonCryptoMining = new System.Windows.Forms.Button();
            this.buttonHighScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonValorant
            // 
            this.buttonValorant.BackColor = System.Drawing.Color.Transparent;
            this.buttonValorant.BackgroundImage = global::BlueTeamerRole.Properties.Resources.val;
            this.buttonValorant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonValorant.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValorant.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonValorant.Location = new System.Drawing.Point(45, 55);
            this.buttonValorant.Margin = new System.Windows.Forms.Padding(4);
            this.buttonValorant.Name = "buttonValorant";
            this.buttonValorant.Size = new System.Drawing.Size(103, 96);
            this.buttonValorant.TabIndex = 0;
            this.buttonValorant.UseVisualStyleBackColor = false;
            this.buttonValorant.Click += new System.EventHandler(this.buttonValorant_Click);
            // 
            // buttonTorBrowser
            // 
            this.buttonTorBrowser.BackColor = System.Drawing.Color.Transparent;
            this.buttonTorBrowser.BackgroundImage = global::BlueTeamerRole.Properties.Resources.tor_browser_icon_189268332;
            this.buttonTorBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTorBrowser.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTorBrowser.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonTorBrowser.Location = new System.Drawing.Point(45, 212);
            this.buttonTorBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTorBrowser.Name = "buttonTorBrowser";
            this.buttonTorBrowser.Size = new System.Drawing.Size(100, 100);
            this.buttonTorBrowser.TabIndex = 1;
            this.buttonTorBrowser.UseVisualStyleBackColor = false;
            this.buttonTorBrowser.Click += new System.EventHandler(this.buttonTorBrowser_Click);
            // 
            // buttonCryptoMining
            // 
            this.buttonCryptoMining.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCryptoMining.BackgroundImage = global::BlueTeamerRole.Properties.Resources._1;
            this.buttonCryptoMining.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCryptoMining.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCryptoMining.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonCryptoMining.Location = new System.Drawing.Point(45, 370);
            this.buttonCryptoMining.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCryptoMining.Name = "buttonCryptoMining";
            this.buttonCryptoMining.Size = new System.Drawing.Size(100, 100);
            this.buttonCryptoMining.TabIndex = 2;
            this.buttonCryptoMining.UseVisualStyleBackColor = false;
            this.buttonCryptoMining.Click += new System.EventHandler(this.buttonCryptoMining_Click);
            // 
            // buttonHighScore
            // 
            this.buttonHighScore.BackColor = System.Drawing.Color.Transparent;
            this.buttonHighScore.BackgroundImage = global::BlueTeamerRole.Properties.Resources.bin;
            this.buttonHighScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHighScore.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHighScore.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonHighScore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHighScore.Location = new System.Drawing.Point(928, 53);
            this.buttonHighScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHighScore.Name = "buttonHighScore";
            this.buttonHighScore.Size = new System.Drawing.Size(120, 120);
            this.buttonHighScore.TabIndex = 3;
            this.buttonHighScore.UseVisualStyleBackColor = false;
            this.buttonHighScore.Click += new System.EventHandler(this.buttonHighScore_Click);
            // 
            // DesktopMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BlueTeamerRole.Properties.Resources.lindows;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.buttonValorant);
            this.Controls.Add(this.buttonTorBrowser);
            this.Controls.Add(this.buttonCryptoMining);
            this.Controls.Add(this.buttonHighScore);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DesktopMenu";
            this.Text = "Desktop";
            this.Load += new System.EventHandler(this.DesktopMenu_Load_1);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonValorant;
        private System.Windows.Forms.Button buttonTorBrowser;
        private System.Windows.Forms.Button buttonCryptoMining;
        private System.Windows.Forms.Button buttonHighScore;
    }
}