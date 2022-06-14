using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MatricesDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] matrizA = new int[10, 10];
        int[,] matrizB = new int[10, 10];
        int[,] matriz = new int[10, 10];
        int fila, columna, i, j, k;

        private void button2_Click(object sender, EventArgs e)
        {
            mostar_matriz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crearmatriz();
        }        

        private void button4_Click(object sender, EventArgs e)
        {
            //Crear la MatrizB
            fila = int.Parse(textBox1.Text);
            columna = int.Parse(textBox2.Text);
            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    matrizB[i, j] = int.Parse(Interaction.InputBox("DAto en i", "DAto en j", "", fila, columna));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Multiplicar las MAtrices
            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    for (k = 0; k < fila; k++)
                    {
                        matriz[i, j] = matriz[i, j] + matrizA[i, k] * matrizB[k, j];
                    }
                }
            }
        }

        public void crearmatriz()
        {
            // Crear MAtrizA
            fila = int.Parse(textBox1.Text);
            columna = int.Parse(textBox2.Text);
            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    matrizA[i, j] = int.Parse(Interaction.InputBox("DAto en i", "DAto en j", "", fila, columna));
                }

            }
        }

        public void mostar_matriz()
        {
            dataGridView1.ColumnCount = columna;
            dataGridView1.RowCount = fila;
            for (i = 0; i <= fila - 1; i++)
            {
                for (j = 0; j <= columna - 1; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
