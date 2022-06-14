using System;
using System.IO;
namespace EjemARchivos22020
{
    class Program
    {

        class Archivo
        {
            StreamReader sr;
            bool abierto = false;
            // Constructor: Recibe el nombre del archivo y lo abre (con control errores)
            public Archivo(string filename)
            {
                try
                {
                    sr = new StreamReader(filename);
                    abierto = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error en la apertura de \"{0}\": {1}",
                    filename, e.ToString());
                }
            }
            public void Mostrar()
            {
                string linea;
                if (!abierto) return; // Si no se pudo abrir, no hay nada que leer
                linea = sr.ReadLine();
                while (linea != null)
                { // Lee líneas mientras haya (mientras sean !=null)
                    Console.WriteLine(linea);
                    linea = sr.ReadLine();
                }
                sr.Close(); abierto = false;
            }
        }
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Nombre del archivo: ");
            nombre = Console.ReadLine();
            Archivo archivo = new Archivo(nombre);
            archivo.Mostrar();
            Console.ReadLine();
        }

    }
}
