using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1p9_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra, inverso, caracter;
            int i;
            palabra = Convert.ToString(textBox1.Text);
            i = palabra.Length;
            inverso = "";
            for (int x = i - 1; x >= 0; x--)
            {
                caracter = palabra.Substring(x, 1);
                inverso = inverso + caracter;
            }
            MessageBox.Show("inverso de la palabra");
            MessageBox.Show(inverso);
            if (palabra == inverso)
            {
                MessageBox.Show("es palíndrome");
            }
            else
            {
                MessageBox.Show("no es palíndrome");
            }
        }
    }
}
