using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers!");

            int num1;
            int num2;
           
            bool isValidnum1 = int.TryParse(Console.ReadLine(), out num1);
            bool isValidnum2 = int.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("Please enter operator!");

            string operation = Console.ReadLine();
            int result;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("The result is:" + result );
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("The result is:" + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("The result is:" + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine("The result is:" + result);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }


            Console.ReadLine();
        }
    }
}
