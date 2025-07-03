using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class MarketForm : Form
    {
        private Main mainForm;
        private List<string> purchasedItems;

        public MarketForm(Main main, List<string> purchasedItems)
        {
            InitializeComponent();
            mainForm = main;
            this.purchasedItems = purchasedItems;
            InitializeMarketItems();
            UpdateUI();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            // Custom UI scaling from your code
            // monero
            this.labelMonero.Size = new System.Drawing.Size(300, 80);
            this.labelMonero.Location = new System.Drawing.Point(27, 25);
            this.labelMonero.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // listViewMarket
            this.listViewMarket.Size = new System.Drawing.Size(1200, 500);
            this.listViewMarket.Location = new System.Drawing.Point(27, 100);
            this.listViewMarket.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // Back button
            this.Backbutton.Size = new System.Drawing.Size(250, 80);
            this.Backbutton.Location = new System.Drawing.Point(27, 750);
            this.Backbutton.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void InitializeMarketItems()
        {
            listViewMarket.Items.Clear();
            var items = new List<string[]>
            {
                new[] { "Keylogger", "5 XMR per hack", "70", "Buy" },
                new[] { "Ransomware", "10 XMR per hack", "200", "Buy" },
                new[] { "RAT", "25 XMR per hack", "500", "Buy" },
                new[] { "Zero-Day Exploit", "100 XMR per hack", "1200", "Buy" },
                new[] { "ProtonVPN", "-5% raid chance", "120", "Buy" },
                new[] { "NordVPN", "-5% raid chance", "200", "Buy" },
                new[] { "Mullvad VPN", "-20% raid chance", "500", "Buy" },
                new[] { "Tor Proxy", "-10% raid chance", "325", "Buy" },
                new[] { "GPU Rig", "70 XMR/min", "300", "Buy" },
                new[] { "ASIC Miner", "600 XMR/min", "800", "Buy" }
            };

            foreach (var item in items)
            {
                if (!purchasedItems.Contains(item[0]))
                {
                    listViewMarket.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void UpdateUI()
        {
            labelMonero.Text = $"XMR: {mainForm.Monero:F2}";
        }

        private void listViewMarket_MouseClick(object sender, MouseEventArgs e)
        {
            var hitTest = listViewMarket.HitTest(e.Location);
            if (hitTest.SubItem != null && hitTest.SubItem.Text == "Buy")
            {
                var item = hitTest.Item;
                string name = item.SubItems[0].Text;
                double cost;
                if (!double.TryParse(item.SubItems[2].Text, out cost))
                {
                    MessageBox.Show("Invalid cost format!");
                    return;
                }

                if (mainForm.Monero >= cost)
                {
                    mainForm.Monero -= cost;
                    purchasedItems.Add(name);
                    switch (name)
                    {
                        case "Keylogger":
                            mainForm.MoneroPerHack = 5.0;
                            mainForm.CurrentMalware = name;
                            break;
                        case "Ransomware":
                            mainForm.MoneroPerHack = 10.0;
                            mainForm.CurrentMalware = name;
                            break;
                        case "RAT":
                            mainForm.MoneroPerHack = 25.0;
                            mainForm.CurrentMalware = name;
                            break;
                        case "Zero-Day Exploit":
                            mainForm.MoneroPerHack = 100.0;
                            mainForm.CurrentMalware = name;
                            break;
                        case "ProtonVPN":
                            mainForm.RaidChanceReduction += 0.05;
                            mainForm.BaseRaidChance -= 0.05;
                            break;
                        case "NordVPN":
                            mainForm.RaidChanceReduction += 0.05;
                            mainForm.BaseRaidChance -= 0.05;
                            break;
                        case "Mullvad VPN":
                            mainForm.RaidChanceReduction += 0.20;
                            mainForm.BaseRaidChance -= 0.20;
                            break;
                        case "Tor Proxy":
                            mainForm.RaidChanceReduction += 0.10;
                            mainForm.BaseRaidChance -= 0.10;
                            break;
                        case "GPU Rig":
                            mainForm.MiningRate = 12;
                            break;
                        case "ASIC Miner":
                            mainForm.MiningRate = 25;
                            break;
                    }
                    MessageBox.Show($"Purchased {name}!");
                    UpdateUI();
                    mainForm.RefreshUI();
                    listViewMarket.Items.Remove(item);
                }
                else
                {
                    MessageBox.Show("Not enough Monero!");
                }
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MarketForm_Load(object sender, EventArgs e)
        {
            // Empty; initialization handled in constructor
        }
    }
}