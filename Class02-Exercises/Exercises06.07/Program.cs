using System;

namespace Exercises06._07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exericse06
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

            #endregion

            #region Exericise07

            Console.WriteLine("Enter a number 1-3");

            int inputNum = 0;
            bool inputNumValid = int.TryParse(Console.ReadLine(), out inputNum);

            switch (inputNum)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("You entered a wrong number1");
                    break;
            }





            #endregion

            Console.ReadLine();
        }
    }
}
