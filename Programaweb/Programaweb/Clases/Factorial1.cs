using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programaweb.Clases
{
    class Factorial1
    {
        public int Factorial(int a)
        {
            {
                int x, y;
                if (a == 0)
                    return (1);
                else
                {
                    x = a - 1;
                    y = Factorial(x);
                    return (a * y);
                }
            }
        }
    }
}
