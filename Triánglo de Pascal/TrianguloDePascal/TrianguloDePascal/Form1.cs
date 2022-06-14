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

namespace TrianguloDePascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamReader sr;

        private void button1_Click(object sender, EventArgs e)
        {
            
            int lineas = int.Parse(textBox1.Text);
            int lineaPos = Math.Abs(lineas);
            System.IO.File.WriteAllText(@"TextFile.txt", string.Empty);
            Operacion(lineaPos);
            Procesar();           
        }
        
        public void Operacion(int numero)
        {
            string fileName = "TextFile.txt";

            StreamWriter writer = File.AppendText(fileName);

            for (int i=0; i<numero; i++)
            {
                //for(int j=numero; j>i; j--)
                //{
                    //writer.Write(" ");
                //}
                int valor = 1;
                for (int j=0; j<=i; j++)
                {
                    writer.Write(valor + " ");
                    valor = valor * (i - j) / (j + 1);
                }
                writer.WriteLine(" ");
            }
            
            writer.Close();
        }
        

        public void Procesar()
        {
            string FileName = "TextFile.txt";
            FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
                listBox1.Items.Add(reader.ReadLine());
            reader.Close();
        }
    }
}