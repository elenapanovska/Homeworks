using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.ReadLine();
        }
    }
}
