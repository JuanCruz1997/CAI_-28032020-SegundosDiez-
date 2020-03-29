using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de palabras que va a ingresar:");
            int cantPalabras = Validaciones.ValidarIntPositivo();
            String[] palabras = new string[cantPalabras];
            Console.WriteLine("Ingrese las palabras de una en una, separándolas usando Intro:");
            for (int i = 0; i <= palabras.GetUpperBound(0); i++)
            {
                palabras[i] = Validaciones.ValidarString();
            }
            Console.WriteLine("El largo de cada palabra es:");
            for(int i = 0; i <= palabras.GetUpperBound(0); i++)
            {
                int largo = palabras[i].Length;
                Console.WriteLine(palabras[i] + " - Largo: " + largo);
            }
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
