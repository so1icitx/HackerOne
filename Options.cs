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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.play.Size = new System.Drawing.Size(615, 122);
            this.xmr.Size = new System.Drawing.Size(615, 122);
            this.egg.Size = new System.Drawing.Size(615, 122);
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu storyForm = new MainMenu();
            storyForm.FormClosed += (s, args) => this.Close();
            storyForm.Show();
            this.Hide();
        }

        private void xmr_Click(object sender, EventArgs e)
        {
            Monero1 storyForm = new Monero1();
            storyForm.FormClosed += (s, args) => this.Close();
            storyForm.Show();
            this.Hide();
        }

        private void egg_Click(object sender, EventArgs e)
        {
            Egg storyForm = new Egg();
            storyForm.FormClosed += (s, args) => this.Close();
            storyForm.Show();
            this.Hide();
        }

        private void play_Click(object sender, EventArgs e)
        {
            How storyForm = new How();
            storyForm.FormClosed += (s, args) => this.Close();
            storyForm.Show();
            this.Hide();
        }
    }
}
