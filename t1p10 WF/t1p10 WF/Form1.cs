using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1p10_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lim, i, c;
            lim = int.Parse(textBox1.Text);
            if (lim != 1)
                MessageBox.Show("valor incorrecto");
            else
            {
                for (i = 0; i < 11; i++)
                {
                    c = 0;
                    for (c = 0; c <= i; c++)
                    {
                        if (Math.Pow(2, c) == i)
                            MessageBox.Show("es una potencia de 2: "+ i);
                    }
                }
            }
        }
    }
}
