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
            this.SuspendLayout();
            // 
            // mainbutton1
            // 
            this.mainbutton1.BackColor = System.Drawing.Color.Black;
            this.mainbutton1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainbutton1.ForeColor = System.Drawing.Color.MediumPurple;
            this.mainbutton1.Location = new System.Drawing.Point(733, 607);
            this.mainbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.mainbutton1.Name = "mainbutton1";
            this.mainbutton1.Size = new System.Drawing.Size(533, 123);
            this.mainbutton1.TabIndex = 0;
            this.mainbutton1.Text = "HACK THE PLANET";
            this.mainbutton1.UseVisualStyleBackColor = false;
            this.mainbutton1.Click += new System.EventHandler(this.mainbutton1_Click);
            // 
            // mainbutton2
            // 
            this.mainbutton2.BackColor = System.Drawing.Color.Black;
            this.mainbutton2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainbutton2.ForeColor = System.Drawing.Color.MediumPurple;
            this.mainbutton2.Location = new System.Drawing.Point(733, 738);
            this.mainbutton2.Margin = new System.Windows.Forms.Padding(4);
            this.mainbutton2.Name = "mainbutton2";
            this.mainbutton2.Size = new System.Drawing.Size(533, 123);
            this.mainbutton2.TabIndex = 1;
            this.mainbutton2.Text = "Options";
            this.mainbutton2.UseVisualStyleBackColor = false;
            this.mainbutton2.Click += new System.EventHandler(this.mainbutton2_Click);
            // 
            // mainbutton3
            // 
            this.mainbutton3.BackColor = System.Drawing.Color.Black;
            this.mainbutton3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainbutton3.ForeColor = System.Drawing.Color.MediumPurple;
            this.mainbutton3.Location = new System.Drawing.Point(733, 869);
            this.mainbutton3.Margin = new System.Windows.Forms.Padding(4);
            this.mainbutton3.Name = "mainbutton3";
            this.mainbutton3.Size = new System.Drawing.Size(533, 123);
            this.mainbutton3.TabIndex = 2;
            this.mainbutton3.Text = "Exit";
            this.mainbutton3.UseVisualStyleBackColor = false;
            this.mainbutton3.Click += new System.EventHandler(this.mainbutton3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.mainbutton1);
            this.Controls.Add(this.mainbutton2);
            this.Controls.Add(this.mainbutton3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button mainbutton1;
        private System.Windows.Forms.Button mainbutton2;
        private System.Windows.Forms.Button mainbutton3;
    }
}