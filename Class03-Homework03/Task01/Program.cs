using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] sumEvenNum = new int[6];
            int result = 0;
            Console.WriteLine("Enter 6 numbers");
            for (int i = 0; i < sumEvenNum.Length; i++)
            {
                string inputNum = Console.ReadLine();
                if (!int.TryParse(inputNum, out int parsedNum))
                {
                    Console.WriteLine("Invalid number");

                };

                sumEvenNum[i] = parsedNum;

                if (sumEvenNum[i] % 2 == 0)
                {
                    result = result + sumEvenNum[i];
                };
                

            };

            Console.WriteLine($"The result is: {result}");



            Console.ReadLine();

        }
    }
}
