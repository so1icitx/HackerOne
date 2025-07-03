using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class Main : Form
    {
        private double monero = 100.0;
        private string currentMalware = "Phishing Email";
        private double moneroPerHack = 2.0;
        private string currentTarget = "Public Servers";
        private int hacksToNextTarget = 100;
        private int hackCount = 0;
        private double baseRaidChance = 0.01;
        private double miningRate = 7.0;
        private double raidChanceReduction = 0.0; // New field to track total raid chance reduction
        private Random random = new Random();
        private Timer miningTimer;
        private List<string> purchasedItems = new List<string>();

        public double Monero { get { return monero; } set { monero = value; } }
        public double MoneroPerHack { get { return moneroPerHack; } set { moneroPerHack = value; } }
        public string CurrentMalware { get { return currentMalware; } set { currentMalware = value; } }
        public double BaseRaidChance { get { return baseRaidChance; } set { baseRaidChance = Math.Max(0, value); } }
        public double MiningRate { get { return miningRate; } set { miningRate = value; } }
        public double RaidChanceReduction { get { return raidChanceReduction; } set { raidChanceReduction = value; } } // New property
        public List<string> PurchasedItems { get { return purchasedItems; } }

        public Main()
        {
            InitializeComponent();
            miningTimer = new Timer();
            miningTimer.Interval = 10000;
            miningTimer.Tick += MiningTimer_Tick;
            miningTimer.Start();
            UpdateUI();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            // Custom UI scaling from your code
            this.buttonMarket.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarket.Location = new System.Drawing.Point(20, 720);
            this.buttonMarket.Size = new System.Drawing.Size(300, 100);
            // monero
            this.labelmonero.Size = new System.Drawing.Size(300, 80);
            this.labelmonero.Location = new System.Drawing.Point(27, 25);
            this.labelmonero.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // target
            this.labeltarget.Size = new System.Drawing.Size(300, 80);
            this.labeltarget.Location = new System.Drawing.Point(20, 70);
            this.labeltarget.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // raid chance
            this.labelRaid.Size = new System.Drawing.Size(300, 80);
            this.labelRaid.Location = new System.Drawing.Point(20, 115);
            this.labelRaid.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // progress bar
            this.progressTarget.Size = new System.Drawing.Size(400, 25);
            this.progressTarget.Location = new System.Drawing.Point(27, 160);
            this.progressTarget.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // terminal
            this.txtTerminal.Size = new System.Drawing.Size(1500, 245);
            this.txtTerminal.Location = new System.Drawing.Point(27, 200);
            this.txtTerminal.Font = new System.Drawing.Font("Consolas", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // hack button
            this.buttonHack.Font = new System.Drawing.Font("Consolas", 20.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHack.Location = new System.Drawing.Point(350, 450);
            this.buttonHack.Size = new System.Drawing.Size(800, 120);
        }

        private void UpdateUI()
        {
            labelmonero.Text = $"XMR: {monero:F2}";
            labeltarget.Text = $"Target: {currentTarget}";
            labelRaid.Text = $"Raid Chance: {(baseRaidChance * 100):F0}%";
            progressTarget.Value = hackCount;
            progressTarget.Maximum = hacksToNextTarget;
        }

        public void RefreshUI()
        {
            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monero += moneroPerHack;
            hackCount++;
            txtTerminal.AppendText($"Sending {currentMalware}... Success! +{moneroPerHack:F2} XMR\r\n");
            if (random.NextDouble() < baseRaidChance)
            {
                txtTerminal.AppendText("RAID DETECTED! Game Over!\r\n");
                miningTimer.Stop();
                GameOver gameOverForm = new GameOver(monero, hackCount, currentTarget, purchasedItems);
                gameOverForm.FormClosed += (s, args) => this.Close();
                gameOverForm.Show();
                return;
            }
            if (hackCount >= hacksToNextTarget)
            {
                ProgressToNextTarget();
            }
            UpdateUI();
        }

        private void ProgressToNextTarget()
        {
            hackCount = 0;
            if (currentTarget == "Public Servers")
            {
                currentTarget = "Corporate Networks";
                hacksToNextTarget = 150;
                baseRaidChance = 0.11 - raidChanceReduction; // Apply reduction after setting base value
            }
            else if (currentTarget == "Corporate Networks")
            {
                currentTarget = "Alphabet Boys";
                hacksToNextTarget = 215;
                baseRaidChance = 0.25 - raidChanceReduction; // Apply reduction after setting base value
            }
            else if (currentTarget == "Alphabet Boys")
            {
                currentTarget = "Elite Hackers";
                hacksToNextTarget = 300;
                baseRaidChance = 0.40 - raidChanceReduction; // Apply reduction after setting base value
            }
            else
            {
                txtTerminal.AppendText("All targets hacked! You’ve taken down the regime!\r\n");
                miningTimer.Stop();
                GameOver gameOverForm = new GameOver(monero, hackCount, currentTarget, purchasedItems);
                gameOverForm.FormClosed += (s, args) => this.Close();
                gameOverForm.Show();
            }
            UpdateUI();
        }

        private void MiningTimer_Tick(object sender, EventArgs e)
        {
            monero += miningRate;
            txtTerminal.AppendText($"Mined {miningRate:F2} XMR\r\n");
            UpdateUI();
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            MarketForm marketForm = new MarketForm(this, purchasedItems);
            marketForm.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Empty; initialization handled in constructor
        }
    }
}