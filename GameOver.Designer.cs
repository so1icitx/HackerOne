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
            this.SuspendLayout();
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.ForeColor = System.Drawing.Color.Red;
            this.labelSummary.Location = new System.Drawing.Point(20, 20);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(110, 22);
            this.labelSummary.TabIndex = 0;
            this.labelSummary.Text = "Game Over!";
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.BackColor = System.Drawing.Color.Transparent;
            this.labelStats.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStats.ForeColor = System.Drawing.Color.Lime;
            this.labelStats.Location = new System.Drawing.Point(403, 175);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(27, 19);
            this.labelStats.TabIndex = 1;
            this.labelStats.Text = "nm";
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Black;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMenu.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.Lime;
            this.buttonMenu.Location = new System.Drawing.Point(20, 500);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(150, 40);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Return to MainMenu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.labelSummary);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Button buttonMenu;
    }
}