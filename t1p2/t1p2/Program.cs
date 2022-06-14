using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, aux, r;
            Console.WriteLine("ingrese el valor del primer número");
            a = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("ingrese el valor del segundo número");
            b = Math.Abs(int.Parse(Console.ReadLine()));

            if (b > a)
            {
                aux = a;
                a = b;
                b = aux;
                do
                {
                    r = a % b;
                    a = b;
                    b = r;
                }while (b != 0);
                Console.WriteLine("el m.c.d es: {0}", a);
            }
            else
            {
                do
                {
                    r = a % b;
                    a = b;
                    b = r;
                }while (b != 0);
                Console.WriteLine("el m.c.d es: {0}", a);
            }
        }
    }
}
