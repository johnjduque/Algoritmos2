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

namespace Encuesta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text == string.Empty || t1.Text == string.Empty || t2.Text == string.Empty || t3.Text == string.Empty || t4.Text == string.Empty)
                MessageBox.Show(" Por favor llenar todos los campos. ");
            else
            {
                Cliente cliente = new Cliente();
                cliente.cliente = t1.Text;
                cliente.producto = t2.Text;
                cliente.cantidad = t3.Text;
                cliente.precio = t4.Text;


                string fileName = "pedidos1.txt ";
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine("{0}&{1}&{2}&{3}", cliente.cliente, cliente.producto, cliente.cantidad, cliente.precio);
                writer.Close();

                t1.ResetText();
                t2.ResetText();
                t3.ResetText();
                t4.ResetText();

            }
        }
        public struct Cliente
        {
            public string cliente;
            public string producto;
            public string cantidad;
            public string precio;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            StreamReader Arch = new StreamReader("pedidos1.txt ");
            int fila = 0;
            while (Arch.EndOfStream == false)
            {
                string[] Vect = Arch.ReadLine().Split('&');
                Cliente clie = new Cliente();
                clie.cliente = Vect[0];
                clie.producto = Vect[1];
                clie.cantidad = Vect[2];
                clie.precio = Vect[3];


                dataGridView1.Rows.Add();
                dataGridView1.Rows[fila].Cells["CLIENTE"].Value = clie.cliente;
                dataGridView1.Rows[fila].Cells["PRODUCTO"].Value = clie.producto;
                dataGridView1.Rows[fila].Cells["CANTIDAD"].Value = clie.cantidad;
                dataGridView1.Rows[fila].Cells["PRECIO"].Value = clie.precio;


                fila++;





            }
            Arch.Close();

            double suma = 0, cantidad = 0, precio = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cantidad = Convert.ToDouble(row.Cells["CANTIDAD"].Value);
                precio = Convert.ToDouble(row.Cells["PRECIO"].Value);
                suma += cantidad * precio;
            }
            t5.Text = Convert.ToString(suma);
            suma = 0;
        }

    }
}
