using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1p6
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, i1, c, vf;
            int m, m1, l;
            Console.WriteLine("por favor ingresar el valor del capital");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar el intéres efectivo mensual en %");
            i = (double.Parse(Console.ReadLine()));
            Console.WriteLine("ingresar el número de meses");
            m = int.Parse(Console.ReadLine());
            m1 = 1;
            for (l = 1; l <= m; l++)
            {
                i1 = i / 100;
                vf = c * Math.Pow((1 + i1), m1);
                m1++;
                Console.WriteLine("el valor final para el mes {0} será {1}", l, vf);
            }
            Console.ReadKey();
        }
    }
}
