using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracterIngresado;
            bool error = false;
            Console.WriteLine("Ingrese el caracter a evaluar:");
            do
            {
                error = false;
                if (!char.TryParse(Console.ReadLine().ToLower(), out caracterIngresado))
                {
                    Console.WriteLine("No se ha ingresado un caracter. Imposible evaluar cadena de texto.");
                    error = true;
                }
            } while (error);
            if (char.IsDigit(caracterIngresado))
            {
                Console.WriteLine("Se ha ingresado el número "+caracterIngresado);
            } else if (char.IsLetter(caracterIngresado))
            {
                switch (caracterIngresado)
                {
                    case 'a':
                        Console.WriteLine("Se ha ingresado la vocal "+caracterIngresado);
                        break;
                    case 'e':
                        Console.WriteLine("Se ha ingresado la vocal " + caracterIngresado);
                        break;
                    case 'i':
                        Console.WriteLine("Se ha ingresado la vocal " + caracterIngresado);
                        break;
                    case 'o':
                        Console.WriteLine("Se ha ingresado la vocal " + caracterIngresado);
                        break;
                    case 'u':
                        Console.WriteLine("Se ha ingresado la vocal " + caracterIngresado);
                        break;
                    default:
                        Console.WriteLine("Se ha ingresado la consonante " + caracterIngresado);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lo que se ha ingresado no es un número ni una letra");
            }
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
