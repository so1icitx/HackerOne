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
    public partial class Monero4 : Form
    {
        public Monero4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.GhostWhite;
            label1.Location = new System.Drawing.Point(360, 50);
            label1.Size = new System.Drawing.Size(1200, 80);
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            pictureBox1.Location = new System.Drawing.Point(800, 200);
            pictureBox1.Size = new System.Drawing.Size(500, 500);


            pictureBox2.Location = new System.Drawing.Point(0, 200);
            pictureBox2.Size = new System.Drawing.Size(500, 500);

            button1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.Color.MediumPurple;
            button1.BackColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(1000, 0);
            button1.Size = new System.Drawing.Size(200, 80);
        }

        private void Monero4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options storyForm = new Options();
            storyForm.FormClosed += (s, args) => this.Close();
            storyForm.Show();
            this.Hide();

        }
    }
}
