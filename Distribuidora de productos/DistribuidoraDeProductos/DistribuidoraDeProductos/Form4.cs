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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text == string.Empty || t2.Text == string.Empty)
                MessageBox.Show("por favor llenar todos los campos");
            else
            {

                try
                {
                    string fileProductos = "Productos.txt";
                    string fileCopia = "copia_Productos.txt";

                    StreamWriter writerprod = File.AppendText(fileCopia);
                    StreamReader readerprod = File.OpenText(fileProductos);

                    string producto = (t2.Text);
                    double Cantidad = Convert.ToDouble(t4.Text);
                    while (!readerprod.EndOfStream)
                    {

                        string lineaActual = readerprod.ReadLine();
                        string[] datos = lineaActual.Split('&');
                        if (datos[0] == producto && double.Parse(datos[3]) - Cantidad > 0 && Cantidad > 0)

                        {
                            Cantidad = Convert.ToDouble(datos[3]) - Cantidad;

                            writerprod.WriteLine("{0}&{1}&{2}&{3}", datos[0], datos[1], datos[2], Cantidad );

                            Pedido pedido = new Pedido();
                            pedido.cedulaCliente = t3.Text;
                            pedido.codigoProducto = t2.Text;
                            pedido.fecha = t1.Text;
                            pedido.cantidad = t4.Text;

                            string fileName = "Pedidos.txt";

                            StreamWriter writer = File.AppendText(fileName);

                            writer.WriteLine("{0}&{1}&{2}&{3}", pedido.cedulaCliente, pedido.fecha, pedido.codigoProducto, pedido.cantidad);
                            writer.Close();
                            MessageBox.Show("Pedido Adicionado");
                            t2.Text = "";
                            t4.Text = "";

                            MessageBox.Show("Transaccion Exitosa");
                        }

                        else
                        {
                            writerprod.WriteLine(lineaActual);
                            if (datos[0] == producto)
                                MessageBox.Show("Inventario no disponible, verificar unidades");
                        }
                    }

                    writerprod.Close();
                    readerprod.Close();
                    File.Replace(fileCopia, fileProductos, null, true);

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
        public struct Pedido
        {
            public string fecha;
            public string codigoProducto;
            public string cedulaCliente;
            public string cantidad;
        }
    }
}
