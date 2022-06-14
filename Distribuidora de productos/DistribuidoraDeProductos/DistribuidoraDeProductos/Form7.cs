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

namespace DistribuidoraDeProductos
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader Arch = new StreamReader("Clientes.txt ");
            int fila = 0;
            while (Arch.EndOfStream == false)
            {
                string[] Vect = Arch.ReadLine().Split('&');
                Cliente clie = new Cliente();
                clie.cedula = Vect[0];
                clie.nombre = Vect[1];
                clie.direccion = Vect[2];
                clie.celular = Vect[3];
                clie.email = Vect[4];


                dataGridView1.Rows.Add();
                dataGridView1.Rows[fila].Cells["Cedula"].Value = clie.cedula;
                dataGridView1.Rows[fila].Cells["Nombre"].Value = clie.nombre;
                dataGridView1.Rows[fila].Cells["Direccion"].Value = clie.direccion;
                dataGridView1.Rows[fila].Cells["Celular"].Value = clie.celular;
                dataGridView1.Rows[fila].Cells["email"].Value = clie.email;


                fila++;

            }
            Arch.Close();
        }
    }
    public struct Cliente
    {
        public string cedula;
        public string nombre;
        public string direccion;
        public string celular;
        public string email;

    }
}
