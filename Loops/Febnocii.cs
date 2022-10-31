using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Febnocii
    {
        public  Febnocii(int n)
        {
            int a = 0, b = 1, t=0 ;
            Console.Write("Febnocii Series upto n:    are.....:-  ");
            for (int i = 0; i <= n; i++)
            {
                t = a + b;
                a = b;
                b = t;
                Console.Write("\t"+t);
            }
        }
    }
}
