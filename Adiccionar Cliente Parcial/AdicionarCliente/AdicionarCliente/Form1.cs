using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdicionarCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.codigo = textBox1.Text;

            cliente.nombre = textBox2.Text;

            cliente.apellido = textBox3.Text;

            cliente.direccion = textBox4.Text;

            cliente.telefono = textBox5.Text;
            cliente.email = textBox6.Text;

            string fileName = "clientesParcial.txt";

            StreamWriter writer = File.AppendText(fileName);

            writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}", cliente.codigo, cliente.nombre, cliente.apellido, cliente.direccion, cliente.telefono, cliente.email);
            writer.Close();
            MessageBox.Show("Cliente Adicionado");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        public struct Cliente
        {
            public string codigo;
            public string nombre;
            public string apellido;
            public string direccion;
            public string telefono;
            public string email;

        }

    }
}
