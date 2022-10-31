using System;
namespace Loops
{
    class EvenOdd
    {
        public EvenOdd(int eo=0)
        {
            if (eo % 2 == 0)
            {
                Console.WriteLine(" The Entered value {0} is EVEN",eo);
            }
            else if(eo%2 != 0)
            {
                Console.WriteLine("The Entered Value {0} is ODD", eo);
            }
        }
    }
}
