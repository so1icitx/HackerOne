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
            this.mainbutton1 = new System.Windows.Forms.Button();
            this.mainbutton2 = new System.Windows.Forms.Button();
            this.mainbutton3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainbutton1
            // 
            this.mainbutton1.Font = new System.Drawing.Font("MingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainbutton1.Location = new System.Drawing.Point(392, 421);
            this.mainbutton1.Name = "mainbutton1";
            this.mainbutton1.Size = new System.Drawing.Size(404, 85);
            this.mainbutton1.TabIndex = 0;
            this.mainbutton1.Text = "HACK THE PLANET\r\n\r\n";
            this.mainbutton1.UseVisualStyleBackColor = true;
            // 
            // mainbutton2
            // 
            this.mainbutton2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainbutton2.Location = new System.Drawing.Point(402, 527);
            this.mainbutton2.Name = "mainbutton2";
            this.mainbutton2.Size = new System.Drawing.Size(379, 70);
            this.mainbutton2.TabIndex = 1;
            this.mainbutton2.Text = "OPTIONS";
            this.mainbutton2.UseVisualStyleBackColor = true;
            // 
            // mainbutton3
            // 
            this.mainbutton3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainbutton3.Location = new System.Drawing.Point(476, 625);
            this.mainbutton3.Name = "mainbutton3";
            this.mainbutton3.Size = new System.Drawing.Size(231, 52);
            this.mainbutton3.TabIndex = 2;
            this.mainbutton3.Text = "EXIT";
            this.mainbutton3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BlueTeamerRole.Properties.Resources.N1x_ejqB_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(339, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 403);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1194, 737);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainbutton3);
            this.Controls.Add(this.mainbutton2);
            this.Controls.Add(this.mainbutton1);
            this.HelpButton = true;
            this.Name = "MainMenu";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
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

