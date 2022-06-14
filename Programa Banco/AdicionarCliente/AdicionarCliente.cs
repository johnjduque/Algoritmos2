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
    public partial class AdicionarCliente : Form
    {
        public AdicionarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text == string.Empty || t2.Text == string.Empty || t3.Text == string.Empty || t4.Text == string.Empty || t5.Text == string.Empty || t6.Text == string.Empty || t7.Text == string.Empty)
                MessageBox.Show("por favor llenar todos los campos");
            else
            {
                Cliente cliente = new Cliente();
                cliente.codigo = t1.Text;
                cliente.nombre = t2.Text;
                cliente.apellido = t3.Text;
                cliente.direccion = t4.Text;
                cliente.telefono = t5.Text;
                cliente.email = t6.Text;
                cliente.saldo = t7.Text;

                string fileName = "clientes1.txt";
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}", cliente.codigo, cliente.nombre, cliente.apellido,
                    cliente.direccion, cliente.telefono, cliente.email, cliente.saldo);
                writer.Close();
                t1.Clear();
                t2.Clear();
                t3.Clear();
                t4.Clear();
                t5.Clear();
                t6.Clear();
                t7.Clear();

            }

        }


        public struct Cliente
        {
            public string codigo;
            public string nombre;
            public string apellido;
            public string direccion;
            public string telefono;
            public string email;
            public string saldo;

        }
    }
}