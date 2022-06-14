using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1p8
{
    class Program
    {
        static void Main(string[] args)
        {
            int lim, i, c, j;
            do
            {
                Console.WriteLine("hasta que número desea generar los números primos");
                lim = int.Parse(Console.ReadLine());
                if (lim < 2)
                    Console.WriteLine("valor incorrecto ingrese valores mayores que 1");
            } while (lim < 2);
            for (i = 1; i <= lim; i++)
            {
                c = 0;
                for (j=1; j<=i; j++)
                {
                    if (i%j == 0)
                    {
                        c++;
                    } 
                }
                if (c == 2)
                    Console.WriteLine(i);
            }
 
            Console.ReadKey();
        }
    }
}
