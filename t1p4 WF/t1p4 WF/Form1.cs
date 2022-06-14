using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1p4_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vamos a calcular la superficie del triángulo");

            double a, b, c, s, A, t, r, p1, p2, pdto, aux;


            t = int.Parse(textBox4.Text);
            if (t <= 0 || t > 4)
                MessageBox.Show("dato incorrecto, intente de nuevo por favor");
            else if (t == 1)
            {
                a = Math.Abs(double.Parse(textBox1.Text));
                r = Math.Pow(3, 0.5);
                p1 = Math.Pow(a, 2);
                A = (r / 4) * p1;
                MessageBox.Show("el área del triángulo equilátero es: " + A);
            }
            else if (t == 2)
            {
                a = Math.Abs(double.Parse(textBox1.Text));
                b = Math.Abs(double.Parse(textBox2.Text));
                if (a > b)
                {
                    p1 = Math.Pow(a, 2);
                    p2 = Math.Pow(b, 2);
                    r = Math.Pow((p1 - (p2 / 4)), 0.5);
                    A = (b * r) / 2;
                    MessageBox.Show("el área del triángulo isósceles es: " + A);
                }
                else
                {
                    aux = a;
                    a = b;
                    b = aux;
                    p1 = Math.Pow(a, 2);
                    p2 = Math.Pow(b, 2);
                    r = Math.Pow((p1 - (p2 / 4)), 0.5);
                    A = (b * r) / 2;
                    MessageBox.Show("el área del triángulo isósceles es: " + A);
                }
            }
            else if (t == 3)
            {
                a = Math.Abs(double.Parse(textBox1.Text));
                b = Math.Abs(double.Parse(textBox2.Text));
                c = Math.Abs(double.Parse(textBox3.Text));
                s = (a + b + c) / 2;
                pdto = (s * (s - a) * (s - b) * (s - c));
                r = Math.Pow(pdto, 0.5);
                A = r;
                MessageBox.Show("el área del triángulo escaleno es: " + A);
            }
            else
            {
                a = Math.Abs(double.Parse(textBox1.Text));
                b = Math.Abs(double.Parse(textBox2.Text));
                A = (b * a) / 2;
                MessageBox.Show("el área del triángulo rectángulos es: " + A);
            }
        }
    }
}
