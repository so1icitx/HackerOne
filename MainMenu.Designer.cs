namespace BlueTeamerRole
{
    partial class MainMenu
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
            this.mainbutton1 = new System.Windows.Forms.Button();
            this.mainbutton2 = new System.Windows.Forms.Button();
            this.mainbutton3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainbutton1
            // 
            this.mainbutton1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.mainbutton1.Location = new System.Drawing.Point(550, 500);
            this.mainbutton1.Name = "mainbutton1";
            this.mainbutton1.Size = new System.Drawing.Size(400, 100);
            this.mainbutton1.Text = "Start Game";
            this.mainbutton1.ForeColor = System.Drawing.Color.LimeGreen;
            this.mainbutton1.BackColor = System.Drawing.Color.DarkGray;
            this.mainbutton1.Click += new System.EventHandler(this.mainbutton1_Click);
            // 
            // mainbutton2
            // 
            this.mainbutton2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.mainbutton2.Location = new System.Drawing.Point(550, 600);
            this.mainbutton2.Name = "mainbutton2";
            this.mainbutton2.Size = new System.Drawing.Size(400, 100);
            this.mainbutton2.Text = "Options";
            this.mainbutton2.ForeColor = System.Drawing.Color.LimeGreen;
            this.mainbutton2.BackColor = System.Drawing.Color.DarkGray;
            this.mainbutton2.Click += new System.EventHandler(this.mainbutton2_Click);
            // 
            // mainbutton3
            // 
            this.mainbutton3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.mainbutton3.Location = new System.Drawing.Point(550, 700);
            this.mainbutton3.Name = "mainbutton3";
            this.mainbutton3.Size = new System.Drawing.Size(400, 100);
            this.mainbutton3.Text = "Exit";
            this.mainbutton3.ForeColor = System.Drawing.Color.LimeGreen;
            this.mainbutton3.BackColor = System.Drawing.Color.DarkGray;
            this.mainbutton3.Click += new System.EventHandler(this.mainbutton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(350, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.mainbutton1);
            this.Controls.Add(this.mainbutton2);
            this.Controls.Add(this.mainbutton3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button mainbutton1;
        private System.Windows.Forms.Button mainbutton2;
        private System.Windows.Forms.Button mainbutton3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}