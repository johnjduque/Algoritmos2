using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, t;
            double mayor, menor;
            double[] datos;
            Console.WriteLine("Cuántos números desea digitar");
            t = int.Parse(Console.ReadLine());
            datos = new double[t];
            for (i = 0; i < t; i++)
            {
                Console.WriteLine("digite el valor de la posición {0}", (i+1));
                datos[i] = double.Parse(Console.ReadLine());
            }
            mayor = datos[0];
            menor = datos[0];
            for (i=0; i<t; i++)
            {
                if (datos[i] > mayor)
                    mayor = datos[i];
                else if (datos[i] < menor)
                    menor = datos[i];
            }
            Console.WriteLine("el número mayor ingresado fue: {0}", mayor);
            Console.WriteLine("el número menor ingresado fue: {0}", menor);
            Console.ReadKey();
        }
    }
}
