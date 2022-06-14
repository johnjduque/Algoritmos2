using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1p8_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lim, i, c, j;
            lim = int.Parse(textBox1.Text);
            if (lim < 2)
                MessageBox.Show("valor incorrecto ingrese valores mayores que 1");
            else
            {
                for (i = 1; i <= lim; i++)
                {
                    c = 0;
                    for (j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            c++;
                        }
                    }
                    if (c == 2)
                        MessageBox.Show(" "+ i);
                }
            }
        }
    }
}
