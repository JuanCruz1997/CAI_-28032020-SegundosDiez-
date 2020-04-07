using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Empleados
    {
        string nombre = "";
        double sueldo = 0;
        public Empleados(string nombre, double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }
        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }
        public double Sueldo
        {
            set
            {
                this.sueldo = value;
            }
            get
            {
                return this.sueldo;
            }
        }
    }
}
