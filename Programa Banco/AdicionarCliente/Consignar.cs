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
    public partial class Consignar : Form
    {
        public Consignar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RealizarConsignacion();
            this.Close();
        }
        //Realizar una consignacion
        public void RealizarConsignacion()
        {
            Double consig = 0;
            //este es el nombre del archivo que administra los clientes
            string fileName = "clientes1.txt";
            //este es el nombre de un archivo de copia
            string fileCopia = "copia_clientes1.txt";
            // esto inserta texto en un archivo existente, si el archivo no existe lo crea
            StreamWriter writer = File.AppendText(fileCopia);
            StreamReader reader = File.OpenText(fileName);

            //este vector es para realizar la presentación de los datos

            string consigA = (textBox1.Text);

            consig = Convert.ToDouble(textBox2.Text);



            while (!reader.EndOfStream)
            {
                //este contador es para moverse entre las diferentes etiquetas
                string lineaActual = reader.ReadLine();
                string[] datos = lineaActual.Split('&');
                if (datos[0] == consigA)
                {
                    consig = consig + Convert.ToDouble(datos[6]);

                    writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}", datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], consig);
                }
                else
                {
                    writer.WriteLine(lineaActual);
                }
            }
            writer.Close();
            reader.Close();
            File.Replace(fileCopia, fileName, null, true);
        }
    }
}

