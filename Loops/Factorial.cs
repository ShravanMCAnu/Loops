using System;

namespace Loops
{
    class Factorial
    {
       
        public int FactorialMethod(int f)
        {
            try
            {
                return f == 0 ? 1 : f * FactorialMethod(f - 1);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
