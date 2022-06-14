using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1p9
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra, inverso, caracter;
            int i;
            Console.WriteLine("palabra que desea evualuar, por favor ingrese la palabra sin espacios y sin signos de putuación");
            palabra = Convert.ToString(Console.ReadLine());
            palabra = palabra.Replace(" ", "");
            palabra = palabra.Replace(".", "");
            palabra = palabra.Replace(",", "");
            palabra = palabra.Replace(";", "");
            palabra = palabra.Replace(":", "");
            i = palabra.Length;
            inverso = "";
            for (int x = i - 1; x >= 0; x--)
            {
                caracter = palabra.Substring(x, 1);
                inverso = inverso + caracter;
            }
            Console.WriteLine("inverso de la palabra");
            Console.WriteLine(inverso);
            if (palabra == inverso)
            {
                Console.WriteLine("es palindrome", Console.ForegroundColor = ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine("no es palindrome", Console.ForegroundColor = ConsoleColor.Red);
            }
            Console.ReadKey();

        }
    }
}