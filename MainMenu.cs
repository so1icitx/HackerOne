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
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

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
