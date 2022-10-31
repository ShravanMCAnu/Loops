using System;
namespace Loops
{
    class SumOfNumbers
    {
        public SumOfNumbers(int numb)
        {
            int sum=0;
            for (int i = 1; i <= numb; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of {0} is :- {1}",numb,sum);
        }
    }
}
