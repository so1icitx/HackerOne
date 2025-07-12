using System;
using System.Windows.Forms;
using System.Text;

namespace BlueTeamerRole
{
    public partial class MainMenu : Form
    {
        private Label animatedLabel;
        private Timer animationTimer;
        private string targetText = "HackerOne";
        private int phase = 0; // 0: Scramble, 1: Morph, 2: Pause, 3: Gibberish
        private int charIndex = 0; // For morphing phase
        private int pauseTicks = 0; // For pause phase
        private int gibberishTicks = 0; // For gibberish phase
        private Random random = new Random();
        private string currentText = "";
        private DesktopMenu desktopMenu; // Store DesktopMenu instance

        public MainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.BackColor = System.Drawing.Color.Black;

            // Initialize animated label
            animatedLabel = new Label
            {
                Location = new System.Drawing.Point((this.Bounds.Width - 1000) / 2, 30),
                Size = new System.Drawing.Size(1000, 200),
                ForeColor = System.Drawing.Color.LimeGreen,
                Font = new System.Drawing.Font("Consolas", 80F, System.Drawing.FontStyle.Bold),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Text = GenerateRandomString(9)
            };
            this.Controls.Add(animatedLabel);

            // Initialize animation timer
            animationTimer = new Timer
            {
                Interval = 100 // 100ms per frame
            };
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }

        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }
            return sb.ToString();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            switch (phase)
            {
                case 0: // Scramble (1 second)
                    animatedLabel.Text = GenerateRandomString(9);
                    animatedLabel.Font = new System.Drawing.Font("Consolas", 72 + random.Next(16), System.Drawing.FontStyle.Bold);
                    charIndex++;
                    if (charIndex >= 10) // 10 frames = 1 second
                    {
                        phase = 1;
                        charIndex = 0;
                        currentText = GenerateRandomString(9);
                    }
                    break;

                case 1: // Morph to HackerOne (1 second)
                    if (charIndex < targetText.Length)
                    {
                        char[] chars = currentText.ToCharArray();
                        chars[charIndex] = targetText[charIndex];
                        currentText = new string(chars);
                        animatedLabel.Text = currentText;
                        animatedLabel.Font = new System.Drawing.Font("Consolas", 72 + random.Next(16), System.Drawing.FontStyle.Bold);
                        charIndex++;
                    }
                    else
                    {
                        animatedLabel.Text = targetText;
                        animatedLabel.Font = new System.Drawing.Font("Consolas", 80F, System.Drawing.FontStyle.Bold);
                        phase = 2;
                        charIndex = 0;
                    }
                    break;

                case 2: // Pause (2 seconds)
                    pauseTicks++;
                    if (pauseTicks >= 20) // 20 frames = 2 seconds
                    {
                        phase = 3;
                        pauseTicks = 0;
                        gibberishTicks = 0;
                    }
                    break;

                case 3: // Gibberish (2 seconds)
                    animatedLabel.Text = GenerateRandomString(9);
                    animatedLabel.Font = new System.Drawing.Font("Consolas", 72 + random.Next(16), System.Drawing.FontStyle.Bold);
                    gibberishTicks++;
                    if (gibberishTicks >= 20) // 20 frames = 2 seconds
                    {
                        phase = 0; // Reset to scramble
                        charIndex = 0;
                        gibberishTicks = 0;
                    }
                    break;
            }
        }

        private void mainbutton1_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
            if (!string.IsNullOrEmpty(GameState.PlayerName))
            {
                // Player has already entered their alias, go directly to DesktopMenu
                if (desktopMenu == null || desktopMenu.IsDisposed)
                {
                    desktopMenu = new DesktopMenu();
                    desktopMenu.FormClosed += (s, args) => this.Close();
                }
                this.Hide();
                desktopMenu.Show();
            }
            else
            {
                // New player, show StoryForm
                StoryForm storyForm = new StoryForm();
                storyForm.FormClosed += (s, args) => this.Close();
                storyForm.Show();
                this.Hide();
            }
        }

        private void mainbutton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Options not implemented yet!");
        }

        private void mainbutton3_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
            Application.Exit();
        }
    }
}