using System;
namespace Loops
{
    class palindrone
    {
        int reverse = 0, remainder, num, temp;

        
        public void palindrone1(int temp)
        {
            num = temp;
            while (temp != 0)
            {
                remainder = temp % 10;
                reverse = reverse * 10 + remainder;
                temp = temp / 10;
            }
            Console.WriteLine("The reverse Number :{0}", reverse);
            if (num == reverse)
            {
                Console.WriteLine(num + " is Palindrome");
            }
            else
            {
                Console.WriteLine(num + " is not Palindrome");
            }
        }
    }
}
