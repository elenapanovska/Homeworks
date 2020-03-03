using System;
using System.Threading;

namespace Homework_01_CS_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trafic light....\n");
            Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red light- STOP!\n");
            Thread.Sleep(2000);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow light - PREPARE.\n");
            Thread.Sleep(3000);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green light - GO!");
            Thread.Sleep(3000);



            Console.ReadLine();
        }
    }
}
