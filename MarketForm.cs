using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class MarketForm : Form
    {
        private DesktopMenu desktopMenu;

        public MarketForm(DesktopMenu desktop)
        {
            InitializeComponent();
            this.desktopMenu = desktop;
            this.Load += MarketForm_Load;
        }

        private void MarketForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.CreateControl(); // Force handle creation
            InitializeMarketTabs();
            UpdateUI();
        }

        public new void Show()
        {
            base.Show();
            UpdateUI();
        }

        private void InitializeMarketTabs()
        {
            if (listViewVpnProxy == null || listViewDrugs == null || listViewHacks == null || listViewPcParts == null)
            {
                MessageBox.Show("ListView controls are null!");
                return;
            }

            listViewVpnProxy.Items.Clear();
            listViewDrugs.Items.Clear();
            listViewHacks.Items.Clear();
            listViewPcParts.Items.Clear();

            foreach (var listView in new[] { listViewVpnProxy, listViewDrugs, listViewHacks, listViewPcParts })
            {
                listView.Columns.Clear();
                listView.Columns.Add("Item", 200);
                listView.Columns.Add("Effect", 300);
                listView.Columns.Add("Cost (XMR)", 100);
                listView.Columns.Add("Action", 100);
            }

            var vpnProxyItems = new[]
            {
                new[] { "ExpressVPN", "-3% raid chance", "80", "Buy" },
                new[] { "PIA Proxy", "-3% raid chance", "90", "Buy" },
                new[] { "Surfshark", "-3% raid chance", "70", "Buy" },
                new[] { "ProtonVPN", "-4% raid chance", "100", "Buy" },
                new[] { "NordVPN", "-4% raid chance", "130", "Buy" },
                new[] { "CyberGhost", "-3% raid chance", "110", "Buy" },
                new[] { "VyprVPN", "-3% raid chance", "100", "Buy" },
                new[] { "Mullvad VPN", "-10% raid chance", "300", "Buy" },
                new[] { "Windscribe", "-5% raid chance", "200", "Buy" },
                new[] { "AirVPN", "-4% raid chance", "150", "Buy" },
                new[] { "Tor Proxy", "-5% raid chance", "250", "Buy" },
                new[] { "IPVanish", "-4% raid chance", "180", "Buy" }
            };
            var drugItems = new[]
            {
                new[] { "Crypto Dust", "+50% hack XMR for 5 hacks", "50", "Buy" },
                new[] { "Dark Stim", "+50% hack XMR for 5 hacks", "60", "Buy" },
                new[] { "Neon Haze", "+50% hack XMR for 5 hacks", "55", "Buy" },
                new[] { "Shadow Root", "+50% hack XMR for 5 hacks", "80", "Buy" },
                new[] { "Nightshade", "+50% hack XMR for 5 hacks", "90", "Buy" },
                new[] { "Void Capsule", "+50% hack XMR for 5 hacks", "85", "Buy" },
                new[] { "Blackout Powder", "+50% hack XMR for 5 hacks", "120", "Buy" },
                new[] { "Ghost Haze", "+50% hack XMR for 5 hacks", "110", "Buy" },
                new[] { "Phantom Dust", "+50% hack XMR for 5 hacks", "115", "Buy" },
                new[] { "Quantum Spike", "+50% hack XMR for 5 hacks", "150", "Buy" },
                new[] { "Nitro Shard", "+50% hack XMR for 5 hacks", "140", "Buy" },
                new[] { "Dark Pulse", "+50% hack XMR for 5 hacks", "145", "Buy" }
            };
            var hackItems = new[]
            {
                new[] { "LockBit", "5 XMR per hack", "120", "Buy" },
                new[] { "Clop", "7 XMR per hack", "150", "Buy" },
                new[] { "R蛇", "6 XMR per hack", "130", "Buy" },
                new[] { "Lumma Stealer", "10 XMR per hack", "250", "Buy" },
                new[] { "REvil", "12 XMR per hack", "300", "Buy" },
                new[] { "Egregor", "11 XMR per hack", "270", "Buy" },
                new[] { "BlackCat", "20 XMR per hack", "400", "Buy" },
                new[] { "Medusa", "25 XMR per hack", "450", "Buy" },
                new[] { "Hive", "22 XMR per hack", "420", "Buy" },
                new[] { "Conti", "50 XMR per hack", "800", "Buy" },
                new[] { "DarkSide", "40 XMR per hack", "700", "Buy" },
                new[] { "Locky", "45 XMR per hack", "750", "Buy" }
            };
            var pcPartItems = new[]
            {
                new[] { "RTX 3060", "8 XMR/10s", "200", "Buy" },
                new[] { "i5-12400", "5 XMR/10s", "120", "Buy" },
                new[] { "GTX 1650", "6 XMR/10s", "150", "Buy" },
                new[] { "Ryzen 7", "10 XMR/10s", "250", "Buy" },
                new[] { "RTX 3070", "9 XMR/10s", "220", "Buy" },
                new[] { "i7-12700", "7 XMR/10s", "180", "Buy" },
                new[] { "RTX 4080", "12 XMR/10s", "350", "Buy" },
                new[] { "i9-12900K", "10 XMR/10s", "300", "Buy" },
                new[] { "Ryzen 9", "11 XMR/10s", "320", "Buy" },
                new[] { "RTX 4090", "15 XMR/10s", "500", "Buy" },
                new[] { "Threadripper", "12 XMR/10s", "400", "Buy" },
                new[] { "A100 GPU", "14 XMR/10s", "450", "Buy" }
            };

            foreach (var item in vpnProxyItems)
                if (!GameState.PurchasedItems.Contains(item[0]))
                    listViewVpnProxy.Items.Add(new ListViewItem(item));
            foreach (var item in drugItems)
                if (!GameState.PurchasedItems.Contains(item[0]))
                    listViewDrugs.Items.Add(new ListViewItem(item));
            foreach (var item in hackItems)
                if (!GameState.PurchasedItems.Contains(item[0]))
                    listViewHacks.Items.Add(new ListViewItem(item));
            foreach (var item in pcPartItems)
                if (!GameState.PurchasedItems.Contains(item[0]))
                    listViewPcParts.Items.Add(new ListViewItem(item));
        }

        private void UpdateUI()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateUI));
                return;
            }

            if (!IsDisposed && IsHandleCreated && labelMonero != null)
            {
                // Increase label size to handle larger numbers
                labelMonero.Size = new System.Drawing.Size(300, 50);
                labelMonero.Location = new System.Drawing.Point(50, 50); // Moved to avoid overlap
                labelMonero.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
                labelMonero.ForeColor = System.Drawing.Color.LimeGreen;
                labelMonero.Text = $"XMR: {GameState.Monero:F2}";
                labelMonero.Refresh();
                labelMonero.Update();
                labelMonero.Invalidate();
                System.Diagnostics.Debug.WriteLine($"MarketForm UpdateUI: XMR={GameState.Monero:F2}, labelMonero.Text={labelMonero.Text}");
            }
            else
            {
                string debugMsg = $"MarketForm UI error: IsDisposed={IsDisposed}, IsHandleCreated={IsHandleCreated}, labelMonero={(labelMonero == null ? "null" : "not null")}";
                System.Diagnostics.Debug.WriteLine(debugMsg);
                MessageBox.Show(debugMsg);
            }
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            ListView listView = (ListView)sender;
            var hitTest = listView.HitTest(e.Location);
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

                if (GameState.Monero >= cost)
                {
                    GameState.Monero -= cost;
                    GameState.PurchasedItems.Add(name);
                    switch (name)
                    {
                        case "ExpressVPN":
                        case "PIA Proxy":
                        case "Surfshark":
                        case "CyberGhost":
                        case "VyprVPN":
                            GameState.RaidChanceReduction += 0.03;
                            GameState.BaseRaidChance = Math.Max(0.005, GameState.BaseRaidChance - 0.03);
                            break;
                        case "ProtonVPN":
                        case "AirVPN":
                        case "IPVanish":
                            GameState.RaidChanceReduction += 0.04;
                            GameState.BaseRaidChance = Math.Max(0.005, GameState.BaseRaidChance - 0.04);
                            break;
                        case "Mullvad VPN":
                            GameState.RaidChanceReduction += 0.10;
                            GameState.BaseRaidChance = Math.Max(0.005, GameState.BaseRaidChance - 0.10);
                            break;
                        case "Windscribe":
                        case "Tor Proxy":
                            GameState.RaidChanceReduction += 0.05;
                            GameState.BaseRaidChance = Math.Max(0.005, GameState.BaseRaidChance - 0.05);
                            break;
                        case "Crypto Dust":
                        case "Dark Stim":
                        case "Neon Haze":
                        case "Shadow Root":
                        case "Nightshade":
                        case "Void Capsule":
                        case "Blackout Powder":
                        case "Ghost Haze":
                        case "Phantom Dust":
                        case "Quantum Spike":
                        case "Nitro Shard":
                        case "Dark Pulse":
                            GameState.DrugEffectHacksLeft = 5;
                            break;
                        case "LockBit":
                            if (GameState.MoneroPerHack < 5.0) GameState.MoneroPerHack = 5.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "Clop":
                            if (GameState.MoneroPerHack < 7.0) GameState.MoneroPerHack = 7.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "R蛇":
                            if (GameState.MoneroPerHack < 6.0) GameState.MoneroPerHack = 6.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "Lumma Stealer":
                            if (GameState.MoneroPerHack < 10.0) GameState.MoneroPerHack = 10.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "REvil":
                            if (GameState.MoneroPerHack < 12.0) GameState.MoneroPerHack = 12.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "Egregor":
                            if (GameState.MoneroPerHack < 11.0) GameState.MoneroPerHack = 11.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "BlackCat":
                            if (GameState.MoneroPerHack < 20.0) GameState.MoneroPerHack = 20.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "Medusa":
                            if (GameState.MoneroPerHack < 25.0) GameState.MoneroPerHack = 25.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "Hive":
                            if (GameState.MoneroPerHack < 22.0) GameState.MoneroPerHack = 22.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "Conti":
                            if (GameState.MoneroPerHack < 50.0) GameState.MoneroPerHack = 50.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "DarkSide":
                            if (GameState.MoneroPerHack < 40.0) GameState.MoneroPerHack = 40.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "Locky":
                            if (GameState.MoneroPerHack < 45.0) GameState.MoneroPerHack = 45.0;
                            GameState.CurrentMalware = name;
                            break;
                        case "RTX 3060":
                            GameState.MiningRate = 8.0;
                            break;
                        case "i5-12400":
                            GameState.MiningRate = 5.0;
                            break;
                        case "GTX 1650":
                            GameState.MiningRate = 6.0;
                            break;
                        case "Ryzen 7":
                            GameState.MiningRate = 10.0;
                            break;
                        case "RTX 3070":
                            GameState.MiningRate = 9.0;
                            break;
                        case "i7-12700":
                            GameState.MiningRate = 7.0;
                            break;
                        case "RTX 4080":
                            GameState.MiningRate = 12.0;
                            break;
                        case "i9-12900K":
                            GameState.MiningRate = 10.0;
                            break;
                        case "Ryzen 9":
                            GameState.MiningRate = 11.0;
                            break;
                        case "RTX 4090":
                            GameState.MiningRate = 15.0;
                            break;
                        case "Threadripper":
                            GameState.MiningRate = 12.0;
                            break;
                        case "A100 GPU":
                            GameState.MiningRate = 14.0;
                            break;
                    }
                    MessageBox.Show($"Purchased {name}! Raid Chance Reduction: {GameState.RaidChanceReduction:F2}%");
                    UpdateUI();
                    listView.Items.Remove(item);
                }
                else
                {
                    MessageBox.Show("Not enough Monero!");
                }
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
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

        private void MarketForm_Load_1(object sender, EventArgs e)
        {
        }

        private void listViewVpnProxy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}