using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1p5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, lc, ac, volc, volccc;
            int n1, seguir;
            Console.WriteLine("por medio del siguiente programa podrá calcular (presionando el número correspondiente): Longitud de la Circunferencia (1), área de la circunferencia (2), volumen del cilindro (3), volumen cono circular recto (4)");
            do
            {
                Console.WriteLine("digite la opción que desea calcular");
                n1 = int.Parse(Console.ReadLine());
                if (n1 <= 0 || n1 > 4)
                    Console.WriteLine("opción incorrecta");
            } while (n1 <= 0 || n1 > 4);
            Console.WriteLine("ADVERTENCIA: todo número negativo ingresado para el cálculo será convertido a número positivo");
            switch (n1)
            {
                case 1:
                    Console.WriteLine("ingrese el valor del radio");
                    r = Math.Abs(double.Parse(Console.ReadLine()));
                    lc = 2 * Math.PI * r;
                    Console.WriteLine("la longitud de la circunferencia es: {0}", lc);
                    break;
                case 2:
                    Console.WriteLine("ingrese el valor del radio");
                    r = Math.Abs(double.Parse(Console.ReadLine()));
                    ac = Math.PI * Math.Pow(r,2);
                    Console.WriteLine("el área de la circunferencia es: {0}", ac);
                    break;
                case 3:
                    Console.WriteLine("ingrese el valor del radio");
                    r = Math.Abs(double.Parse(Console.ReadLine()));
                    Console.WriteLine("ingrese el valor de la altura");
                    h = Math.Abs(double.Parse(Console.ReadLine()));
                    volc = Math.PI * Math.Pow(r, 2) * h;
                    Console.WriteLine("el volumen del cilindro es: {0}", volc);
                    break;
                case 4:
                    Console.WriteLine("ingrese el valor del radio");
                    r = Math.Abs(double.Parse(Console.ReadLine()));
                    Console.WriteLine("ingrese el valor de la altura");
                    h = Math.Abs(double.Parse(Console.ReadLine()));
                    volccc = (1/3) * Math.PI * Math.Pow(r, 2) * h;
                    Console.WriteLine("el volumen del cilindro es: {0}", volccc);
                    break;
            }
            Console.WriteLine("presione el número 0 si desea seguir calculando y presione 5 para terminar");
            seguir = int.Parse(Console.ReadLine());
            do
            {
                if (seguir == 0)
                {
                    do
                    {
                        Console.WriteLine("digite la opción que desea calcular");
                        n1 = int.Parse(Console.ReadLine());
                        if (n1 <= 0 || n1 > 4)
                            Console.WriteLine("opción incorrecta");
                    } while (n1 <= 0 || n1 > 4);
                    switch (n1)
                    {
                        case 1:
                            Console.WriteLine("ingrese el valor del radio");
                            r = Math.Abs(double.Parse(Console.ReadLine()));
                            lc = 2 * Math.PI * r;
                            Console.WriteLine("la longitud de la circunferencia es: {0}", lc);
                            break;
                        case 2:
                            Console.WriteLine("ingrese el valor del radio");
                            r = Math.Abs(double.Parse(Console.ReadLine()));
                            ac = Math.PI * Math.Pow(r, 2);
                            Console.WriteLine("el área de la circunferencia es: {0}", ac);
                            break;
                        case 3:
                            Console.WriteLine("ingrese el valor del radio");
                            r = Math.Abs(double.Parse(Console.ReadLine()));
                            Console.WriteLine("ingrese el valor de la altura");
                            h = Math.Abs(double.Parse(Console.ReadLine()));
                            volc = Math.PI * Math.Pow(r, 2) * h;
                            Console.WriteLine("el volumen del cilindro es: {0}", volc);
                            break;
                        case 4:
                            Console.WriteLine("ingrese el valor del radio");
                            r = Math.Abs(double.Parse(Console.ReadLine()));
                            Console.WriteLine("ingrese el valor de la altura");
                            h = Math.Abs(double.Parse(Console.ReadLine()));
                            volccc = (1 / 3) * Math.PI * Math.Pow(r, 2) * h;
                            Console.WriteLine("el volumen del cilindro es: {0}", volccc);
                            break;
                    }
                }
                else
                    Console.WriteLine("cálculos terminados");
            } while (seguir == 0);
            Console.ReadKey();
            
        }
    }
}
