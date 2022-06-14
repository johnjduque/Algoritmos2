using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1p3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ushort n;
            int a = 0, b = 1, i = 2, f;

            n = ushort.Parse(textBox1.Text);
            
            if (n <= 0)
                MessageBox.Show("valor incorrecto");
            else
            if (n == 1)
                MessageBox.Show(" "+ 0);
            else
            if (n == 2)
            {
                MessageBox.Show(" "+ 0);
                MessageBox.Show(" "+ 1);
            }
            else
            {

                MessageBox.Show(" "+ 0);
                MessageBox.Show(" "+ 1);
            }
            while (i < n)
            {
                f = a + b;
                a = b;
                b = f;
                i++;
                MessageBox.Show(" "+ f);
            }
        }

    }
}
