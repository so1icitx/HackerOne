using System;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void mainbutton1_Click(object sender, EventArgs e)
        {
            StoryForm storyForm = new StoryForm();
            storyForm.FormClosed += (s, args) => this.Close();
            storyForm.Show();
            this.Hide();
        }

        private void mainbutton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Options not implemented yet!");
        }

        private void mainbutton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var highScore = HighScoreManager.LoadHighScore();
            MessageBox.Show($"High Score:\nMonero: {highScore.Monero:F2} XMR\nHacks: {highScore.Hacks}\nTarget: {highScore.Target}");
        }
    }
}