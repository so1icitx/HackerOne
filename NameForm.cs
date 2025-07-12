using System;
using System.Windows.Forms;

namespace BlueTeamerRole
{
    public partial class NameForm : Form
    {
        private TextBox nameTextBox;
        private Button submitButton;
        private Button backButton;
        private Label promptLabel;

        public NameForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.BackColor = System.Drawing.Color.Black;

            // Prompt label
            promptLabel = new Label
            {
                Text = "Enter Your Hacker Alias:",
                Location = new System.Drawing.Point(300, 400),
                Size = new System.Drawing.Size(600, 50),
                ForeColor = System.Drawing.Color.LimeGreen,
                Font = new System.Drawing.Font("Consolas", 23F, System.Drawing.FontStyle.Bold),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            this.Controls.Add(promptLabel);

            // Name input textbox
            nameTextBox = new TextBox
            {
                Location = new System.Drawing.Point(300, 500),
                Size = new System.Drawing.Size(720, 200),
                Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Lime,
                BackColor = System.Drawing.Color.Black,
                TextAlign = HorizontalAlignment.Center
            };
            nameTextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SubmitName();
                }
            };
            this.Controls.Add(nameTextBox);

            // Submit button
            submitButton = new Button
            {
                Text = "Submit",
                Location = new System.Drawing.Point(820, 575),
                Size = new System.Drawing.Size(200, 80),
                Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.MediumPurple,
                BackColor = System.Drawing.Color.Black
            };
            submitButton.Click += (s, e) => SubmitName();
            this.Controls.Add(submitButton);

            // Back button
            backButton = new Button
            {
                Text = "Back",
                Location = new System.Drawing.Point(50, 720),
                Size = new System.Drawing.Size(200, 80),
                Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.MediumPurple,
                BackColor = System.Drawing.Color.Black
            };
            backButton.Click += (s, e) =>
            {
                StoryForm storyForm = new StoryForm();
                storyForm.FormClosed += (s2, args) => this.Close();
                storyForm.Show();
                this.Hide();
            };
            this.Controls.Add(backButton);

            this.Load += NameForm_Load;
        }

        private void NameForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Focus(); // Set focus to textbox on load
        }

        private void SubmitName()
        {
            string name = nameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid alias!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GameState.PlayerName = name;
            DesktopMenu deskmenu = new DesktopMenu();
            deskmenu.FormClosed += (s, args) => this.Close();
            deskmenu.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}