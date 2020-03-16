using System;

namespace Task04._05._06
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task04

            Console.WriteLine("Enter a number!");

            string evenInput = Console.ReadLine();
            if (!int.TryParse(evenInput, out int evenNumRange))
            {
                Console.WriteLine("Invalid input");
            };

            int sum = 0;
            for (int i = 1; i <= evenNumRange; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;

                }

            }
            Console.WriteLine($"The sum of all even numbers in the range of 1-{evenNumRange} is: {sum}");

            #endregion

            #region Task05

            Console.WriteLine("Enter a number!");

            string oddInput = Console.ReadLine();
            if (!int.TryParse(oddInput, out int oddNumRange))
            {
                Console.WriteLine("Invalid input");
            };

            int result = 0;
            for (int i = 1; i <= oddNumRange; i++)
            {
                if (i % 2 != 0)
                {
                    result += i;

                }

            }
            Console.WriteLine($"The sum of all odd numbers in the range of 1-{oddNumRange} is: {result}");

            #endregion

            #region Task06

            Console.WriteLine("Enter a number!");

            string devideInput = Console.ReadLine();
            if (!int.TryParse(devideInput, out int devideByFive))
            {
                Console.WriteLine("Invalid input");
            };

            int sum2 = 0;
            for (int i = 1; i <= devideByFive; i++)
            {
                if (i % 5 == 0)
                {
                    sum2 += i;

                }

            }
            Console.WriteLine($"The sum of all numbers that divide with 5 in the range 1-{devideByFive} is: {sum2}");

            #endregion

            Console.ReadLine();
        }
    }
}
