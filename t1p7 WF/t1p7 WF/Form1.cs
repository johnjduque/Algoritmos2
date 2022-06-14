using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1p7_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            double mayor, menor, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10;
            double[] datos;
            n1 = double.Parse(textBox10.Text);
            n2 = double.Parse(textBox9.Text);
            n3 = double.Parse(textBox8.Text);
            n4 = double.Parse(textBox7.Text);
            n5 = double.Parse(textBox6.Text);
            n6 = double.Parse(textBox5.Text);
            n7 = double.Parse(textBox4.Text);
            n8 = double.Parse(textBox3.Text);
            n9 = double.Parse(textBox2.Text);
            n10 = double.Parse(textBox1.Text);
            datos = new double[] { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10 };
            mayor = datos[0];
            menor = datos[0];
            for (i = 0; i < 10; i++)
            {
                if (datos[i] > mayor)
                    mayor = datos[i];
                else if (datos[i] < menor)
                    menor = datos[i];
            }
            MessageBox.Show("el número mayor ingresado fue: "+ mayor);
            MessageBox.Show("el número menor ingresado fue: "+ menor);
        }
    }
}
