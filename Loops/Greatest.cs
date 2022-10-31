using System;
using System.Runtime;
using System.Transactions;

namespace Loops
{
    class Greatest
    {
        public Greatest()
        {
            try
            {
                Console.WriteLine("Enter the digt of numbers to input");
                int index = Convert.ToInt16(Console.ReadLine());
                int[] arr;
                arr = new int[index];
                Console.WriteLine("Enter values ::");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt16(Console.ReadLine());
                }
                for (int ji = 1; ji < arr.Length; ji++)
                {
                    if (arr[0] < arr[ji])
                    {
                        arr[0] = arr[ji];
                    }
                }
                Console.WriteLine("The Greatest value of among is: {0}", arr[0]);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
