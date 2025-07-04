namespace BlueTeamerRole
{
    partial class GameOver
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
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelStats = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSummary
            // 
            this.labelSummary.Font = new System.Drawing.Font("Consolas", 30.25F, System.Drawing.FontStyle.Bold);
            this.labelSummary.Location = new System.Drawing.Point(400, 100);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(600, 100);
            this.labelSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStats
            // 
            this.labelStats.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.labelStats.Location = new System.Drawing.Point(400, 200);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(600, 400);
            this.labelStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStats.ForeColor = System.Drawing.Color.LimeGreen;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonMenu.Location = new System.Drawing.Point(550, 600);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(300, 100);
            this.buttonMenu.Text = "Main Menu";
            this.buttonMenu.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonMenu.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(400, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOver";
            this.Text = "GameOver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}