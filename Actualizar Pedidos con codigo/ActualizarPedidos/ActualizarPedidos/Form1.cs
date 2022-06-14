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

namespace ActualizarPedidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Cliente
        {
            public string cliente;
            public string producto;
            public string cantidad;
            public string precio;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader Arch = new StreamReader("pedidos20.txt ");
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t1.Text == string.Empty || t2.Text == string.Empty || t3.Text == string.Empty || t4.Text == string.Empty)
                MessageBox.Show(" Por favor llenar todos los campos. ");
            else
            {
                StreamReader Arch = new StreamReader("pedidos20.txt ");
                while (Arch.EndOfStream == false)
                {
                    string[] Vect = Arch.ReadLine().Split('&');
                    Cliente clie = new Cliente();
                    clie.cliente = Vect[0];
                    clie.producto = Vect[1];
                    clie.cantidad = Vect[2];
                    clie.precio = Vect[3];

                    if (clie.producto == t2.Text)
                        MessageBox.Show("Producto ya existe");

                    else
                    {
                        Cliente cliente = new Cliente();
                        cliente.cliente = t1.Text;
                        cliente.producto = t2.Text;
                        cliente.cantidad = t3.Text;
                        cliente.precio = t4.Text;


                        string fileName = "pedidos20.txt ";
                        StreamWriter writer = File.AppendText(fileName);
                        writer.WriteLine("{0}&{1}&{2}&{3}", cliente.cliente, cliente.producto, cliente.cantidad, cliente.precio);
                        writer.Close();

                        t1.Clear();
                        t2.Clear();
                        t3.Clear();
                        t4.Clear();
                    }
                }         
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Cantidad = 0;
            string fileProductos = "Pedidos20.txt";
            string fileCopia = "copia_Pedidos1.txt";

            StreamWriter writerprod = File.AppendText(fileCopia);
            StreamReader readerprod = File.OpenText(fileProductos);

            string producto = (t6.Text);

            Cantidad = Convert.ToDouble(t7.Text);

            while (!readerprod.EndOfStream)
            {


                string lineaActual = readerprod.ReadLine();
                string[] datos = lineaActual.Split('&');
                if (datos[1] == producto && Cantidad > 0)

                {


                    Cantidad = Convert.ToDouble(datos[2]) + Cantidad;

                    writerprod.WriteLine("{0}&{1}&{2}&{3}", datos[0], datos[1], Cantidad, datos[3]);

                    MessageBox.Show("Transaccion Exitosa");
                }

                else
                {
                    writerprod.WriteLine(lineaActual);
                    if (datos[1] == producto)
                        MessageBox.Show("El inventario de entrada debe ser positivo");
                }
            }

            writerprod.Close();
            readerprod.Close();
            File.Replace(fileCopia, fileProductos, null, true);

            t5.Clear();
            t6.Clear();
            t7.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileProductos = "Pedidos20" +
                ".txt";
            string fileCopia = "copia_Pedidos1.txt";

            StreamWriter writerprod = File.AppendText(fileCopia);
            StreamReader readerprod = File.OpenText(fileProductos);

            string producto = (t9.Text);
            double Cantidad = Convert.ToDouble(t10.Text);
            while (!readerprod.EndOfStream)
            {

                string lineaActual = readerprod.ReadLine();
                string[] datos = lineaActual.Split('&');
                if (datos[1] == producto && double.Parse(datos[2]) - Cantidad > 0 && Cantidad > 0)

                {


                    Cantidad = Convert.ToDouble(datos[2]) - Cantidad;

                    writerprod.WriteLine("{0}&{1}&{2}&{3}", datos[0], datos[1], Cantidad, datos[3]);

                    MessageBox.Show("Transaccion Exitosa");
                }

                else
                {
                    writerprod.WriteLine(lineaActual);
                    if (datos[1] == producto)
                        MessageBox.Show("Inventario no disponible, verificar unidades");
                }
            }

            writerprod.Close();
            readerprod.Close();
            File.Replace(fileCopia, fileProductos, null, true);

            t8.Clear();
            t9.Clear();
            t10.Clear();
        }
    }
}

