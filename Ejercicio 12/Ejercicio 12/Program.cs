using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1;
            DateTime fecha2;
            bool error = false;
            Console.WriteLine("Diferencia de fechas:");
            Console.WriteLine("Ingrese la primer fecha:");
            do
            {
                error = false;
                if (!DateTime.TryParse(Console.ReadLine(), out fecha1))
                {
                    Console.WriteLine("Lo ingresado no puede reconocerse como fecha.");
                    error = true;
                }
            } while (error);
            Console.WriteLine("Ingrese la segunda fecha:");
            do
            {
                error = false;
                if (!DateTime.TryParse(Console.ReadLine(), out fecha2))
                {
                    Console.WriteLine("Lo ingresado no puede reconocerse como fecha.");
                    error = true;
                }
            } while (error);
            double totalDias = Math.Abs((fecha1 - fecha2).TotalDays);
            double años = Math.Floor(totalDias / 365);
            totalDias = totalDias - años * 365;
            double meses = Math.Floor(totalDias / 31);
            totalDias = totalDias - meses * 31;
            double dias = totalDias;
            Console.WriteLine("La diferencia es de " + años + " años, "+meses+" meses y "+dias+" días.");
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
