using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Números_amigos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, i, c, d;
            a = int.Parse(textBox2.Text);
            b = int.Parse(textBox1.Text);
            if (a <= 0 || b <= 0)
                MessageBox.Show("dato incorrecto, ingresar sólo números positivos");
            else
            {
                c = 0;
                for (i = 1; i < a; i++)
                {
                    if (a % i == 0)
                        c= c + i;
                }
                d = 0;
                for (i = 1; i < b; i++)
                {
                    if (b % i == 0)
                        d = d + i;
                }
                if (c == b && d == a)
                    MessageBox.Show("el # " + a + " y el # " + b + " son números amigos");
                else
                    MessageBox.Show("el # " + a + " y el # " + b + " no son números amigos");
            }
        }
    }
}
