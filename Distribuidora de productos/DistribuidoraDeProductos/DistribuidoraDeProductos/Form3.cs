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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text == string.Empty || t2.Text == string.Empty || t3.Text == string.Empty || t4.Text == string.Empty)
                MessageBox.Show("por favor llenar todos los campos");
            else
            {
                StreamReader lectura;
                String cadena, pdto;
                bool encontrado;
                encontrado = false;
                String[] campos = new string[1];

                try
                {
                    lectura = File.OpenText("Productos.txt");
                    pdto = t1.Text;
                    cadena = lectura.ReadLine();
                    while (cadena != null && encontrado == false)
                    {
                        campos = cadena.Split('&');
                        if (campos[0].Trim().Equals(pdto))
                        {
                            MessageBox.Show("El Producto ya existe, si desea actualice inventario");
                            encontrado = true;
                            t1.Clear();
                            t2.Clear();
                            t3.Clear();
                            t4.Clear();
                        }
                        else
                        {
                            cadena = lectura.ReadLine();
                        }
                    }
                    lectura.Close();
                    if (encontrado == false)
                    {
                        Producto producto = new Producto();
                        producto.codigo = t1.Text;
                        producto.nombre = t2.Text;
                        producto.precio = t3.Text;
                        producto.inventario = t4.Text;

                        string fileName = "Productos.txt";
                        StreamWriter writer = File.AppendText(fileName);
                        writer.WriteLine("{0}&{1}&{2}&{3}", producto.codigo, producto.nombre,
                            producto.precio, producto.inventario);
                        writer.Close();
                        t1.Clear();
                        t2.Clear();
                        t3.Clear();
                        t4.Clear();

                        MessageBox.Show("Producto ingresado con éxito");
                    }

                }
                catch (FileNotFoundException fe)
                {
                    MessageBox.Show("ERROR" + fe.Message);
                }
                catch (Exception f)
                {
                    MessageBox.Show("ERROR" + f.Message);
                }
            }
        }
        public struct Producto
        {
            public string codigo;
            public string nombre;
            public string precio;
            public string inventario;

        }
    }
}
