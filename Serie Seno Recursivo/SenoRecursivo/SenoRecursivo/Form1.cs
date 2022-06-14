using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenoRecursivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Bienvenido al programa que halla el sENO DE x En RAdianes!");
            MessageBox.Show("Bienvenido Ingrese numero impar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 0, j = 0, n = 1;
            double f, s = 0, x = 3.1416 / 3;

            //numero = int.Parse(textBox1.Text);
            numero = int.Parse(textBox1.Text);

            f = facrec(numero);

            while (j < numero)
            {

                if (j % 2 == 0)
                    s = s + ((Math.Pow(x, n)) / Factorial(n));
                else
                    s = s - ((Math.Pow(x, n)) / Factorial(n));

                n = n + 2;
                j++;
            }
            textBox1.Text = s.ToString();
            return;

        }

        static double Factorial(int numero)
        {

            int contador = 1, i = 0;
            if (numero > 0)
            {
                for (i = 2; i <= numero; i++)

                    contador = (contador * i);

            }
            else
                MessageBox.Show("El número debe ser mayor que 0");

            return contador;
        }
        //Funcion para el factorial Recursivo
        static double facrec(int numero)
        {

            if (numero == 0)
                return 1;
            else
                return numero * facrec(numero - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            double sr = Math.Abs(senorec(numero, 3.1416 / 3, 0));
            textBox1.Text = sr.ToString();

        }

        static double senorec(int n, double x, int j)
        {
            if (n == -1)
                return 0;

            else
            {

                if (j % 2 == 0)
                    return ((Math.Pow(x, n)) / facrec(n)) - senorec(n - 2, x, j++);
                else
                    return ((Math.Pow(x, n)) / facrec(n)) + senorec(n - 2, x, j++);
                
            }
        }
    }
}
