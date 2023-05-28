using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blackwhite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butzils_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void butroza_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void butdzeltens_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void butzals_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
