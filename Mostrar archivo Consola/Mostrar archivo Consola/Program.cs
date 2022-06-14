using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrar_archivo_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "programa.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open,
            FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1) Console.WriteLine(reader.ReadLine());
            reader.Close();
            Console.ReadLine();
        }                       
    }
}
