using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "TextFile1.txt";
            FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
                Console.WriteLine(reader.ReadLine());
            reader.Close();
            Console.ReadLine();
        }
    }
}
