﻿using System;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class DesktopMenu : Form
    {
        private Main mainForm;
        private MainMenu mainMenu; // Store MainMenu instance

        public DesktopMenu()
        {
            InitializeComponent();
            this.Load += DesktopMenu_Load;
        }

        private void DesktopMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.buttonHighScore.Location = new System.Drawing.Point(1400, 53); // Top-right position
        }

        private void buttonValorant_Click(object sender, EventArgs e)
        {
            // Debug: Log PlayerName to check for reset
            System.Diagnostics.Debug.WriteLine($"Debug: PlayerName = {GameState.PlayerName ?? "null"}");
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new Main(this);
                mainForm.FormClosed += (s, args) => this.Close();
            }
            this.Hide();
            mainForm.Show();
        }

        private void buttonTorBrowser_Click(object sender, EventArgs e)
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new Main(this);
                mainForm.FormClosed += (s, args) => this.Close();
            }

            Form torForm = new Form
            {
                FormBorderStyle = FormBorderStyle.Sizable,
                StartPosition = FormStartPosition.CenterScreen,
                ClientSize = new System.Drawing.Size(800, 600),
                BackColor = System.Drawing.Color.Black,
                Text = "Tor Browser",
                BackgroundImage = global::BlueTeamerRole.Properties.Resources.tor1,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            };

            TextBox searchBar = new TextBox
            {
                Location = new System.Drawing.Point(210, 200),
                Size = new System.Drawing.Size(750, 40),
                Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Black,
                BackColor = System.Drawing.Color.White
            };
            Button goButton = new Button
            {
                Location = new System.Drawing.Point(960, 200),
                Size = new System.Drawing.Size(150, 40),
                Text = "Go",
                Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Black,
                BackColor = System.Drawing.Color.White
            };
            Button backButton = new Button
            {
                Location = new System.Drawing.Point(27, 365),
                Size = new System.Drawing.Size(150, 50),
                Text = "Back to Desktop",
                Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.MediumPurple,
                BackColor = System.Drawing.Color.Black
            };
            goButton.Click += (s, args) =>
            {
                if (mainForm != null && !mainForm.IsDisposed)
                {
                    mainForm.TxtTerminal.AppendText("Connected to secrethacker.onion\r\n");
                    MarketForm marketForm = new MarketForm(this);
                    marketForm.FormClosed += (s2, args2) =>
                    {
                        if (!mainForm.IsDisposed)
                            mainForm.Show();
                    };
                    torForm.Close();
                    marketForm.Show();
                    mainForm.Hide();
                }
                else
                {
                    MessageBox.Show("Main form is unavailable!");
                }
            };
            backButton.Click += (s, args) =>
            {
                torForm.Close();
                this.Show();
            };
            torForm.Load += (s, args) =>
            {
                torForm.FormBorderStyle = FormBorderStyle.None;
                torForm.Bounds = Screen.PrimaryScreen.Bounds;
                searchBar.Size = new System.Drawing.Size(600, 120);
                searchBar.Location = new System.Drawing.Point(470, 415);
                goButton.Size = new System.Drawing.Size(120, 60);
                goButton.Location = new System.Drawing.Point(1070, 400);
                backButton.Size = new System.Drawing.Size(300, 82);
                backButton.Location = new System.Drawing.Point(27, 730);
            };
            torForm.Controls.Add(searchBar);
            torForm.Controls.Add(goButton);
            torForm.Controls.Add(backButton);
            torForm.FormClosed += (s, args) => this.Show();
            torForm.Show();
            this.Hide();
        }

        private void buttonCryptoMining_Click(object sender, EventArgs e)
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new Main(this);
                mainForm.FormClosed += (s, args) => this.Close();
            }
            MiningApp miningForm = new MiningApp(this);
            miningForm.FormClosed += (s, args) => this.Show();
            miningForm.Show();
            this.Hide();
        }

        private void buttonHighScore_Click(object sender, EventArgs e)
        {
            var highScore = HighScoreManager.LoadHighScore();
            MessageBox.Show($"High Score:\nMonero: {highScore.Monero:F2} XMR\nHacks: {highScore.Hacks}\nTarget: {highScore.Target}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Return to Main Menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(GameState.PlayerName))
                {
                    // Player has already entered their alias, go directly to MainMenu
                    if (mainMenu == null || mainMenu.IsDisposed)
                    {
                        mainMenu = new MainMenu();
                        mainMenu.FormClosed += (s, args) => this.Close();
                    }
                    this.Hide();
                    mainMenu.Show();
                }
                else
                {
                    // New player, allow StoryForm -> NameForm sequence
                    mainMenu = new MainMenu();
                    mainMenu.FormClosed += (s, args) => this.Close();
                    this.Hide();
                    mainMenu.Show();
                }
            }
        }

        private void DesktopMenu_Load_1(object sender, EventArgs e)
        {
        }
    }
}