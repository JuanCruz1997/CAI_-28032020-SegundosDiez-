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
            int tamaño = 5;
            double maxSueldo = 0;
            Empleados[] empleados = new Empleados[tamaño];
            Console.WriteLine("Base de datos de empleados:");
            for(int i = 0; i <= empleados.GetUpperBound(0); i++)
            {
                Console.WriteLine("Ingrese los datos del empleado " + (i + 1) + ":");
                Console.WriteLine("Nombre:");
                string nombre = Validaciones.ValidarString();
                Console.WriteLine("Sueldo:");
                double sueldo = Validaciones.ValidarDouble();
                empleados[i] = new Empleados(nombre, sueldo);
                if (sueldo > maxSueldo)
                {
                    maxSueldo = sueldo;
                }
            }
            string empleadoMayorSalario = Empleados.ObtenerEmpleadoSueldoMaximo(empleados, maxSueldo);
            Console.WriteLine("Mayor salario: "+maxSueldo+"\nEmpleado: "+empleadoMayorSalario);
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
