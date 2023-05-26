using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematikas_olimpiade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butsakt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 jautajumi = new Form2();
            jautajumi.Show();

        }
    }
}
