using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerieDeTylor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDeX = double.Parse(textBox2.Text);
            int interacciones = int.Parse(textBox1.Text);
            int limite, interaccionUno = 1, indice;
            double Suma, potencia, suma;
            Suma = 0;

            if (interacciones <= 0)
                MessageBox.Show("Dato incorrecto, interacción debe ser mayor que cero");

            else if (interacciones == 1)
                MessageBox.Show("El valor de la serie de Tylor es: " + interaccionUno);

            else if (interacciones == 2)
                MessageBox.Show("El valor de la serie de Tylor es: " + (interaccionUno + valorDeX));

            else
            {
                suma = 0;
                for (limite = 3; limite <= interacciones; limite++)
                {
                    indice = (limite - 1);
                    Factorial(indice);
                    potencia = Math.Pow(valorDeX, indice);
                    suma += potencia / Factorial(indice);
                }
                Suma = interaccionUno + valorDeX + suma;

                MessageBox.Show("El valor de la serie de Tylor es: " + Suma);
            }

        }

        public int Factorial(int indice)
        {
            int fact = 1;
            for (int i = 1; i <= indice; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
