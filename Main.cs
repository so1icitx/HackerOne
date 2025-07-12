using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class Main : Form
    {
        private DesktopMenu desktopMenu;
        private double totalMined = 0.0;
        private string currentTarget = "Public Servers";
        private int hacksToNextTarget = 50;
        private int hackCount = 0;
        private double tempRaidChanceMod = 0.0;
        private double tempMiningBoost = 1.0;
        private int tempMiningTicks = 0;
        private int raidWarnings = 0;
        private double moneroMultiplier = 1.0;
        private Random random = new Random();
        private Timer miningTimer;

        public TextBox TxtTerminal { get { return txtTerminal; } }

        private double GetMinRaidChance()
        {
            if (currentTarget == "Public Servers") return 0.005;
            if (currentTarget == "Corporate Networks") return 0.05;
            if (currentTarget == "Alphabet Boys") return 0.10;
            return 0.15;
        }

        public Main(DesktopMenu desktop)
        {
            InitializeComponent();
            desktopMenu = desktop;
            miningTimer = new Timer();
            miningTimer.Interval = 10000;
            miningTimer.Tick += MiningTimer_Tick;
            miningTimer.Start();
            this.KeyPreview = true;
            this.KeyDown += Main_KeyDown;
            this.FormClosing += Main_FormClosing;
            this.Load += Main_Load;
            UpdateUI();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.buttonBack.Location = new System.Drawing.Point(20, 800);
            this.buttonBack.Size = new System.Drawing.Size(300, 100);
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            miningTimer.Stop();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                miningTimer.Stop();
                Application.Exit();
            }
        }

        private void UpdateUI()
        {
            if (!this.IsDisposed && IsHandleCreated)
            {
                labelmonero.Text = $"XMR: {GameState.Monero:F2}";
                labeltarget.Text = $"Target: {currentTarget}";
                labelRaid.Text = $"Raid Chance: {((GameState.BaseRaidChance + tempRaidChanceMod) * 100):F1}% | Warnings: {raidWarnings}/3";
                progressTarget.Value = Math.Min(hackCount, hacksToNextTarget);
                progressTarget.Maximum = hacksToNextTarget;
                txtTerminal.ScrollToCaret();
            }
        }

        public void RefreshUI()
        {
            UpdateUI();
        }

        private void buttonHack_Click(object sender, EventArgs e)
        {
            double hackReward = GameState.MoneroPerHack * moneroMultiplier * (GameState.DrugEffectHacksLeft > 0 ? 1.5 : 1.0);
            if (hackCount >= hacksToNextTarget / 2) hackReward *= 0.8;
            GameState.Monero += hackReward;
            hackCount++;
            if (!this.IsDisposed && IsHandleCreated)
                txtTerminal.AppendText($"Sending {GameState.CurrentMalware}... Success! +{hackReward:F2} XMR\r\n");
            if (GameState.DrugEffectHacksLeft > 0)
            {
                GameState.DrugEffectHacksLeft--;
                if (GameState.DrugEffectHacksLeft == 0 && !this.IsDisposed && IsHandleCreated)
                    txtTerminal.AppendText("Drug effect expired!\r\n");
            }

            if (hackCount % 10 == 0)
            {
                double eventChance = random.NextDouble();
                if (eventChance < 0.15)
                {
                    GameState.Monero += 50;
                    if (!this.IsDisposed && IsHandleCreated)
                        txtTerminal.AppendText("Dark Web Bonus: +50 XMR!\r\n");
                }
                else if (eventChance < 0.30)
                {
                    tempRaidChanceMod = 0.05;
                    if (!this.IsDisposed && IsHandleCreated)
                        txtTerminal.AppendText("Firewall Alert: +5% raid chance for 10 hacks!\r\n");
                }
                else if (eventChance < 0.45)
                {
                    tempMiningBoost = 2.0;
                    tempMiningTicks = 5;
                    if (!this.IsDisposed && IsHandleCreated)
                        txtTerminal.AppendText("Overclock Boost: 2x mining rate for 50 seconds!\r\n");
                }
            }

            if (hackCount >= hacksToNextTarget)
            {
                ProgressToNextTarget();
                return;
            }

            if (random.NextDouble() < GameState.BaseRaidChance + tempRaidChanceMod)
            {
                GameState.Monero *= 0.95;
                raidWarnings++;
                if (!this.IsDisposed && IsHandleCreated)
                    txtTerminal.AppendText($"RAID DETECTED! Lost 5% XMR! Warning {raidWarnings}/3\r\n");
                if (raidWarnings >= 3)
                {
                    miningTimer.Stop();
                    HighScoreManager.SaveHighScore(GameState.Monero, hackCount, currentTarget);
                    GameOver gameOverForm = new GameOver(GameState.Monero, hackCount, currentTarget, GameState.PurchasedItems, false);
                    gameOverForm.FormClosed += (s, args) => Application.Exit();
                    gameOverForm.Show();
                    this.Hide();
                    return;
                }
            }
            if (hackCount % 10 == 0) tempRaidChanceMod = 0.0;
            UpdateUI();
        }

        private void ProgressToNextTarget()
        {
            hackCount = 0;
            if (currentTarget == "Public Servers")
            {
                currentTarget = "Corporate Networks";
                hacksToNextTarget = 60;
                GameState.BaseRaidChance = 0.10 - GameState.RaidChanceReduction;
                if (!this.IsDisposed && IsHandleCreated)
                    txtTerminal.AppendText("Progressed to Corporate Networks!\r\n");
            }
            else if (currentTarget == "Corporate Networks")
            {
                currentTarget = "Alphabet Boys";
                hacksToNextTarget = 70;
                GameState.BaseRaidChance = 0.20 - GameState.RaidChanceReduction;
                if (!this.IsDisposed && IsHandleCreated)
                    txtTerminal.AppendText("Progressed to Alphabet Boys!\r\n");
            }
            else if (currentTarget == "Alphabet Boys")
            {
                currentTarget = "Elite Hackers";
                hacksToNextTarget = 50;
                GameState.BaseRaidChance = 0.30 - GameState.RaidChanceReduction;
                if (!this.IsDisposed && IsHandleCreated)
                    txtTerminal.AppendText("Progressed to Elite Hackers!\r\n");
            }
            else
            {
                if (!this.IsDisposed && IsHandleCreated)
                    txtTerminal.AppendText("All targets hacked! You’ve taken down the regime!\r\n");
                miningTimer.Stop();
                HighScoreManager.SaveHighScore(GameState.Monero, hackCount, currentTarget);
                GameOver gameOverForm = new GameOver(GameState.Monero, hackCount, currentTarget, GameState.PurchasedItems, true);
                gameOverForm.FormClosed += (s, args) => Application.Exit();
                gameOverForm.Show();
                this.Hide();
                return;
            }
            UpdateUI();
        }

        private void MiningTimer_Tick(object sender, EventArgs e)
        {
            if (!this.IsDisposed && IsHandleCreated)
            {
                double mined = GameState.MiningRate * tempMiningBoost;
                GameState.Monero += mined;
                totalMined += mined;
                txtTerminal.AppendText($"Mined {mined:F2} XMR\r\n");
                if (tempMiningBoost > 1.0)
                {
                    tempMiningTicks--;
                    if (tempMiningTicks <= 0)
                    {
                        tempMiningBoost = 1.0;
                        txtTerminal.AppendText("Overclock Boost expired!\r\n");
                    }
                }
                UpdateUI();
            }
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            miningTimer.Stop();
            MarketForm marketForm = new MarketForm(desktopMenu);
            marketForm.FormClosed += (s, args) => { if (!this.IsDisposed) { this.Show(); miningTimer.Start(); } };
            marketForm.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            miningTimer.Stop();
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            miningTimer.Stop();
            Application.Exit();
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
        }

        private void labelmonero_Click(object sender, EventArgs e)
        {
        }

        private void labelRaid_Click(object sender, EventArgs e)
        {
        }
    }
}