using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class GameOver : Form
    {
        public GameOver(double monero, int hackCount, string currentTarget, List<string> purchasedItems, bool isVictory)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            var highScore = HighScoreManager.LoadHighScore();
            labelSummary.ForeColor = isVictory ? System.Drawing.Color.LimeGreen : System.Drawing.Color.Red;
            labelSummary.Text = isVictory ? "Victory! Regime Taken Down!" : "Game Over! RAIDED BY ALPHABET BOYS";
            if (isVictory)
            {
                this.pictureBox2.BackgroundImage = global::BlueTeamerRole.Properties.Resources.blackman;
            } else
            {
                this.pictureBox2.BackgroundImage = global::BlueTeamerRole.Properties.Resources.alphabetboys;
            }
            labelStats.Text = $"Final Monero: {monero:F2} XMR\n" +
                              $"Hacks Completed: {hackCount}\n" +
                              $"Last Target: {currentTarget}\n" +
                              $"Purchased Items: {(purchasedItems.Count > 0 ? string.Join(", ", purchasedItems) : "None")}\n" +
                              $"\nHigh Score:\nMonero: {highScore.Monero:F2} XMR\nHacks: {highScore.Hacks}\nTarget: {highScore.Target}";
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }
    }
}