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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        

            if (Form2.punkti == 1) labrezultats.Text = Form2.punkti + " punkts";
            else labrezultats.Text = Form2.punkti + " punkti";
        }
    }
}
