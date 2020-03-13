using System;

namespace Tasks01._02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            Console.WriteLine("Enter a number bigger than 2!");

            string inputNum = Console.ReadLine();
            if (!int.TryParse(inputNum, out int numRange) || numRange < 2)
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine($"Numbers in the range of 1-{numRange} that devide with 3 are:");
            for (int i = 1; i <= numRange; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

            #region Task02

            Console.WriteLine("Enter a number bigger than 5!");

            string inputNum2 = Console.ReadLine();
            if (!int.TryParse(inputNum2, out int numRange2) || numRange2 < 5)
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine($"Numbers in the range of 1-{numRange2} that devide with 2 and 3 are:");
            for (int i = 1; i <= numRange2; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            #endregion

            #region Task03
            Console.WriteLine("Enter a number!");

            string n = Console.ReadLine();
            if (!int.TryParse(n, out int calculateNum) || n.Length < 2)
            {
                Console.WriteLine("Invalid input");
            }

            int product = 1;
            while(calculateNum != 0)
            {
                int digits = calculateNum % 10;
                calculateNum /= 10;
                product *= digits;

            }

            Console.WriteLine($" The product of the number is: {product}");


            #endregion
            Console.ReadLine();
        }
    }
}
