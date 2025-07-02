using System;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class Main : Form
    {
        private double monero = 0.0;
        private string currentMalware = "Phishing Email";
        private double moneroPerHack = 1.0;
        private string currentTarget = "Public Servers";
        private int hacksToNextTarget = 100;
        private int hackCount = 0;
        private double baseRaidChance = 0.10;
        private double miningRate = 0.1;
        private Random random = new Random();
        private Timer miningTimer;

        public double Monero { get { return monero; } set { monero = value; } }
        public double MoneroPerHack { get { return moneroPerHack; } set { moneroPerHack = value; } }
        public string CurrentMalware { get { return currentMalware; } set { currentMalware = value; } }
        public double BaseRaidChance { get { return baseRaidChance; } set { baseRaidChance = Math.Max(0, value); } }
        public double MiningRate { get { return miningRate; } set { miningRate = value; } }

        public Main()
        {
            InitializeComponent();
            miningTimer = new Timer();
            miningTimer.Interval = 60000;
            miningTimer.Tick += MiningTimer_Tick;
            miningTimer.Start();
            UpdateUI();
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
                double loss = monero * (currentTarget == "Elite Hackers" ? 0.5 : 0.25);
                monero -= loss;
                txtTerminal.AppendText($"RAID DETECTED! Lost {loss:F2} XMR\r\n");
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
                hacksToNextTarget = 250;
                baseRaidChance = 0.20;
            }
            else if (currentTarget == "Corporate Networks")
            {
                currentTarget = "Alphabet Boys";
                hacksToNextTarget = 500;
                baseRaidChance = 0.30;
            }
            else if (currentTarget == "Alphabet Boys")
            {
                currentTarget = "Elite Hackers";
                hacksToNextTarget = 1000;
                baseRaidChance = 0.40;
            }
            else
            {
                txtTerminal.AppendText("All targets hacked! You’ve taken down the regime!\r\n");
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
            this.Hide();
            MarketForm marketForm = new MarketForm(this);
            marketForm.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            // Empty; initialization handled in constructor
        }
    }
}