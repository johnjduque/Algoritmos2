using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1p10
{
    class Program
    {
        static void Main(string[] args)
        {
            int lim, i, c;
            do
            {
                Console.WriteLine("presione 1 para visualizar las potencias de 2 entre 0 y 10");
                lim = int.Parse(Console.ReadLine());
                if (lim != 1)
                    Console.WriteLine("valor incorrecto");
            } while (lim != 1);
            for (i=0; i<11; i++)
            {
                c = 0;
                for (c=0; c<=i; c++)
                {
                    if (Math.Pow(2, c) == i)
                        Console.WriteLine("es una potencia de 2: {0}", i);
                }
            }
            Console.ReadLine();
        }
    }
}
