using System;

namespace Bonus_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number!");
            Console.WriteLine("Choose a difficulty level: Easy, Normal, Hard");

            string level = Console.ReadLine();

            Random ran = new Random();

            if (level == "easy")
            {
                int easyNum = ran.Next(0, 100);

                for(int i = 1; i <= 9; i++)
                {
                    string easyInp = Console.ReadLine();
                    if (!int.TryParse(easyInp, out int parsedEasyNum))
                    {
                        Console.WriteLine("Invaid input");
                    };

                    if(i == 1 && easyNum == parsedEasyNum)
                    {
                        Console.WriteLine("Lucky guess!");
                    }

                    if (easyNum == parsedEasyNum )
                    {
                        Console.WriteLine($"Nailed it! Number entered: {parsedEasyNum}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
               
            };


        }
    }
}
