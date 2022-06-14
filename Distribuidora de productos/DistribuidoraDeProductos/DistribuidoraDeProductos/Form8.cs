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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                   
            try
            {
                StreamReader Arch = new StreamReader("Pedidos.txt ");
                int fila = 0;
                while (Arch.EndOfStream == false)
                {
                    String cliente = t1.Text;
                    String fecha = textBox1.Text;
                    string[] Vect = Arch.ReadLine().Split('&');
                    if (Vect[0].Trim().Equals(cliente) && Vect[1].Trim().Equals(fecha))
                    {
                        Pedido pedido = new Pedido();
                        pedido.fecha = Vect[1];
                        pedido.codigoProducto = Vect[2];
                        pedido.cedulaCliente = Vect[0];
                        pedido.cantidad = Vect[3];


                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[fila].Cells["Date"].Value = pedido.fecha;
                        dataGridView2.Rows[fila].Cells["CodProd"].Value = pedido.codigoProducto;
                        dataGridView2.Rows[fila].Cells["IdCliente"].Value = pedido.cedulaCliente;
                        dataGridView2.Rows[fila].Cells["Cant"].Value = pedido.cantidad;


                        fila++;


                    }
                }
                Arch.Close();
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

        public struct Pedido
        {
            public string fecha;
            public string codigoProducto;
            public string cedulaCliente;
            public string cantidad;

        }
    }
}
    
