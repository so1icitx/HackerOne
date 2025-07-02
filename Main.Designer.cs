namespace BlueTeamerRole
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
            this.buttonHack = new System.Windows.Forms.Button();
            this.labelmonero = new System.Windows.Forms.Label();
            this.labeltarget = new System.Windows.Forms.Label();
            this.labelRaid = new System.Windows.Forms.Label();
            this.progressTarget = new System.Windows.Forms.ProgressBar();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.buttonMarket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHack
            // 
            this.buttonHack.BackColor = System.Drawing.Color.Black;
            this.buttonHack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonHack.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHack.ForeColor = System.Drawing.Color.Lime;
            this.buttonHack.Location = new System.Drawing.Point(300, 400);
            this.buttonHack.Name = "buttonHack";
            this.buttonHack.Size = new System.Drawing.Size(200, 80);
            this.buttonHack.TabIndex = 0;
            this.buttonHack.Text = "HACK";
            this.buttonHack.UseVisualStyleBackColor = false;
            this.buttonHack.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelmonero
            // 
            this.labelmonero.AutoSize = true;
            this.labelmonero.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmonero.ForeColor = System.Drawing.Color.Lime;
            this.labelmonero.Location = new System.Drawing.Point(20, 20);
            this.labelmonero.Name = "labelmonero";
            this.labelmonero.Size = new System.Drawing.Size(99, 19);
            this.labelmonero.TabIndex = 1;
            this.labelmonero.Text = "XMR : 0.00";
            // 
            // labeltarget
            // 
            this.labeltarget.AutoSize = true;
            this.labeltarget.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltarget.ForeColor = System.Drawing.Color.Lime;
            this.labeltarget.Location = new System.Drawing.Point(20, 50);
            this.labeltarget.Name = "labeltarget";
            this.labeltarget.Size = new System.Drawing.Size(207, 19);
            this.labeltarget.TabIndex = 2;
            this.labeltarget.Text = "Target: Public Servers";
            // 
            // labelRaid
            // 
            this.labelRaid.AutoSize = true;
            this.labelRaid.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaid.ForeColor = System.Drawing.Color.Lime;
            this.labelRaid.Location = new System.Drawing.Point(20, 80);
            this.labelRaid.Name = "labelRaid";
            this.labelRaid.Size = new System.Drawing.Size(153, 19);
            this.labelRaid.TabIndex = 3;
            this.labelRaid.Text = "Raid Chance: 10%";
            this.labelRaid.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressTarget
            // 
            this.progressTarget.Location = new System.Drawing.Point(20, 110);
            this.progressTarget.Maximum = 50;
            this.progressTarget.Name = "progressTarget";
            this.progressTarget.Size = new System.Drawing.Size(300, 20);
            this.progressTarget.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressTarget.TabIndex = 4;
            // 
            // txtTerminal
            // 
            this.txtTerminal.BackColor = System.Drawing.Color.Black;
            this.txtTerminal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminal.ForeColor = System.Drawing.Color.Lime;
            this.txtTerminal.Location = new System.Drawing.Point(20, 154);
            this.txtTerminal.Multiline = true;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.ReadOnly = true;
            this.txtTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTerminal.Size = new System.Drawing.Size(760, 200);
            this.txtTerminal.TabIndex = 5;
            // 
            // buttonMarket
            // 
            this.buttonMarket.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMarket.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarket.ForeColor = System.Drawing.Color.White;
            this.buttonMarket.Location = new System.Drawing.Point(20, 509);
            this.buttonMarket.Name = "buttonMarket";
            this.buttonMarket.Size = new System.Drawing.Size(150, 40);
            this.buttonMarket.TabIndex = 6;
            this.buttonMarket.Text = "Dark Web Market";
            this.buttonMarket.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.buttonMarket);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.progressTarget);
            this.Controls.Add(this.labelRaid);
            this.Controls.Add(this.labeltarget);
            this.Controls.Add(this.labelmonero);
            this.Controls.Add(this.buttonHack);
            this.ForeColor = System.Drawing.Color.BurlyWood;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHack;
        private System.Windows.Forms.Label labelmonero;
        private System.Windows.Forms.Label labeltarget;
        private System.Windows.Forms.Label labelRaid;
        private System.Windows.Forms.ProgressBar progressTarget;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Button buttonMarket;
    }
}