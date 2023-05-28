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
    public partial class Form2 : Form
    {
        string[] jautajumi = new string[] {

"CIK IR 2 + 2 = ?",

"CIK IR 2 * 2 = ?",

"CIK IR 2 + 2 * 2 = ?",

"CIK IR 2 * (2 + 2) = ?",

"CIK IR 10 / 2 = ?",

"CIK IR 10000 / 2 = ?",

"CIK IR 10 / 0.2 = ?",

"CIK IR 1000 / 0.02 = ?",

"CIK IR 1001 / 2 = ?",

"CIK IR 2002 / (2 * 2) = ?",

};

        string[] atbildes1 = new string[] {

"0",

"2",

"8",

"6",

"5",

"400",

"5",

"2000",

"1000.5",

"200",

};

        string[] atbildes2 = new string[] {

"2",

"4",

"4",

"100",

"300",

"20",

"45",

"21",

"109",

"1000",


};

        string[] atbildes3 = new string[] {

"4",

"22",

"6",

"8",

"500",

"5000",

"50",

"50000",

"500.5",

"500.5",

};

        string[] atbildes = new string[] {

"4",

"4",

"6",

"8",

"5",

"5000",

"50",

"50000",

"500.5",

"500.5",

};
        int piemeri = 0;
        public static int punkti = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labjautajums.Text = jautajumi[piemeri];
            butatbilde1.Text = atbildes1[piemeri];
            butatbilde2.Text = atbildes2[piemeri];
            butatbilde3.Text = atbildes3[piemeri];
        }

        private void butatbilde1_Click(object sender, EventArgs e)
        {
            if (butatbilde1.Text == atbildes[piemeri]) punkti++;
            else if (punkti > 0) punkti--;
            if (punkti == 1) labpunkti.Text = punkti + " punkts";
            else labpunkti.Text = punkti + " punkti";
            piemeri++;
            if (piemeri < 10)
            {
                labjautajums.Text = jautajumi[piemeri];
                butatbilde1.Text = atbildes1[piemeri];
                butatbilde2.Text = atbildes2[piemeri];
                butatbilde3.Text = atbildes3[piemeri];
                labpiemeri.Text = (piemeri + 1) + ". no 10 jaut.";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }

        }

        private void butatbilde2_Click(object sender, EventArgs e)
        {
            if (butatbilde2.Text == atbildes[piemeri]) punkti++;
            else if (punkti > 0) punkti--;
            if (punkti == 1) labpunkti.Text = punkti + "punkts";
            else labpunkti.Text = punkti + "punkti";
            piemeri++;
            if (piemeri < 10)
            {
                labjautajums.Text = jautajumi[piemeri];
                butatbilde1.Text = atbildes1[piemeri];
                butatbilde2.Text = atbildes2[piemeri];
                butatbilde3.Text = atbildes3[piemeri];
                labpiemeri.Text = (piemeri + 1) + ". no 10 jaut.";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void butatbilde3_Click(object sender, EventArgs e)
        {
            if (butatbilde3.Text == atbildes[piemeri]) punkti++;
            else if (punkti > 0) punkti--;
            if (punkti == 1) labpunkti.Text = punkti + "punkts";
            else labpunkti.Text = punkti + "punkti";
            piemeri++;
            if (piemeri < 10)
            {
                labjautajums.Text = jautajumi[piemeri];
                butatbilde1.Text = atbildes1[piemeri];
                butatbilde2.Text = atbildes2[piemeri];
                butatbilde3.Text = atbildes3[piemeri];
                labpiemeri.Text = (piemeri + 1) + ". no 10 jaut.";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }
    }
}