using System;
namespace Loops
{
    class Prime_Number
    {
        public int iterator;
        bool prime = true;
        public Prime_Number(int number)
        {
            if (number < 2)
            {
                prime= false;
            }
            else
            {
                for (int j = 1; j <= number; j++)
                {
                    if (number % j == 0)
                    {
                        prime=false;
                        break;
                    }
                }
            }
            string retrn_value = prime ? "Prime" : "Not prime";
            Console.WriteLine("TheNumber {0}is {1} :",number,retrn_value);
        }
    }
}
