using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.Location = new System.Drawing.Point(350, 0);
            this.mainbutton1.Size = new System.Drawing.Size(400, 100);
            this.mainbutton1.Location = new System.Drawing.Point(550, 500);
            this.mainbutton2.Size = new System.Drawing.Size(400, 100);
            this.mainbutton2.Location = new System.Drawing.Point(550, 600);
            this.mainbutton3.Size = new System.Drawing.Size(400, 100);
            this.mainbutton3.Location = new System.Drawing.Point(550, 700);
        }

        private void mainbutton2_Click(object sender, EventArgs e)
        {
           
        }

        private void mainbutton1_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            this.Hide();
            mainForm.FormClosed += (s, args) => this.Show();
            mainForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainbutton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
