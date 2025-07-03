using System;

namespace BlueTeamerRole
{
    partial class MarketForm
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
            this.labelMonero = new System.Windows.Forms.Label();
            this.listViewMarket = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMonero
            // 
            this.labelMonero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMonero.AutoSize = true;
            this.labelMonero.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonero.ForeColor = System.Drawing.Color.Lime;
            this.labelMonero.Location = new System.Drawing.Point(27, 25);
            this.labelMonero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonero.Name = "labelMonero";
            this.labelMonero.Size = new System.Drawing.Size(109, 23);
            this.labelMonero.TabIndex = 0;
            this.labelMonero.Text = "XMR: 0.00";
            // 
            // listViewMarket
            // 
            this.listViewMarket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewMarket.BackColor = System.Drawing.Color.Black;
            this.listViewMarket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDescription,
            this.columnCost,
            this.colAction});
            this.listViewMarket.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMarket.ForeColor = System.Drawing.Color.Lime;
            this.listViewMarket.FullRowSelect = true;
            this.listViewMarket.GridLines = true;
            this.listViewMarket.HideSelection = false;
            this.listViewMarket.Location = new System.Drawing.Point(27, 74);
            this.listViewMarket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewMarket.Name = "listViewMarket";
            this.listViewMarket.Size = new System.Drawing.Size(985, 245);
            this.listViewMarket.TabIndex = 1;
            this.listViewMarket.UseCompatibleStateImageBehavior = false;
            this.listViewMarket.View = System.Windows.Forms.View.Details;
            this.listViewMarket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewMarket_MouseClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 350;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 350;
            // 
            // columnCost
            // 
            this.columnCost.Text = "XMR";
            this.columnCost.Width = 200;
            // 
            // colAction
            // 
            this.colAction.Text = "Action";
            this.colAction.Width = 200;
            // 
            // Backbutton
            // 
            this.Backbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Backbutton.BackColor = System.Drawing.Color.DarkGray;
            this.Backbutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.Color.White;
            this.Backbutton.Location = new System.Drawing.Point(27, 615);
            this.Backbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(200, 49);
            this.Backbutton.TabIndex = 2;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // MarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.listViewMarket);
            this.Controls.Add(this.labelMonero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MarketForm";
            this.Text = "MarketForm";
            this.Load += new System.EventHandler(this.MarketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label labelMonero;
        private System.Windows.Forms.ListView listViewMarket;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader columnCost;
        private System.Windows.Forms.ColumnHeader colAction;
        private System.Windows.Forms.Button Backbutton;
    }
}