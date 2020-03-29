using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public static class Conversion
    {
        public static string ObtenerBinario(double numeroAConvertir)
        {
            int entero = (int)(numeroAConvertir);
            string cadena = "";
            if (entero > 0)
            {
                while (entero > 0)
                {
                    if (entero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    entero = (int)(entero / 2);
                }
            }
            else if (entero == 0)
            {
                cadena = "0";
            }
            return cadena;
        }

        public static string ObtenerOctal(double numeroAConvertir)
        {
            int entero = (int)(numeroAConvertir);
            string cadena = "";
            if (entero > 0)
            {
                while (entero > 0)
                {
                    int resto = entero % 8;
                    entero = entero / 8;
                    cadena = resto.ToString() + cadena;
                }
            }
            else if (entero == 0)
            {
                cadena = "0";
            }
            return cadena;
        }

        public static string ObtenerHexadecimal(double numeroAConvertir)
        {
            int entero = (int)(numeroAConvertir);
            string cadena = "";
            if (entero > 0)
            {
                while (entero > 0)
                {
                    int resto = entero % 16;
                    switch (resto)
                    {
                        case 10:
                            cadena = "A" + cadena;
                            break;
                        case 11:
                            cadena = "B" + cadena;
                            break;
                        case 12:
                            cadena = "C" + cadena;
                            break;
                        case 13:
                            cadena = "D" + cadena;
                            break;
                        case 14:
                            cadena = "E" + cadena;
                            break;
                        case 15:
                            cadena = "F" + cadena;
                            break;
                        default:
                            cadena = resto.ToString() + cadena;
                            break;
                    }
                    entero = entero / 16;
                }
            }else if (entero == 0)
            {
                cadena = "0";
            }
            return cadena;
        }
    }
}
