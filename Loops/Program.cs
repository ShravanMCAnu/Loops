using Loops;
using System;
using System.Collections;

namespace Loops
{
    class Loops
    {
        public static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("The operations \n\n1. Febnocii  2. Prime Number  3. Factorial  4. Even OR Odd  5. Sum of Numbers  6. Greatest of Given Numbers  7.Palindrome\nEnter your choice:");
                int choice = Convert.ToInt16(Console.ReadLine());
                int choiceinto = choice;
                switch (choiceinto)
                {
                    case 1:
                        Console.WriteLine("Enter a value to see the febnocii of upto:");
                        int fe = Convert.ToInt16(Console.ReadLine());
                        Febnocii Fe = new(fe);
                        break;
                    case 2:
                        Console.WriteLine("Enter a value to see the Prime or Not:");
                        int pi = Convert.ToInt16(Console.ReadLine());
                        Prime_Number Prime = new(pi);
                        break;
                    case 3:
                        Factorial fac = new Factorial();
                        Console.WriteLine("Enter a value to see the Factorial of:");
                        int fi = Convert.ToInt16(Console.ReadLine());
                        int fact_result = fac.FactorialMethod(fi);
                        Console.WriteLine("factorial of a given Number is " + fact_result);
                        break;
                    case 4:
                        Console.WriteLine("Enter Any value to see the number is Even or Odd");
                        int oe = Convert.ToInt16(Console.ReadLine());
                        EvenOdd EO = new(oe);
                        break;
                    case 5:
                        Console.WriteLine("Enter Any value to see the sum of NUmbers of that");
                        int sn = Convert.ToInt16(Console.ReadLine());
                        SumOfNumbers SN = new(sn);
                        break;
                    case 6:
                        Greatest greatest = new Greatest();
                        break;
                    case 7:
                        Console.WriteLine("Enter any number to know is palindrone or not");
                        int num = Convert.ToInt32(Console.ReadLine());
                        palindrone pal = new palindrone();
                        pal.palindrone1(num);
                        break;


                }
            }
            catch (Exception Exe)
            {
                Console.WriteLine(Exe.Message);
            }

        }
    }
}