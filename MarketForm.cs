using System;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class MarketForm : Form
    {
        private Main mainForm;
        private double raidChanceReduction = 0.0;

        public MarketForm(Main main)
        {
            InitializeComponent();
            mainForm = main;
            InitializeMarketItems();
            UpdateUI();
        }

        private void InitializeMarketItems()
        {
            listViewMarket.Items.Clear();
            listViewMarket.Items.Add(new ListViewItem(new[] { "Keylogger", "3 XMR per hack", "50", "Buy" }));
            listViewMarket.Items.Add(new ListViewItem(new[] { "Ransomware", "10 XMR per hack", "250", "Buy" }));
            listViewMarket.Items.Add(new ListViewItem(new[] { "RAT", "25 XMR per hack", "750", "Buy" }));
            listViewMarket.Items.Add(new ListViewItem(new[] { "Zero-Day Exploit", "100 XMR per hack", "2500", "Buy" }));
            listViewMarket.Items.Add(new ListViewItem(new[] { "ProtonVPN", "-5% raid chance", "75", "Buy" }));
            listViewMarket.Items.Add(new ListViewItem(new[] { "NordVPN", "-10% raid chance", "200", "Buy" }));
            listViewMarket.Items.Add(new ListViewItem(new[] { "Mullvad VPN", "-15% raid chance", "500", "Buy" }));
            listViewMarket.Items.Add(new ListViewItem(new[] { "Tor Proxy", "-10% raid chance", "150", "Buy" }));
            listViewMarket.Items.Add(new ListViewItem(new[] { "GPU Rig", "0.5 XMR/minute", "600", "Buy" }));
            listViewMarket.Items.Add(new ListViewItem(new[] { "ASIC Miner", "2 XMR/minute", "2000", "Buy" }));
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
                double cost = double.Parse(item.SubItems[2].Text);

                if (mainForm.Monero >= cost)
                {
                    mainForm.Monero -= cost;
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
                            raidChanceReduction += 0.10;
                            mainForm.BaseRaidChance -= 0.10;
                            break;
                        case "Mullvad VPN":
                            raidChanceReduction += 0.15;
                            mainForm.BaseRaidChance -= 0.15;
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
                    mainForm.RefreshUI(); // Use renamed method
                    listViewMarket.Items.Remove(item);
                }
                else
                {
                    MessageBox.Show("Not enough Monero!");
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewMarket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MarketForm_Load(object sender, EventArgs e)
        {
            // Empty; initialization handled in constructor
        }
    }
}