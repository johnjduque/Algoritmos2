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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public struct Cliente
        {
            public string cedula;
            public string nombre;
            public string direccion;
            public string celular;
            public string email;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text == string.Empty || t2.Text == string.Empty || t3.Text == string.Empty || t4.Text == string.Empty || t5.Text == string.Empty)
                MessageBox.Show("por favor llenar todos los campos");
            else
            {
                StreamReader lectura;
                String cadena, cliente;
                bool encontrado;
                encontrado = false;
                String[] campos = new string[1];

                try
                {
                    lectura = File.OpenText("Clientes.txt");
                    cliente = t1.Text;
                    cadena = lectura.ReadLine();
                    while(cadena != null && encontrado == false)
                    {
                        campos = cadena.Split('&');
                        if (campos[0].Trim().Equals(cliente))
                        {
                            MessageBox.Show("El Cliente ya existe");
                            encontrado = true;
                            t1.Clear();
                            t2.Clear();
                            t3.Clear();
                            t4.Clear();
                            t5.Clear();
                        }
                        else
                        {
                            cadena = lectura.ReadLine();
                        }
                    }
                    lectura.Close();
                    if (encontrado == false)
                    {
                        Cliente cliente1 = new Cliente();
                        cliente1.cedula = t1.Text;
                        cliente1.nombre = t2.Text;
                        cliente1.direccion = t3.Text;
                        cliente1.celular = t4.Text;
                        cliente1.email = t5.Text;

                        string fileName = "Clientes.txt";
                        StreamWriter writer = File.AppendText(fileName);
                        writer.WriteLine("{0}&{1}&{2}&{3}&{4}", cliente1.cedula, cliente1.nombre,
                            cliente1.direccion, cliente1.celular, cliente1.email);
                        writer.Close();
                        t1.Clear();
                        t2.Clear();
                        t3.Clear();
                        t4.Clear();
                        t5.Clear();

                        MessageBox.Show("Cliente creado con éxito");
                    }

                }catch(FileNotFoundException fe)
                {
                    MessageBox.Show("ERROR" + fe.Message);
                }catch(Exception f)
                {
                    MessageBox.Show("ERROR" + f.Message);
                }
            }
        }
    }
}
