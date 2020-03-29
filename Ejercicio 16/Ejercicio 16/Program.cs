using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso = "";
            int comprobacion = 0;
            bool error = false;
            Console.WriteLine("Ingrese el número del cual desea conocer la cantidad de dígitos:");
            do
            {
                error = false;
                ingreso = Console.ReadLine();
                if (!int.TryParse(ingreso, out comprobacion))
                {
                    Console.WriteLine("No se ha ingresado un número entero.");
                    error = true;
                }
            } while (error);
            int cantDigitos = ingreso.Length;
            Console.WriteLine("Número ingresado: " + comprobacion + " - Tiene " + cantDigitos + " dígitos.");
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
