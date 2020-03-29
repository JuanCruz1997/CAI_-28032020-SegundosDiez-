using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            int maxIntentos = 3;
            string contraseña = "";
            Console.WriteLine("Bienvenido.\nIngrese su usuario:");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña:");
            do
            {
                contraseña = Console.ReadLine();
                if (contraseña != usuario)
                {
                    Console.WriteLine("Acceso denegado. La contraseña no es correcta.");
                }
                intentos++;
            } while (contraseña != usuario && intentos < maxIntentos);
            if (intentos >= maxIntentos)
            {
                Console.WriteLine("Clave bloqueada.");
            }
            else
            {
                Console.WriteLine("Bienvenido " + usuario);
            }
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
