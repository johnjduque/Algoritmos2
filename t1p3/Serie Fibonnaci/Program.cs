using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort n;
            int a = 0, b = 1, i = 2, f;

            Console.WriteLine("Por favor ingrese los números a generar de la serie");
            n = ushort.Parse(Console.ReadLine());
            Console.WriteLine("inicio de la serie");
            if (n <= 0)
                Console.WriteLine("valor incorrecto");
            else
            if (n == 1)
                Console.WriteLine("{0}", 0);
            else
            if (n == 2)
            {
                Console.WriteLine("{0}", 0);
                Console.WriteLine("{0}", 1);
            }
            else
            {
                
                Console.WriteLine("{0}", 0);
                Console.WriteLine("{0}", 1);
            }
            while (i < n)
            {
                f = a + b;
                a = b;
                b = f;
                i++;
                Console.WriteLine("{0}", f);
            }
            Console.WriteLine("fin de la serie");
        }
    }
}
