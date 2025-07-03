namespace BlueTeamerRole
{
    partial class GameOver
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
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelStats = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSummary
            // 
            this.labelSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.ForeColor = System.Drawing.Color.Red;
            this.labelSummary.Location = new System.Drawing.Point(27, 25);
            this.labelSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(610, 27);
            this.labelSummary.TabIndex = 0;
            this.labelSummary.Text = "Game Over! YOU GOT RAIDED BY THE ALPHABET BOYS";
            this.labelSummary.Click += new System.EventHandler(this.labelSummary_Click);
            // 
            // labelStats
            // 
            this.labelStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStats.AutoSize = true;
            this.labelStats.BackColor = System.Drawing.Color.Transparent;
            this.labelStats.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStats.ForeColor = System.Drawing.Color.Lime;
            this.labelStats.Location = new System.Drawing.Point(537, 215);
            this.labelStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(32, 23);
            this.labelStats.TabIndex = 1;
            this.labelStats.Text = "nm";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMenu.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMenu.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(27, 615);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(200, 49);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Return to MainMenu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::BlueTeamerRole.Properties.Resources.alphabetboys;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 373);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.labelSummary);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}