using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribuidoraDeProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.MdiParent = this;
            frm6.Show();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.MdiParent = this;
            frm7.Show();
        }

        private void listarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.MdiParent = this;
            frm8.Show();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.MdiParent = this;
            frm9.Show();
        }
    }
}
