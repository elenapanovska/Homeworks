using System;

namespace Task._06._07._08
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Task 06

            //Console.WriteLine("Enter a string and the substring you want to count");
            //string sentence = Console.ReadLine();
            //string pattern  = Console.ReadLine();

            //NumOfSunstrig(sentence, pattern);

            #endregion

            #region Task 07

            Console.WriteLine("Enter two numbers to find the result of raising an integer to another integer");

            int num1;
            int.TryParse(Console.ReadLine(), out num1);

            int num2;
            int.TryParse(Console.ReadLine(), out num2);


            CalculateRaising(num1, num2);

            #endregion

            Console.ReadLine();
        }

        #region Task 06 method

        public static void NumOfSunstrig(string sentence, string pattern)
        {
            int i = 0;
            int counter = 0;

            while((i = sentence.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                counter++;

            }
            Console.WriteLine($"The number of times a substring appears in the string is: {counter}");
        }


        #endregion

        #region Task 07 method 

        public static void CalculateRaising(int num1, int num2)
        {
            int result = 1;
            for(int i = 1; i <= num2; i++)
            {
                result = result * num1;
            }
            Console.WriteLine($"The result is {result}");

        }
        #endregion

    }
}
