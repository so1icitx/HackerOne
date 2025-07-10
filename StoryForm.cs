using System;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class StoryForm : Form
    {
        private Label storyLabel;
        private Timer typingTimer;
        private string storyText = "In a neon-soaked city where corporations rule, you’re just another cog in the machine—a low-level tech worker drowned in code and debt. By day, you debug systems for a faceless megacorp, but by night, you chase whispers of freedom on the dark web. One late night, fueled by cheap energy drinks and desperation, you stumble across 'secrethacker.onion'—a hidden hub of renegade coders and cyber outlaws. They speak of taking down the system, of wealth in Monero, of power through hacks. A spark ignites in you. This is your chance to break free, to become a legend in the shadows. But first, you need a name...";
        private int charIndex = 0;

        public StoryForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.BackColor = System.Drawing.Color.Black;

            storyLabel = new Label
            {
                Location = new System.Drawing.Point(50, 200),
                Size = new System.Drawing.Size(1200, 400),
                ForeColor = System.Drawing.Color.LimeGreen,
                Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold),
                TextAlign = System.Drawing.ContentAlignment.TopLeft
            };
            this.Controls.Add(storyLabel);

            typingTimer = new Timer
            {
                Interval = 50 // Adjust for typing speed (50ms per character)
            };
            typingTimer.Tick += TypingTimer_Tick;
            typingTimer.Start();
        }

        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            if (charIndex < storyText.Length)
            {
                storyLabel.Text += storyText[charIndex];
                charIndex++;
            }
            else
            {
                typingTimer.Stop();
                // Add a brief delay before transitioning to make the end of the story readable
                Timer delayTimer = new Timer
                {
                    Interval = 2000 // 2-second pause
                };
                delayTimer.Tick += (s, args) =>
                {
                    delayTimer.Stop();
                    delayTimer.Dispose();
                    ShowNameForm();
                };
                delayTimer.Start();
            }
        }

        private void ShowNameForm()
        {
            NameForm nameForm = new NameForm();
            nameForm.FormClosed += (s, args) => this.Close();
            nameForm.Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "SKIP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.button1);
            this.Name = "StoryForm";
            this.Text = "Story";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DesktopMenu desktopMenu = new DesktopMenu();
            desktopMenu.FormClosed += (s, args) => this.Close();
            desktopMenu.Show();
            this.Hide();
        }
    }
}