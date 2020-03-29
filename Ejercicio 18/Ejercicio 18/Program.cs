using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double nroIngresado = 0;
            Console.WriteLine("Ingrese número decimal:");
            nroIngresado = Validaciones.ValidarDouble();
            string binario = Conversion.ObtenerBinario(nroIngresado);
            string octal = Conversion.ObtenerOctal(nroIngresado);
            string hexadecimal = Conversion.ObtenerHexadecimal(nroIngresado);
            Console.WriteLine("El número " + nroIngresado + " se expresa como:\nBinario: " + binario + "\nOctal: " + octal + "\nHexadecimal: " + hexadecimal);
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
