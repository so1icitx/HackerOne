namespace BlueTeamerRole
{
    partial class Options
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
            this.play = new System.Windows.Forms.Button();
            this.xmr = new System.Windows.Forms.Button();
            this.egg = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play.BackColor = System.Drawing.Color.Black;
            this.play.Font = new System.Drawing.Font("Consolas", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.DarkOrchid;
            this.play.Location = new System.Drawing.Point(0, 0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(215, 82);
            this.play.TabIndex = 0;
            this.play.Text = "How to Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // xmr
            // 
            this.xmr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xmr.BackColor = System.Drawing.Color.Black;
            this.xmr.Font = new System.Drawing.Font("Consolas", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmr.ForeColor = System.Drawing.Color.DarkOrchid;
            this.xmr.Location = new System.Drawing.Point(0, 178);
            this.xmr.Name = "xmr";
            this.xmr.Size = new System.Drawing.Size(215, 82);
            this.xmr.TabIndex = 1;
            this.xmr.Text = "What is Monero (XMR)";
            this.xmr.UseVisualStyleBackColor = false;
            this.xmr.Click += new System.EventHandler(this.xmr_Click);
            // 
            // egg
            // 
            this.egg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.egg.BackColor = System.Drawing.Color.Black;
            this.egg.Font = new System.Drawing.Font("Consolas", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egg.ForeColor = System.Drawing.Color.DarkOrchid;
            this.egg.Location = new System.Drawing.Point(0, 379);
            this.egg.Name = "egg";
            this.egg.Size = new System.Drawing.Size(215, 82);
            this.egg.TabIndex = 2;
            this.egg.Text = "Easter Eggs";
            this.egg.UseVisualStyleBackColor = false;
            this.egg.Click += new System.EventHandler(this.egg_Click);
            // 
            // back
            // 
            this.back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.Font = new System.Drawing.Font("Consolas", 14.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.DarkOrchid;
            this.back.Location = new System.Drawing.Point(-400, 507);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(300, 161);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.egg);
            this.Controls.Add(this.xmr);
            this.Controls.Add(this.play);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button xmr;
        private System.Windows.Forms.Button egg;
        private System.Windows.Forms.Button back;
    }
}