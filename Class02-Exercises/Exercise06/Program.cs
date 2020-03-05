using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers!");

            int number1 = 0;
            int number2 = 0;

            bool num1 = int.TryParse(Console.ReadLine(), out number1);
            bool num2 = int.TryParse(Console.ReadLine(), out number2);


            if (number1 > number2)
            {
                Console.WriteLine(number1 + "is larger");
            }
            else
            {
                Console.WriteLine(number2 + "is larger");
            }

            if (number1 % 2 == 0)
            {
                Console.WriteLine(number1 + "is even");
            }
            else
            {
                Console.WriteLine(number1 + "is odd");
            }

            if (number2 % 2 == 0)
            {
                Console.WriteLine(number2 + "is even");
            }
            else
            {
                Console.WriteLine(number2 + "is odd");
            }


            Console.ReadLine();
        }
    }
}
