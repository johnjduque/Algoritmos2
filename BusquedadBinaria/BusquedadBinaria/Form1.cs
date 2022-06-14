using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedadBinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, t, aux;
            int mayor, menor;
            int[] vec;
            vec = new int[10];
            vec[0] = int.Parse(textBox1.Text);
            vec[1] = int.Parse(textBox2.Text);
            vec[2] = int.Parse(textBox3.Text);
            vec[3] = int.Parse(textBox4.Text);
            vec[4] = int.Parse(textBox5.Text);
            vec[5] = int.Parse(textBox6.Text);
            vec[6] = int.Parse(textBox7.Text);
            vec[7] = int.Parse(textBox8.Text);
            vec[8] = int.Parse(textBox9.Text);
            vec[9] = int.Parse(textBox10.Text);

            mayor = vec[0];
            menor = vec[0];
            for (i = 0; i < vec.Length; i++)
            {
                t = i + 1;
                while (t < vec.Length)
                {
                    if (vec[i] > vec[t])
                    {
                        aux = vec[i];
                        vec[i] = vec[t];
                        vec[t] = aux;
                    }
                    t++;
                }
            }
            
            int puntero = 0, final = 9;
            int medio = 0;
            bool encontrar = false;

            while (puntero <= final && encontrar == false)
            {
                medio = (puntero + final) / 2;
                if (vec[medio] == int.Parse(textBox11.Text))
                    encontrar = true;
                if (vec[medio] > int.Parse(textBox11.Text))
                    final = medio - 1;
                else
                    puntero = medio + 1;
            }
            if (encontrar == false)
            { MessageBox.Show("El elemento "+ int.Parse(textBox11.Text) +" no esta en el arreglo"); }
            else
            {
                MessageBox.Show("El elemento " + int.Parse(textBox11.Text) +" esta en la posicion: "+ (medio + 1));
            }
        }
    }
}
