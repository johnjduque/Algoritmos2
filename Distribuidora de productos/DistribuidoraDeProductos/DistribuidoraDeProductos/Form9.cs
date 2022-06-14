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
    public partial class Form9 : Form
    {
        public Form9()
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
                    Double Cantidad = 0;
                    string fileProductos = "Productos.txt";
                    string fileCopia = "copia_Productos.txt";

                    StreamWriter writerprod = File.AppendText(fileCopia);
                    StreamReader readerprod = File.OpenText(fileProductos);

                    string producto = (t1.Text);

                    Cantidad = Convert.ToDouble(t2.Text);

                    while (!readerprod.EndOfStream)
                    {

                        string lineaActual = readerprod.ReadLine();
                        string[] datos = lineaActual.Split('&');
                        if (datos[0] == producto && Cantidad > 0)

                        {


                            Cantidad = Convert.ToDouble(datos[3]) + Cantidad;

                            writerprod.WriteLine("{0}&{1}&{2}&{3}", datos[0], datos[1], datos[2], Cantidad);

                            MessageBox.Show("Transaccion Exitosa");
                        }
                        else
                        {
                            writerprod.WriteLine(lineaActual);
                            if (datos[0] == producto)
                            {
                                MessageBox.Show("El inventario de entrada debe ser positivo");
                            }
                        }
                    }

                    writerprod.Close();
                    readerprod.Close();
                    File.Replace(fileCopia, fileProductos, null, true);

                    t1.Clear();
                    t2.Clear();
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
    }
}
