using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1p2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, aux, r;
            MessageBox.Show("vamos a calcular m.c.d");
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b > a)
            {
                aux = a;
                a = b;
                b = aux;
                do
                {
                    r = a % b;
                    a = b;
                    b = r;
                } while (b != 0);
                MessageBox.Show("el m.c.d es: "+ a);
            }
            else
            {
                do
                {
                    r = a % b;
                    a = b;
                    b = r;
                } while (b != 0);
                MessageBox.Show("el m.c.d es: "+ a);
            }
        }
    }
}
