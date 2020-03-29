using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public static class Validaciones
    {
        public static string ValidarString()
        {
            int comprobacion = 0;
            string palabra = "";
            bool correcto = true;
            do
            {
                correcto = true;
                palabra = Console.ReadLine();
                if (int.TryParse(palabra, out comprobacion))
                {
                    Console.WriteLine("Error. No ha ingresado un nombre. Intente otra vez.");
                    correcto = false;
                }
            } while (!correcto);
            return palabra;
        }
        public static double ValidarDouble()
        {
            double comprobacion = 0;
            string numero = "";
            bool correcto = true;
            do
            {
                do
                {
                    numero = Console.ReadLine();
                    correcto = true;
                    if (!double.TryParse(numero, out comprobacion))
                    {
                        Console.WriteLine("Error. No ha ingresado un número válido. Intente otra vez.");
                        correcto = false;
                    }
                } while (!correcto);
                if (comprobacion < 0)
                {
                    Console.WriteLine("Error. Debe ingresar un número positivo.");
                }
            } while (comprobacion < 0);
            return comprobacion;
        }
    }
}
