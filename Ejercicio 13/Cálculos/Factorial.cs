using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculos
{
    public class Factorial
    {
        public int CalcularFactorial(int numero)
        {
            int resultado = 1;
            for(int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
