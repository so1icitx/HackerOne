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
            labelStats.Text = $"Final Monero: {monero:F2} XMR\n" +
                            $"Hacks Completed: {hackCount}\n" +
                            $"Last Target: {currentTarget}\n" +
                            $"Purchased Items: {(purchasedItems.Count > 0 ? string.Join(", ", purchasedItems) : "None")}";
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
