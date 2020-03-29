using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroIngresado = 0;
            int maxTabla = 10;
            bool error = false;
            Console.WriteLine("Ingrese un número entero positivo para obtener su tabla:");
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
                    Console.WriteLine("No se ha ingresado un número positivo.");
                }
            } while (nroIngresado < 0);
            Console.WriteLine("Tabla del " + nroIngresado);
            for(int i = 1; i <= maxTabla; i++)
            {
                Console.WriteLine(nroIngresado + " x " + i + " = " + nroIngresado * i);
            }
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
