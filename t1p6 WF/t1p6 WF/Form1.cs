using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1p6_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i, i1, c, vf;
            int m, m1, l;
            c = double.Parse(textBox1.Text);
            i = double.Parse(textBox2.Text);
            m = int.Parse(textBox3.Text);
            m1 = 1;
            for (l = 1; l <= m; l++)
            {
                i1 = i / 100;
                vf = c * Math.Pow((1 + i1), m1);
                m1++;
                MessageBox.Show("el valor final para el mes "+ l +" será "+ vf);
            }
        }
    }
}
