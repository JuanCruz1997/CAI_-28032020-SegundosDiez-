using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Nomina
    {
        static int tamaño = 5;
        static Empleados[] e = new Empleados[tamaño];
        public string Area
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
        public string Empresa
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
        public DateTime FechaDePago
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
        public Empleados[] GetEmpleados
        {
            get
            {
                return e;
            }
        }
        public void AddEmpleado(string nombre, double sueldo, int pos)
        {
            e[pos] = new Empleados(nombre, sueldo);
        }
        public Empleados ObtenerEmpleadoMasCaro()
        {
            Empleados empleadoMayorSalario = new Empleados("", 0);
            double maxSueldo = 0;
            for (int i = 0; i < e.GetUpperBound(0); i++)
            {
                if (e[i].Sueldo < maxSueldo)
                {
                    maxSueldo = e[i].Sueldo;
                }
            }
            int pos = 0;
            do
            {
                if (e[pos].Sueldo == maxSueldo)
                {
                    empleadoMayorSalario = e[pos];
                }
                pos++;
            } while (pos < e.GetUpperBound(0));
            return empleadoMayorSalario;
        }
    }
}
