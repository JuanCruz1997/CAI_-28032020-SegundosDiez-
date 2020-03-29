using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
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
                    Console.WriteLine("Error. No ha ingresado una palabra. Intente otra vez.");
                    correcto = false;
                }
            } while (!correcto);
            return palabra;
        }
        public static int ValidarIntPositivo()
        {
            int numero = 0;
            bool error = false;
            do
            {
                do
                {
                    error = false;
                    if (!int.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine("Error. No ha ingresado un número.");
                        error = true;
                    }
                } while (error);
                if (numero <= 0)
                {
                    Console.WriteLine("Error. Debe ingresar un número positivo distinto de 0");
                }
            } while (numero <= 0);
            return numero;
        }
    }
}
