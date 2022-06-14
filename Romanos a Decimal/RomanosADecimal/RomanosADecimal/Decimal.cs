using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanosADecimal
{
    class Decimal
    {
        public int SimplerConverter(String numero)
        {
            numero = numero.ToUpper();
            int resultado = 0;
            foreach (char letra in numero)
            {
                resultado += LetraANumero(letra);
            }

            if (numero.Contains("IV") || numero.Contains("IX"))
                resultado -= 2;

            if (numero.Contains("XL") || numero.Contains("XC"))
                resultado -= 20;

            if (numero.Contains("CD") || numero.Contains("CM"))
                resultado -= 200;

            return resultado;
        }

        public int LetraANumero(char letra)
        {
            switch (letra)
            {
                case 'M':
                    {
                        return 1000;
                    }
                case 'D':
                    {
                        return 500;
                    }
                case 'C':
                    {
                        return 100;
                    }
                case 'L':
                    {
                        return 50;
                    }
                case 'X':
                    {
                        return 10;
                    }
                case 'V':
                    {
                        return 5;
                    }
                case 'I':
                    {
                        return 1;
                    }
                default:
                    {
                        throw new ArgumentException("Caracter inválido");
                    }
            }
        }
    }
}
