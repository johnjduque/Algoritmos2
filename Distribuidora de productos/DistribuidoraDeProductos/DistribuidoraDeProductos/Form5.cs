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
    public partial class Form5 : Form
    {
        public Form5()
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
                String cadena, almacen;
                bool encontrado;
                encontrado = false;
                String[] campos = new string[4];

                try
                {
                    lectura = File.OpenText("Almacenes.txt");
                    almacen = t1.Text;
                    cadena = lectura.ReadLine();
                    while (cadena != null && encontrado == false)
                    {
                        campos = cadena.Split('&');
                        if (campos[0].Trim().Equals(almacen))
                        {
                            MessageBox.Show("El Almacén ya esta ingresado");
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
                        Almacen almacen1 = new Almacen();
                        almacen1.id = t1.Text;
                        almacen1.nombre = t2.Text;
                        almacen1.direccion = t3.Text;
                        almacen1.municipio = t4.Text;

                        string fileName = "Almacenes.txt";
                        StreamWriter writer = File.AppendText(fileName);
                        writer.WriteLine("{0}&{1}&{2}&{3}", almacen1.id, almacen1.nombre, almacen1.direccion, almacen1.municipio);
                        writer.Close();
                        t1.Clear();
                        t2.Clear();
                        t3.Clear();
                        t4.Clear();

                        MessageBox.Show("Cliente creado con éxito");
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

        public struct Almacen
        {
            public string id;
            public string nombre;
            public string direccion;
            public string municipio;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
