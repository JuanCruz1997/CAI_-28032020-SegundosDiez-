using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Comprobaciones
    {
        public static Boolean esPrimo(int numeroAEvaluar)
        {
            bool respuesta = false;
            int contadorDivisores = 0;
            for (int i = 1; i <= numeroAEvaluar; i++)
            {
                int numero = numeroAEvaluar % i;
                if (numero == 0)
                {
                    contadorDivisores++;
                }
                if (contadorDivisores > 2)
                {
                    respuesta = false;
                }
                if (numeroAEvaluar == i && contadorDivisores <= 2)
                {
                    respuesta = true;
                }
            }
            return respuesta;
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
        public static int CalcularFactorial(int numero)
        {
            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
