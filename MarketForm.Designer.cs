using System.Windows.Forms;

namespace BlueTeamerRole
{
    partial class MarketForm
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
            this.tabControlMarket = new System.Windows.Forms.TabControl();
            this.tabVpnProxy = new System.Windows.Forms.TabPage();
            this.listViewVpnProxy = new System.Windows.Forms.ListView();
            this.tabDrugs = new System.Windows.Forms.TabPage();
            this.listViewDrugs = new System.Windows.Forms.ListView();
            this.tabHacks = new System.Windows.Forms.TabPage();
            this.listViewHacks = new System.Windows.Forms.ListView();
            this.tabPcParts = new System.Windows.Forms.TabPage();
            this.listViewPcParts = new System.Windows.Forms.ListView();
            this.labelMonero = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.tabControlMarket.SuspendLayout();
            this.tabVpnProxy.SuspendLayout();
            this.tabDrugs.SuspendLayout();
            this.tabHacks.SuspendLayout();
            this.tabPcParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMarket
            // 
            this.tabControlMarket.Controls.Add(this.tabVpnProxy);
            this.tabControlMarket.Controls.Add(this.tabDrugs);
            this.tabControlMarket.Controls.Add(this.tabHacks);
            this.tabControlMarket.Controls.Add(this.tabPcParts);
            this.tabControlMarket.Font = new System.Drawing.Font("Consolas", 16.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMarket.ForeColor = System.Drawing.Color.White;
            this.tabControlMarket.Location = new System.Drawing.Point(36, 203);
            this.tabControlMarket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlMarket.Name = "tabControlMarket";
            this.tabControlMarket.SelectedIndex = 0;
            this.tabControlMarket.Size = new System.Drawing.Size(1000, 400);
            this.tabControlMarket.TabIndex = 0;
            // 
            // tabVpnProxy
            // 
            this.tabVpnProxy.Controls.Add(this.listViewVpnProxy);
            this.tabVpnProxy.Location = new System.Drawing.Point(4, 38);
            this.tabVpnProxy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabVpnProxy.Name = "tabVpnProxy";
            this.tabVpnProxy.Size = new System.Drawing.Size(992, 309);
            this.tabVpnProxy.TabIndex = 0;
            this.tabVpnProxy.Text = "VPNs/Proxies";
            // 
            // listViewVpnProxy
            // 
            this.listViewVpnProxy.BackColor = System.Drawing.Color.Black;
            this.listViewVpnProxy.Font = new System.Drawing.Font("Consolas", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewVpnProxy.ForeColor = System.Drawing.Color.LimeGreen;
            this.listViewVpnProxy.FullRowSelect = true;
            this.listViewVpnProxy.HideSelection = false;
            this.listViewVpnProxy.Location = new System.Drawing.Point(13, 12);
            this.listViewVpnProxy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewVpnProxy.Name = "listViewVpnProxy";
            this.listViewVpnProxy.Size = new System.Drawing.Size(972, 326);
            this.listViewVpnProxy.TabIndex = 0;
            this.listViewVpnProxy.UseCompatibleStateImageBehavior = false;
            this.listViewVpnProxy.View = System.Windows.Forms.View.Details;
            this.listViewVpnProxy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // tabDrugs
            // 
            this.tabDrugs.Controls.Add(this.listViewDrugs);
            this.tabDrugs.Location = new System.Drawing.Point(4, 38);
            this.tabDrugs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDrugs.Name = "tabDrugs";
            this.tabDrugs.Size = new System.Drawing.Size(992, 109);
            this.tabDrugs.TabIndex = 1;
            this.tabDrugs.Text = "Drugs";
            // 
            // listViewDrugs
            // 
            this.listViewDrugs.BackColor = System.Drawing.Color.Black;
            this.listViewDrugs.Font = new System.Drawing.Font("Consolas", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDrugs.ForeColor = System.Drawing.Color.LimeGreen;
            this.listViewDrugs.FullRowSelect = true;
            this.listViewDrugs.HideSelection = false;
            this.listViewDrugs.Location = new System.Drawing.Point(13, 12);
            this.listViewDrugs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewDrugs.Name = "listViewDrugs";
            this.listViewDrugs.Size = new System.Drawing.Size(972, 326);
            this.listViewDrugs.TabIndex = 0;
            this.listViewDrugs.UseCompatibleStateImageBehavior = false;
            this.listViewDrugs.View = System.Windows.Forms.View.Details;
            this.listViewDrugs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // tabHacks
            // 
            this.tabHacks.Controls.Add(this.listViewHacks);
            this.tabHacks.Location = new System.Drawing.Point(4, 38);
            this.tabHacks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHacks.Name = "tabHacks";
            this.tabHacks.Size = new System.Drawing.Size(992, 109);
            this.tabHacks.TabIndex = 2;
            this.tabHacks.Text = "Hacks";
            // 
            // listViewHacks
            // 
            this.listViewHacks.BackColor = System.Drawing.Color.Black;
            this.listViewHacks.Font = new System.Drawing.Font("Consolas", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHacks.ForeColor = System.Drawing.Color.LimeGreen;
            this.listViewHacks.FullRowSelect = true;
            this.listViewHacks.HideSelection = false;
            this.listViewHacks.Location = new System.Drawing.Point(13, 12);
            this.listViewHacks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewHacks.Name = "listViewHacks";
            this.listViewHacks.Size = new System.Drawing.Size(972, 326);
            this.listViewHacks.TabIndex = 0;
            this.listViewHacks.UseCompatibleStateImageBehavior = false;
            this.listViewHacks.View = System.Windows.Forms.View.Details;
            this.listViewHacks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // tabPcParts
            // 
            this.tabPcParts.Controls.Add(this.listViewPcParts);
            this.tabPcParts.Location = new System.Drawing.Point(4, 38);
            this.tabPcParts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPcParts.Name = "tabPcParts";
            this.tabPcParts.Size = new System.Drawing.Size(992, 109);
            this.tabPcParts.TabIndex = 3;
            this.tabPcParts.Text = "PC Parts";
            // 
            // listViewPcParts
            // 
            this.listViewPcParts.BackColor = System.Drawing.Color.Black;
            this.listViewPcParts.Font = new System.Drawing.Font("Consolas", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPcParts.ForeColor = System.Drawing.Color.LimeGreen;
            this.listViewPcParts.FullRowSelect = true;
            this.listViewPcParts.HideSelection = false;
            this.listViewPcParts.Location = new System.Drawing.Point(13, 12);
            this.listViewPcParts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewPcParts.Name = "listViewPcParts";
            this.listViewPcParts.Size = new System.Drawing.Size(972, 326);
            this.listViewPcParts.TabIndex = 0;
            this.listViewPcParts.UseCompatibleStateImageBehavior = false;
            this.listViewPcParts.View = System.Windows.Forms.View.Details;
            this.listViewPcParts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // labelMonero
            // 
            this.labelMonero.BackColor = System.Drawing.Color.Black;
            this.labelMonero.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonero.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelMonero.Location = new System.Drawing.Point(36, 31);
            this.labelMonero.Size = new System.Drawing.Size(200, 49);
            this.labelMonero.TabIndex = 0;
            this.labelMonero.Text = "XMR: 0.00";
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.DarkGray;
            this.Backbutton.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.Color.LimeGreen;
            this.Backbutton.Location = new System.Drawing.Point(36, 660);
            this.Backbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(300, 122);
            this.Backbutton.TabIndex = 2;
            this.Backbutton.Text = "Exit Browser";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // MarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.tabControlMarket);
            this.Controls.Add(this.labelMonero);
            this.Controls.Add(this.Backbutton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MarketForm";
            this.Text = "Dark Web Market - secrethacker.onion";
            this.Load += new System.EventHandler(this.MarketForm_Load_1);
            this.tabControlMarket.ResumeLayout(false);
            this.tabVpnProxy.ResumeLayout(false);
            this.tabDrugs.ResumeLayout(false);
            this.tabHacks.ResumeLayout(false);
            this.tabPcParts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControlMarket;
        private System.Windows.Forms.TabPage tabVpnProxy;
        private System.Windows.Forms.TabPage tabDrugs;
        private System.Windows.Forms.TabPage tabHacks;
        private System.Windows.Forms.TabPage tabPcParts;
        private System.Windows.Forms.ListView listViewVpnProxy;
        private System.Windows.Forms.ListView listViewDrugs;
        private System.Windows.Forms.ListView listViewHacks;
        private System.Windows.Forms.ListView listViewPcParts;
        private System.Windows.Forms.Label labelMonero;
        private System.Windows.Forms.Button Backbutton;
    }
}