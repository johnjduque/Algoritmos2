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
    public partial class ListarClientes : Form
    {
        public object DtgrdLisEstu { get; set; }

        public ListarClientes()
        {
            InitializeComponent();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
                StreamReader Arch = new StreamReader("clientes1.txt");
                int fila = 0;
                while (Arch.EndOfStream == false)
                {
                    string[] Vect = Arch.ReadLine().Split('&');
                    Cliente clie = new Cliente();
                    clie.codigo = Vect[0];
                    clie.nombre = Vect[1];
                    clie.apellido = Vect[2];
                    clie.direccion = Vect[3];
                    clie.telefono = Vect[4];
                    clie.email = Vect[5];
                    clie.saldo = Vect[6];

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[fila].Cells["codigo"].Value = clie.codigo;
                    dataGridView1.Rows[fila].Cells["nombre"].Value = clie.nombre;
                    dataGridView1.Rows[fila].Cells["apellido"].Value = clie.apellido;
                    dataGridView1.Rows[fila].Cells["direccion"].Value = clie.direccion;
                    dataGridView1.Rows[fila].Cells["telefono"].Value = clie.telefono;
                    dataGridView1.Rows[fila].Cells["email"].Value = clie.email;
                    dataGridView1.Rows[fila].Cells["saldo"].Value = clie.saldo;

                    fila++;
                }
                Arch.Close();
        }
    }
}
