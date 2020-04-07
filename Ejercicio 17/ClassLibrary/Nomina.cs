using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Nomina
    {
        static int tamaño = 5;
        static Empleados[] e = new Empleados[tamaño];
        public static string Area
        {
            set
            {
                string area = value;
            }
            get
            {
                return Area;
            }
        }
        public static string Empresa
        {
            set
            {
                string empresa = value;
            }
            get
            {
                return Empresa;
            }
        }
        public static DateTime FechaDePago
        {
            set
            {
                DateTime fechaPago = value;
            }
            get
            {
                return FechaDePago;
            }
        }
        public static Empleados[] GetEmpleados
        {
            get
            {
                return e;
            }
        }
        public static Empleados ObtenerEmpleadoMasCaro(Empleados[] lista)
        {
            Empleados empleadoMayorSalario = new Empleados("", 0);
            double maxSueldo = 0;
            for (int i = 0; i < lista.GetUpperBound(0); i++)
            {
                if (lista[i].Sueldo < maxSueldo)
                {
                    maxSueldo = lista[i].Sueldo;
                }
            }
            int pos = 0;
            do
            {
                if (lista[pos].Sueldo == maxSueldo)
                {
                    empleadoMayorSalario = lista[pos];
                }
                pos++;
            } while (pos < lista.GetUpperBound(0));
            return empleadoMayorSalario;
        }
    }
}
