using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers!");

            int num1;
            int num2;
            int swapNum;

            bool num1Valid = int.TryParse(Console.ReadLine(), out num1);
            bool num2Valid = int.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("First number:" + num1);
            Console.WriteLine("Second number:" + num2);

            Console.WriteLine("After swaping");

            swapNum = num1;
            num1 = num2;
            num2 = swapNum;

            Console.WriteLine("First number:" + num1);
            Console.WriteLine("Second number:" + num2);



            Console.ReadLine();

        }
    }
}
