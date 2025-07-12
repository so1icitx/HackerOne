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
    public partial class Monero3 : Form
    {
        public Monero3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(240, 50);
            label1.Size = new System.Drawing.Size(1200, 80);
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(50, 200);
            label2.Size = new System.Drawing.Size(1000, 600);

            pictureBox1.Location = new System.Drawing.Point(1000, 200);
            pictureBox1.Size = new System.Drawing.Size(500, 500);

            button1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.Color.MediumPurple;
            button1.BackColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(0, 700);
            button1.Size = new System.Drawing.Size(200, 80);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monero4 storyForm = new Monero4();
            storyForm.FormClosed += (s, args) => this.Close();
            storyForm.Show();
            this.Hide();
        }
    }
}
