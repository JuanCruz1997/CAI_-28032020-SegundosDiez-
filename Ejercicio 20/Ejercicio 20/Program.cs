using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número:");
            int numero = Comprobaciones.ValidarIntPositivo();
            int[] numeros = new int[numero];
            int contadorPrimos = 0;
            for (int i = 1; i < numero; i++)
            {
                numeros[i] = i;
                if (Comprobaciones.esPrimo(numeros[i]))
                {
                    contadorPrimos++;
                }
            }
            int factorial = Comprobaciones.CalcularFactorial(numero);
            Console.WriteLine("Hasta el número " + numero + " hay " + contadorPrimos + " números primos.\nEl factorial de " + numero + " es " + factorial);
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
