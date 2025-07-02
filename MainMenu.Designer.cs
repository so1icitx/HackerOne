namespace BlueTeamerRole
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mainbutton1 = new System.Windows.Forms.Button();
            this.mainbutton2 = new System.Windows.Forms.Button();
            this.mainbutton3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainbutton1
            // 
            this.mainbutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mainbutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mainbutton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mainbutton1.Font = new System.Drawing.Font("MingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainbutton1.ForeColor = System.Drawing.Color.Black;
            this.mainbutton1.Location = new System.Drawing.Point(278, 352);
            this.mainbutton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainbutton1.Name = "mainbutton1";
            this.mainbutton1.Size = new System.Drawing.Size(351, 60);
            this.mainbutton1.TabIndex = 0;
            this.mainbutton1.Text = "HACK THE PLANET\r\n\r\n";
            this.mainbutton1.UseVisualStyleBackColor = true;
            this.mainbutton1.Click += new System.EventHandler(this.mainbutton1_Click);
            // 
            // mainbutton2
            // 
            this.mainbutton2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainbutton2.ForeColor = System.Drawing.Color.Black;
            this.mainbutton2.Location = new System.Drawing.Point(317, 424);
            this.mainbutton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainbutton2.Name = "mainbutton2";
            this.mainbutton2.Size = new System.Drawing.Size(284, 57);
            this.mainbutton2.TabIndex = 1;
            this.mainbutton2.Text = "OPTIONS";
            this.mainbutton2.UseVisualStyleBackColor = true;
            this.mainbutton2.Click += new System.EventHandler(this.mainbutton2_Click);
            // 
            // mainbutton3
            // 
            this.mainbutton3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainbutton3.Location = new System.Drawing.Point(376, 500);
            this.mainbutton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainbutton3.Name = "mainbutton3";
            this.mainbutton3.Size = new System.Drawing.Size(178, 52);
            this.mainbutton3.TabIndex = 2;
            this.mainbutton3.Text = "EXIT";
            this.mainbutton3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BlueTeamerRole.Properties.Resources.N1x_ejqB_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(254, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 327);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(896, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainbutton3);
            this.Controls.Add(this.mainbutton2);
            this.Controls.Add(this.mainbutton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "hackerone";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainbutton1;
        private System.Windows.Forms.Button mainbutton2;
        private System.Windows.Forms.Button mainbutton3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

