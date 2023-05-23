using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programma01
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

        private void butbalts_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void butmelns_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
    }
}
