using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programaweb.Clases
{
    class Mult
    {
        public int multiplicacion(int a, int b)
        {
            int temporal;
            if (b == 1)
                return (a);
            else
            {
                temporal = a * b;
                return (temporal);
            }
        }
    }
}
