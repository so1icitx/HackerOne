namespace BlueTeamerRole
{
    partial class MiningApp
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
            this.labelMonero = new System.Windows.Forms.Label();
            this.labelWallet = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelMiningRate = new System.Windows.Forms.Label();
            this.listViewPcParts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // labelMonero
            // 
            this.labelMonero.BackColor = System.Drawing.Color.Black;
            this.labelMonero.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonero.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelMonero.Location = new System.Drawing.Point(36, 31);
            this.labelMonero.Name = "labelMonero";
            this.labelMonero.Size = new System.Drawing.Size(400, 49);
            this.labelMonero.TabIndex = 0;
            this.labelMonero.Text = "XMR: 0.00";
            // 
            // labelWallet
            // 
            this.labelWallet.BackColor = System.Drawing.Color.Black;
            this.labelWallet.Font = new System.Drawing.Font("Consolas", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWallet.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelWallet.Location = new System.Drawing.Point(36, 80);
            this.labelWallet.Name = "labelWallet";
            this.labelWallet.Size = new System.Drawing.Size(1000, 40);
            this.labelWallet.TabIndex = 1;
            this.labelWallet.Text = "Wallet: 4AdkWjX8pL2z3qN7mQvT5xY6ZcK9rF1uG2h3jK4mN5pQ6rS7tU8vW9xY0";
            this.labelWallet.Click += new System.EventHandler(this.labelWallet_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonBack.Location = new System.Drawing.Point(36, 619);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(200, 62);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back to Desktop";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelMiningRate
            // 
            this.labelMiningRate.BackColor = System.Drawing.Color.Black;
            this.labelMiningRate.Font = new System.Drawing.Font("Consolas", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiningRate.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelMiningRate.Location = new System.Drawing.Point(36, 120);
            this.labelMiningRate.Name = "labelMiningRate";
            this.labelMiningRate.Size = new System.Drawing.Size(400, 40);
            this.labelMiningRate.TabIndex = 3;
            this.labelMiningRate.Text = "Mining Rate: 0.00 XMR/min";
            // 
            // listViewPcParts
            // 
            this.listViewPcParts.BackColor = System.Drawing.Color.Black;
            this.listViewPcParts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPcParts.ForeColor = System.Drawing.Color.LimeGreen;
            this.listViewPcParts.HideSelection = false;
            this.listViewPcParts.Location = new System.Drawing.Point(36, 187);
            this.listViewPcParts.Name = "listViewPcParts";
            this.listViewPcParts.Size = new System.Drawing.Size(300, 200);
            this.listViewPcParts.TabIndex = 4;
            this.listViewPcParts.UseCompatibleStateImageBehavior = false;
            this.listViewPcParts.View = System.Windows.Forms.View.Details;
            // 
            // MiningApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.labelMonero);
            this.Controls.Add(this.labelWallet);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelMiningRate);
            this.Controls.Add(this.listViewPcParts);
            this.Name = "MiningApp";
            this.Text = "Crypto Mining App";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label labelMonero;
        private System.Windows.Forms.Label labelWallet;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelMiningRate;
        private System.Windows.Forms.ListView listViewPcParts;
    }
}