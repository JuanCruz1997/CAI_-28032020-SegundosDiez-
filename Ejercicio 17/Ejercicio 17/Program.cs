using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base de datos de empleados:");
            Nomina n = new Nomina();
            int i = 0;
            while (i <= n.GetEmpleados.GetUpperBound(0))
            {
                Console.WriteLine("Ingrese los datos del empleado " + (i + 1) + ":");
                Console.WriteLine("Nombre:");
                string nombre = "";
                do
                {
                    nombre = Validaciones.ValidarString(Console.ReadLine());
                    if (nombre == "")
                    {
                        Console.WriteLine("Error. No ha ingresado un nombre. Intente otra vez.");
                    }
                } while (nombre == "");
                double sueldo = 0;
                Console.WriteLine("Sueldo:");
                do
                {
                    sueldo = Validaciones.ValidarDouble(Console.ReadLine());
                    if (sueldo == -1)
                    {
                        Console.WriteLine("Error. No ha ingresado un número válido. Intente otra vez.");
                    }
                } while (sueldo == -1);
                n.AddEmpleado(nombre, sueldo, i);
                i++;
            }
            Empleados caro = n.ObtenerEmpleadoMasCaro();
            Console.WriteLine("Mayor salario: "+caro.Sueldo+"\nEmpleado: "+caro.Nombre);
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
