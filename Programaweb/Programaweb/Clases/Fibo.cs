using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programaweb.Clases
{
    class Fibo
    {
        public int Fibonacci(int a)
        {
            int resultado;
            if ((a == 0) || (a == 1))
            {
                return a;
            }
            else
            {

                resultado = Fibonacci(a - 2) + Fibonacci(a - 1);
                return resultado;
            }
        }
    }
}
