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
    public partial class Transferir : Form
    {
        public Transferir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Retiro = 0;
            string fileName = "clientes.txt";
            string fileCopia = "copia_clientes.txt";

            StreamWriter writer = File.AppendText(fileCopia);
            StreamReader reader = File.OpenText(fileName);

            string Cliente = (textBox1.Text);

            Retiro = Convert.ToDouble(textBox3.Text);

            while (!reader.EndOfStream)
            {

                string lineaActual = reader.ReadLine();
                string[] datos = lineaActual.Split('&');
                if (datos[0] == Cliente)

                {
                    if (Convert.ToDouble(datos[6]) >= Retiro)
                    {
                        Retiro = Convert.ToDouble(datos[6]) - Retiro;

                        writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}", datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], Retiro);
                    }
                    else
                    {
                        MessageBox.Show("Fondos Insuficientes");
                        return;
                    }
                }

                else
                {
                    writer.WriteLine(lineaActual);
                }
            }

            writer.Close();
            reader.Close();
            File.Replace(fileCopia, fileName, null, true);

            Double consig = 0;

            string fileName1 = "clientes.txt";
            string fileCopia1 = "copia_clientes.txt";
            StreamWriter writer1 = File.AppendText(fileCopia1);
            StreamReader reader1 = File.OpenText(fileName1);

            string clie = (textBox2.Text);

            consig = Convert.ToDouble(textBox3.Text);

            while (!reader1.EndOfStream)
            {

                string lineaActual2 = reader1.ReadLine();
                string[] datos = lineaActual2.Split('&');
                if (datos[0] == clie)
                {
                    consig = consig + Convert.ToDouble(datos[6]);

                    writer1.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}", datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], consig);
                }
                else
                {
                    writer1.WriteLine(lineaActual2);
                }
            }
            writer1.Close();
            reader1.Close();
            File.Replace(fileCopia1, fileName1, null, true);
            MessageBox.Show("Transaccion Realizada con Exito");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

    }
}