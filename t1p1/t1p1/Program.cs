using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1p1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            string oper;

            Console.WriteLine("Digite VAriables A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite VAriables B");
            b = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Digite operador");
                oper = Console.ReadLine();
                if (oper != "+" && oper != "-" && oper != "*" && oper != "/")

                    Console.WriteLine("OperADOR iNCORRECTO");
            } while (oper != "+" && oper != "-" && oper != "*" && oper != "/");



            switch (oper)
            {
                case "+":
                    Console.WriteLine("SUma de VAriables {0:f2}", a + b);
                    break;
                case "-":
                    Console.WriteLine("Resta de variables {0}", a - b);
                    break;
                case "*":
                    Console.WriteLine("Multiplicacion de variables {0}", a * b);
                    break;
                case "/":
                    Console.WriteLine("Division de variables {0}", a / b);
                    break;
            }

            Console.Read();
        }



    }
}