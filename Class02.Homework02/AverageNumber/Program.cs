using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four numbers!");

            int num1;
            int num2;
            int num3;
            int num4;

            bool isValNum1 = int.TryParse(Console.ReadLine(), out num1);
            bool isValNum2 = int.TryParse(Console.ReadLine(), out num2);
            bool isValNum3 = int.TryParse(Console.ReadLine(), out num3);
            bool isValNum4 = int.TryParse(Console.ReadLine(), out num4);

            int result = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of" + " " + num1 +  " " + num2 + " " + num3 + " " + num4 + " " + "is:" + " " + result);

            Console.ReadLine();
        }
    }
}
