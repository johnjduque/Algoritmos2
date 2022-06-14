using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_de_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamReader sr;
        bool abierto = false;
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            Calculadora(nombre);
            Procesar();



            // Constructor: Recibe el nombre del archivo y lo intenta abrir.
            // Si no puede abrirse para lectura, "abierto" queda como false
        }
        public void Calculadora(string filename)
        {
            try
            {
                sr = new StreamReader(filename);
                abierto = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Abriendo Archivo");
            }
        }
        // Operacion: Recibe la operación y dos números en forma de  string.
        // Retorna el resultado (int) de la operación entre ambos números.
        double Operacion(string n1, string op, string n2)
        {
            switch (op)
            {
                case "+": return (int.Parse(n1) + int.Parse(n2));
                case "-": return (int.Parse(n1) - int.Parse(n2));
                case "*": return (int.Parse(n1) * int.Parse(n2));
                case "/": return (double.Parse(n1) / double.Parse(n2));
            }
            return (0);
        }
        // Procesar: lee líneas del archivo abierto, procesando el contenido en forma de operaciones.
        // Observaciones: al finalizar se cierra el stream. No se valida el    formato de c/línea.

        public void Procesar()
        {
            string linea;
            string[] elementos;
            if (!abierto) return; // Si no se pudo abrir, no hay nada que leer
            linea = sr.ReadLine();
            while (linea != null)
            {
                // Para poder usar Split(), las operaciones y los operandos deben
                // venir separados por espacios.
                elementos = linea.Split();
                listBox1.Items.Add(Operacion(elementos[0], elementos[1], elementos[2]));
                linea = sr.ReadLine();
            }
            sr.Close(); abierto = false;
        }
    }
}