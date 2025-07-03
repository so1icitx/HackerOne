using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class GameOver : Form
    {
        public GameOver(double monero, int hackCount, string currentTarget, List<string> purchasedItems)
        {
            InitializeComponent();
            this.labelStats.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.Font = new System.Drawing.Font("Consolas", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.Location = new System.Drawing.Point(-100, -100);
            this.pictureBox1.Location = new System.Drawing.Point(-300, 50);
            this.pictureBox1.Size = new System.Drawing.Size(470, 373);
            this.buttonMenu.Location = new System.Drawing.Point(-300,  550);
            this.buttonMenu.Size = new System.Drawing.Size(300, 100);
            this.buttonMenu.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStats.Location = new System.Drawing.Point(300, 215);
            labelStats.Text = $"Final Monero: {monero:F2} XMR\n" +
                            $"Hacks Completed: {hackCount}\n" +
                            $"Last Target: {currentTarget}\n" +
                            $"Purchased Items: {(purchasedItems.Count > 0 ? string.Join(", ", purchasedItems) : "None")}";
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void labelSummary_Click(object sender, EventArgs e)
        {

        }
    }
}
