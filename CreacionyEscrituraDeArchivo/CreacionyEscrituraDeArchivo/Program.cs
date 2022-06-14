using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionyEscrituraDeArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            try
            {
                string FileName = "temp.txt";
                StreamWriter writer = File.AppendText(FileName);
                writer.WriteLine("Este es el texto adicionado");
                writer.WriteLine("El archivo se ha creado Hello World");
              Console.WriteLine("El archivo se ha creado Hello World");
             writer.Close();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.Read();
        }
    }
}
