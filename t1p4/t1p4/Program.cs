using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1p4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, s, A, t, r, p1, p2, pdto;
            Console.WriteLine("para poder calcular el área de un triángulo debera conocer la medida de algunos de sus lados según sea el caso");

            do
            {
                Console.WriteLine("que tipo de triángulo desea calcular, para equilatero presione 1, para isoceles presione 2, para escaleno presione 3, para rectángulo presione 4");
                t = int.Parse(Console.ReadLine());
                if (t <= 0 || t > 4)
                    Console.WriteLine("dato incorrecto, intente de nuevo por favor");
            } while (t <= 0 || t > 4);
            if (t == 1)
            {
                Console.WriteLine("por favor ingrese la medida de un lado");
                a = Math.Abs(double.Parse(Console.ReadLine()));
                r = Math.Pow(3, 0.5);
                p1 = Math.Pow(a, 2);
                A = (r/4) * p1;
                Console.WriteLine("el área del triángulo equilatero es: {0}", A);
            }
            else
                if (t == 2)
            {
                Console.WriteLine("por favor ingrese la medida preferiblemente de un lado largo");
                a = Math.Abs(double.Parse(Console.ReadLine()));
                Console.WriteLine("por favor ingrese la medida preferiblemente del lado corto");
                b = Math.Abs(double.Parse(Console.ReadLine()));
                if (b > a)
                {
                    c = a;
                    a = b;
                    b = c;
                    p1 = Math.Pow(a, 2);
                    p2 = Math.Pow(b, 2);
                    r = Math.Pow((p1 - (p2 / 4)), 0.5);
                    A = (b * r) / 2;
                    Console.WriteLine("el área del triángulo isoceles es: {0}", A);
                }
                else
                {
                    p1 = Math.Pow(a, 2);
                    p2 = Math.Pow(b, 2);
                    r = Math.Pow((p1 - (p2 / 4)), 0.5);
                    A = (b * r) / 2;
                    Console.WriteLine("el área del triángulo isoceles es: {0}", A);
                }
                
            }
            else
                if (t == 3)
            {
                Console.WriteLine("por favor ingrese la medida del lado a");
                a = Math.Abs(double.Parse(Console.ReadLine()));
                Console.WriteLine("por favor ingrese la medida del lado b");
                b = Math.Abs(double.Parse(Console.ReadLine()));
                Console.WriteLine("por favor ingrese la medida del lado c");
                c = Math.Abs(double.Parse(Console.ReadLine()));
                s = (a + b + c) / 2;
                pdto = (s * (s - a) * (s - b) * (s - c));
                r = Math.Pow(pdto, 0.5);
                A = r;
                Console.WriteLine("el área del triángulo escaleno es: {0}", A);
            }
            else
            {
                Console.WriteLine("por favor ingrese la medida del cateto a");
                a = Math.Abs(double.Parse(Console.ReadLine()));
                Console.WriteLine("por favor ingrese la medida del cateto b");
                b = Math.Abs(double.Parse(Console.ReadLine()));
                A = (b * a) / 2;
                Console.WriteLine("el área del triángulo rectángulos es: {0}", A);
            }
        }
    }
}
