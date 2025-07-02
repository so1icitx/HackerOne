using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class MarketForm : Form
    {
        private Main mainForm;
        private List<string> purchasedItems;
        private double raidChanceReduction = 0.0;

        public MarketForm(Main main, List<string> purchasedItems)
        {
            InitializeComponent();
            mainForm = main;
            this.purchasedItems = purchasedItems; // Fixed: Use passed parameter
            InitializeMarketItems();
            UpdateUI();
        }

        private void InitializeMarketItems()
        {
            listViewMarket.Items.Clear();
            var items = new List<string[]>
            {
                new[] { "Keylogger", "3 XMR per hack", "150", "Buy" }, // Increased from 100
                new[] { "Ransomware", "10 XMR per hack", "800", "Buy" }, // Increased from 500
                new[] { "RAT", "25 XMR per hack", "2500", "Buy" }, // Increased from 1500
                new[] { "Zero-Day Exploit", "100 XMR per hack", "8000", "Buy" }, // Increased from 5000
                new[] { "ProtonVPN", "-5% raid chance", "300", "Buy" }, // Increased from 150
                new[] { "NordVPN", "-50% raid chance", "500", "Buy" }, // Increased from 400
                new[] { "Mullvad VPN", "-20% raid chance", "1500", "Buy" }, // Increased from 1000
                new[] { "Tor Proxy", "-10% raid chance", "500", "Buy" }, // Increased from 300
                new[] { "GPU Rig", "0.5 XMR/minute", "240", "Buy" }, // Increased from 1200
                new[] { "ASIC Miner", "2 XMR/minute", "1000", "Buy" } // Increased from 4000
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
                            mainForm.MoneroPerHack = 3.0;
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
                            raidChanceReduction += 0.05;
                            mainForm.BaseRaidChance -= 0.05;
                            break;
                        case "NordVPN":
                            raidChanceReduction += 0.05;
                            mainForm.BaseRaidChance -= 0.05;
                            break;
                        case "Mullvad VPN":
                            raidChanceReduction += 0.20;
                            mainForm.BaseRaidChance -= 0.20;
                            break;
                        case "Tor Proxy":
                            raidChanceReduction += 0.10;
                            mainForm.BaseRaidChance -= 0.10;
                            break;
                        case "GPU Rig":
                            mainForm.MiningRate = 0.5;
                            break;
                        case "ASIC Miner":
                            mainForm.MiningRate = 2.0;
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