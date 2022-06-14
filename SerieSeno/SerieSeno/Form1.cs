using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerieSeno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDelAngulo = double.Parse(textBox2.Text);
            int interacciones = int.Parse(textBox1.Text);
            int limite, limitepos, limiteneg;
            double Suma, sumaneg, sumapos, potencia;
            Suma = 0;

            if (interacciones <= 0)
                MessageBox.Show("Dato incorrecto, interacción debe ser mayor que cero");

            else if (interacciones == 1)
                MessageBox.Show("El valor de Sen de " + valorDelAngulo + " es: " + (Suma = valorDelAngulo));

            else
            {                             
                limiteneg = 3;
                limitepos = 5;
                sumaneg = 0;
                sumapos = 0;

                for (limite = 2; limite <= interacciones; limite++)
                {
                    

                    if (limite % 2 == 0)
                    {
                        
                        Factorialneg(limiteneg);
                        potencia = Math.Pow(valorDelAngulo, limiteneg);
                        sumaneg += potencia / Factorialneg(limiteneg);
                        limiteneg = limiteneg + 4;
                    }

                                  
                    else
                    {
                        
                        Factorialpos(limitepos);
                        potencia = Math.Pow(valorDelAngulo, limitepos);
                        sumapos += potencia / Factorialpos(limitepos);
                        limitepos = limitepos + 4;
                    }                    
                    
                }
                Suma = valorDelAngulo + (sumaneg * (-1)) + sumapos;

                MessageBox.Show("El valor de Sen de " + valorDelAngulo + " es: " + Suma);
            }

        }

        public int Factorialneg(int limiteneg)
        {
            int fact = 1;
            for(int i = 1; i <= limiteneg; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public int Factorialpos(int limitepos)
        {
            int fact = 1;
            for (int i = 1; i <= limitepos; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
