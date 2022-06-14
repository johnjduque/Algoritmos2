using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1p5_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r, h, lc, ac, volc, volccc;
            int n1;
            n1 = int.Parse(textBox3.Text);
            if (n1 <= 0 || n1 > 4)
                MessageBox.Show("opción incorrecta");
            r = Math.Abs(double.Parse(textBox1.Text));
            h = Math.Abs(double.Parse(textBox2.Text));
            switch (n1)
            {
                case 1:
                    lc = 2 * Math.PI * r;
                    MessageBox.Show("la longitud de la circunferencia es: "+ lc);
                    break;
                case 2:
                    ac = Math.PI * Math.Pow(r, 2);
                    MessageBox.Show("el área de la circunferencia es: "+ ac);
                    break;
                case 3:
                    volc = Math.PI * Math.Pow(r, 2) * h;
                    MessageBox.Show("el volumen del cilindro es: "+ volc);
                    break;
                case 4:
                    volccc = Math.PI * Math.Pow(r, 2) * h * 0.33333333333;
                    MessageBox.Show("el volumen del cono circular recto es: "+ volccc);
                    break;
            }
        }
    }
}