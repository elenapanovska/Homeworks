using System;

namespace Task10._11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 10
            Console.WriteLine("Numbers 1-1000 that divide the product composed of their digits.");

            for (int i = 1; i <= 1000; i++)
            {
                int product = 1;
                int number = i;

                while (number != 0)
                {
                    int digits = number % 10;
                    product = product * digits;
                    number = number / 10;
                }

                if (product == 0)
                {
                    continue;
                }

                if (i % product == 0)
                {
                    Console.WriteLine(i);

                }
            }
            #endregion

            #region Task 11

            for (int i = 10; i < 100; i++)
            {
                int number = i;
                int num2 = number % 10;
                int num1 = (number / 10) % 10;

                if (num1 > num2)
                {
                    Console.WriteLine(i);
                }

            }

            #endregion

            Console.ReadLine();
        }
    }
}
