using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Validaciones
    {
        public static string ValidarString(string palabra)
        {
            int comprobacion = 0;
            if(int.TryParse(palabra,out comprobacion))
            {
                return "";
            }
            else
            {
                return palabra;
            }
        }
        public static double ValidarDouble(string numero)
        {
            double comprobacion = 0;
            if(!double.TryParse(numero,out comprobacion))
            {
                return -1;
            }
            else
            {
                return comprobacion;
            }
        }
    }
}
