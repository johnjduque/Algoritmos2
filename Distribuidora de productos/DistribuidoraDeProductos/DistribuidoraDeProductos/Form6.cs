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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader Arch = new StreamReader("Productos.txt ");
            int fila = 0;
            while (Arch.EndOfStream == false)
            {
                string[] Vect = Arch.ReadLine().Split('&');
                Producto pro = new Producto();
                pro.codigo = Vect[0];
                pro.nombre = Vect[1];
                pro.precio = Vect[2];
                pro.inventario = Vect[3];


                dataGridView1.Rows.Add();
                dataGridView1.Rows[fila].Cells["Codigo"].Value = pro.codigo;
                dataGridView1.Rows[fila].Cells["Nombre"].Value = pro.nombre;
                dataGridView1.Rows[fila].Cells["Precio"].Value = pro.precio;
                dataGridView1.Rows[fila].Cells["Inventario"].Value = pro.inventario;


                fila++;

            }
            Arch.Close();
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
