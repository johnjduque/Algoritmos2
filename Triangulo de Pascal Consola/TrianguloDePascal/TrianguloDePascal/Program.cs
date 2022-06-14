using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloDePascal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuántas líneas desea generar");
            int numero = Math.Abs(int.Parse(Console.ReadLine()));

            for (int i = 0; i < numero; i++)
            {
                //for (int j = numero; j > i; j--)
                //{
                    //Console.Write(" ");
                //}
                int valor = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(valor + " ");
                    valor = valor * (i - j) / (j + 1);
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
