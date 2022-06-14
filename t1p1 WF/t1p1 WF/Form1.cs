using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1p1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;
            string oper;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            oper = textBox3.Text;
            if (oper != "+" && oper != "-" && oper != "*" && oper != "/")
                MessageBox.Show("OperADOR iNCORRECTO");
            else
            {
                switch (oper)
                {
                    case "+":
                        a = a + b;
                        MessageBox.Show("SUma de VAriables= " + a);
                        break;
                    case "-":
                        a = a - b;
                        MessageBox.Show("Resta de variables= " + a);
                        break;
                    case "*":
                        a = a * b;
                        MessageBox.Show("Multiplicación de variables= " + a);
                        break;
                    case "/":
                        a = a / b;
                        MessageBox.Show("División de variables= " + a);
                        break;
                }
            }
                
        }
    }
}
