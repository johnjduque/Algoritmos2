using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanosADecimal
{
    public partial class Form1 : Form
    {
        Decimal ndecimal;
        Romano nromano;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ndecimal = new Decimal();
            String numeroRomano = textBox1.Text.ToString();
            int numdecimal = ndecimal.SimplerConverter(numeroRomano);
            textBox3.Text = "" + numdecimal;                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nromano = new Romano();
            int ndecim = int.Parse(textBox2.Text.ToString());
            String numRoman = nromano.ConvertirDecimalARomano(ndecim);            
            textBox4.Text = numRoman;
        }
    }
}
