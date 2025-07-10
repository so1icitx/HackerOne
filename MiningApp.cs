using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class MiningApp : Form
    {
        private DesktopMenu desktopMenu;

        public MiningApp(DesktopMenu desktopMenu = null)
        {
            this.desktopMenu = desktopMenu;
            InitializeComponent();
            this.Shown += MiningApp_Shown;
            this.Load += MiningApp_Load;
        }

        private void MiningApp_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void MiningApp_Shown(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateUI));
                return;
            }

            if (!IsDisposed && IsHandleCreated && labelMonero != null && labelWallet != null && labelMiningRate != null && listViewPcParts != null)
            {
                labelMonero.Text = $"XMR: {GameState.Monero:F2}";
                labelWallet.Text = $"Wallet: {GameState.WalletAddress}";
                labelMiningRate.Text = $"Mining Rate: {(GameState.MiningRate * 6):F2} XMR/min";
                labelMonero.Refresh();
                labelWallet.Refresh();
                labelMiningRate.Refresh();

                listViewPcParts.Items.Clear();
                listViewPcParts.Columns.Clear();
                listViewPcParts.Columns.Add("PC Part", 200);
                var pcParts = new[] { "RTX 3060", "i5-12400", "GTX 1650", "Ryzen 7", "RTX 3070", "i7-12700", "RTX 4080", "i9-12900K", "Ryzen 9", "RTX 4090", "Threadripper", "A100 GPU" };
                foreach (var part in GameState.PurchasedItems.Where(p => pcParts.Contains(p)))
                {
                    listViewPcParts.Items.Add(new ListViewItem(part));
                }
                listViewPcParts.Refresh();
            }
            else
            {
                MessageBox.Show($"MiningApp UI error: Form disposed={IsDisposed}, IsHandleCreated={IsHandleCreated}, labelMonero={(labelMonero == null ? "null" : "not null")}, labelWallet={(labelWallet == null ? "null" : "not null")}, labelMiningRate={(labelMiningRate == null ? "null" : "not null")}, listViewPcParts={(listViewPcParts == null ? "null" : "not null")}");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (desktopMenu != null && !desktopMenu.IsDisposed)
            {
                desktopMenu.Show();
            }
            else
            {
                desktopMenu = new DesktopMenu();
                desktopMenu.FormClosed += (s, args) => Application.Exit();
                desktopMenu.Show();
            }
        }

        private void labelWallet_Click(object sender, EventArgs e)
        {
        }
    }
}