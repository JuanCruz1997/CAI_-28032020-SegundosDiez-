using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cálculos;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroIngresado = 0;
            bool error = false;
            Console.WriteLine("Ingrese un número entero positivo para obtener su factorial:");
            do
            {
                do
                {
                    error = false;
                    if (!int.TryParse(Console.ReadLine(), out nroIngresado))
                    {
                        Console.WriteLine("No se ha ingresado un número, o bien, el número ingresado no es entero.");
                        error = true;
                    }
                } while (error);
                if (nroIngresado < 0)
                {
                    Console.WriteLine("No existe el factorial de números enteros negativos.");
                }
            } while (nroIngresado < 0);
            Factorial factorial = new Factorial();
            int resultado = factorial.CalcularFactorial(nroIngresado);
            Console.WriteLine("Cálculo del factorial:\n" + nroIngresado + "!= " + resultado);
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
