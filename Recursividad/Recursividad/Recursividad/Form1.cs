using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Nodo
        {

            public double Valor;
            public Nodo siguiente;
            //Constructor
            public Nodo()
            {

                this.Valor = 0;
                this.siguiente = null;
            }


        }

        Nodo Lista = null;
        Nodo borrar;

        private void button1_Click(object sender, EventArgs e)
        {
            //Metodo para crear la Lista
            Nodo anterior;


            Nodo nuevo = new Nodo();
            nuevo.Valor = int.Parse(t1.Text);

            nuevo.siguiente = null;


            if (Lista == null)
            {
                nuevo.siguiente = Lista;
                Lista = nuevo;
            }
            else
            {
                anterior = Lista;
                while (anterior.siguiente != null)
                {
                    anterior = anterior.siguiente;
                }

                anterior.siguiente = nuevo;
            }
            t1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Metodo para Mostara los elementos
            Nodo nodo;
            if (Lista == null)
                MessageBox.Show("Lista Vacia");
            else
            {
                nodo = Lista;

                while (nodo != null)
                {
                    MessageBox.Show("Elementos Lista ");

                    lbSalida.Items.Add(nodo.Valor);
                    t2.Text = (nodo.Valor).ToString();
                    nodo = nodo.siguiente;
                }


            }

        }

        private void lbSalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Metodo para Buscar un nodo en la Lista

            Nodo nodo = Lista;
            int busca = int.Parse(t1.Text);
            int sw = 0;
            while (nodo != null && sw == 0)
            {
                if (nodo.Valor == busca)
                    sw = 1;

                else
                    nodo = nodo.siguiente;
            }
            if (sw == 1)
            {
                borrar = nodo;
                MessageBox.Show("Elemento encontrado, Muy Bien");
            }
            else
                MessageBox.Show("Elemento No encontrado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Borrar Nodo ESpecificado

            Nodo Q;
            if (Lista == null)
                MessageBox.Show("Lista Vacia");
            else
            {
                if (Lista == borrar) //Borra el Primer Nodo
                    Lista = Lista.siguiente;
                else
                {
                    Q = Lista;
                    while (Q.siguiente != null)
                    {

                        if (Q.siguiente == borrar)

                            Q.siguiente = Q.siguiente.siguiente;

                        else
                            Q = Q.siguiente;

                    }//Fin del While
                }

            }
            MessageBox.Show("Elemento Borrado");

        }//fIN DE bORRAR

        private void button5_Click(object sender, EventArgs e)
        {
            lbSalida.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MostraRec(Lista);

        }

        public Nodo MostraRec(Nodo nodo)
        {


            if (nodo != null)
            {

                //return MostraRec(nodo.siguiente);
                t1.Text = nodo.Valor.ToString();
                MessageBox.Show("Recorrido Recursivo" + nodo.Valor);
                return MostraRec(nodo.siguiente);
            }

            else
            {

                //t1.Text = nodo.Valor.ToString();
                MessageBox.Show("Fin de la Lista");
                return nodo;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Buscar_rec(Lista);
        }

        //Metodo Recursivo para Buscar un Nodo
        public Nodo Buscar_rec(Nodo nodobuscar)
        {


            int busca = int.Parse(t1.Text);



            if (nodobuscar.Valor == busca)
            {
                borrar = nodobuscar;
                MessageBox.Show("Elemento Encontrado");
                return borrar;
            }

            else if (nodobuscar.siguiente != null)

                return Buscar_rec(nodobuscar.siguiente);

            MessageBox.Show("Elemento no Encontrado");
            return null;


        }
    }
}

