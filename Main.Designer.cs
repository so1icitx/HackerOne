namespace BlueTeamerRole
{
    partial class Main
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
            this.labelmonero = new System.Windows.Forms.Label();
            this.labeltarget = new System.Windows.Forms.Label();
            this.labelRaid = new System.Windows.Forms.Label();
            this.progressTarget = new System.Windows.Forms.ProgressBar();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.buttonHack = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelmonero
            // 
            this.labelmonero.BackColor = System.Drawing.Color.Black;
            this.labelmonero.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmonero.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelmonero.Location = new System.Drawing.Point(46, 9);
            this.labelmonero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmonero.Name = "labelmonero";
            this.labelmonero.Size = new System.Drawing.Size(400, 98);
            this.labelmonero.TabIndex = 0;
            this.labelmonero.Text = "XMR: 50.00";
            this.labelmonero.Click += new System.EventHandler(this.labelmonero_Click);
            // 
            // labeltarget
            // 
            this.labeltarget.BackColor = System.Drawing.Color.Black;
            this.labeltarget.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltarget.ForeColor = System.Drawing.Color.LimeGreen;
            this.labeltarget.Location = new System.Drawing.Point(36, 99);
            this.labeltarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltarget.Name = "labeltarget";
            this.labeltarget.Size = new System.Drawing.Size(692, 98);
            this.labeltarget.TabIndex = 1;
            this.labeltarget.Text = "Target: Public Servers";
            // 
            // labelRaid
            // 
            this.labelRaid.BackColor = System.Drawing.Color.Black;
            this.labelRaid.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaid.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelRaid.Location = new System.Drawing.Point(36, 197);
            this.labelRaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRaid.Name = "labelRaid";
            this.labelRaid.Size = new System.Drawing.Size(805, 98);
            this.labelRaid.TabIndex = 2;
            this.labelRaid.Text = "Raid Chance: 2.0% | Warnings: 0/3";
            this.labelRaid.Click += new System.EventHandler(this.labelRaid_Click);
            // 
            // progressTarget
            // 
            this.progressTarget.BackColor = System.Drawing.Color.DarkGray;
            this.progressTarget.ForeColor = System.Drawing.Color.Green;
            this.progressTarget.Location = new System.Drawing.Point(53, 290);
            this.progressTarget.Margin = new System.Windows.Forms.Padding(4);
            this.progressTarget.Name = "progressTarget";
            this.progressTarget.Size = new System.Drawing.Size(537, 41);
            this.progressTarget.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressTarget.TabIndex = 3;
            // 
            // txtTerminal
            // 
            this.txtTerminal.BackColor = System.Drawing.Color.Black;
            this.txtTerminal.Font = new System.Drawing.Font("Consolas", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminal.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtTerminal.Location = new System.Drawing.Point(22, 339);
            this.txtTerminal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerminal.Multiline = true;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.ReadOnly = true;
            this.txtTerminal.Size = new System.Drawing.Size(1509, 450);
            this.txtTerminal.TabIndex = 4;
            // 
            // buttonHack
            // 
            this.buttonHack.BackColor = System.Drawing.Color.Black;
            this.buttonHack.Font = new System.Drawing.Font("Consolas", 25.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHack.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonHack.Location = new System.Drawing.Point(502, 775);
            this.buttonHack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHack.Name = "buttonHack";
            this.buttonHack.Size = new System.Drawing.Size(633, 174);
            this.buttonHack.TabIndex = 5;
            this.buttonHack.Text = "HACK";
            this.buttonHack.UseVisualStyleBackColor = false;
            this.buttonHack.Click += new System.EventHandler(this.buttonHack_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonBack.Location = new System.Drawing.Point(43, 619);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(200, 62);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back to Desktop";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.labelmonero);
            this.Controls.Add(this.labeltarget);
            this.Controls.Add(this.labelRaid);
            this.Controls.Add(this.progressTarget);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.buttonHack);
            this.Controls.Add(this.buttonBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelmonero;
        private System.Windows.Forms.Label labeltarget;
        private System.Windows.Forms.Label labelRaid;
        private System.Windows.Forms.ProgressBar progressTarget;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Button buttonHack;
        private System.Windows.Forms.Button buttonBack;
    }
}