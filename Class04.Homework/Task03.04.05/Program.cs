using System;

namespace Task03._04._05
{
    class Program
    {
        public delegate void amountOfNum(string text);
        public delegate void numberOfVowels(string text);
        static void Main(string[] args)
        {

            #region Task03 

            //Console.WriteLine("Enter a string");
            //string someStr = Console.ReadLine();


            //amountOfNum numbers = delegate(string text)
            //{
            //    int digits = 0;
            //    foreach (char n in text)
            //    {
            //        if (Char.IsDigit(n))
            //        {
            //            digits++;
            //        }

            //    }
            //    Console.WriteLine($"The number of digits in {someStr} is: {digits}");
            //};
            //numbers(someStr);

            //numberOfVowels vowels = delegate (string text)
            //{               
            //    int numOfvowels = 0;

            //    foreach(char ch in text)
            //    {
            //        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //        {
            //            numOfvowels++;
            //        }

            //    }
            //    Console.WriteLine($"The number of vowels in {text} is: {numOfvowels}");
            //};

            //vowels(someStr.ToLower());

            #endregion

            #region Task 04

            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();

            LowerCUpperC(sentence);

            #endregion

            #region Task 05
            AlphabetOrNot();
            #endregion
            Console.ReadLine();

        }

        #region Task 04 method

        public static void LowerCUpperC(string sentence)
        {
            
            char[] charArr = sentence.ToCharArray();
            string result = "";

            for (int i = 0; i < charArr.Length; i++)
            {
                char letter = charArr[i];

                if (Char.IsUpper(letter))
                {
                    result += char.ToLower(letter);
                }
                if (Char.IsLower(letter) == true)
                {
                    result += char.ToUpper(letter);
                }
            }


            Console.WriteLine(result);
        }

        #endregion

        #region Task05 method

        public static void AlphabetOrNot()
        {
            Console.WriteLine("Enter a character");
            char inputChar;
            char.TryParse(Console.ReadLine(), out inputChar);

            if (Char.IsLetter(inputChar))
            {
                Console.WriteLine($"The character {inputChar} is an alphabet");
            }
            else if (Char.IsNumber(inputChar))
            {
                Console.WriteLine($"The character {inputChar} is a digit");
            }
            else if (Char.IsSymbol(inputChar))
            {
                Console.WriteLine($"The characer {inputChar} is a symbol");
            }
        }

        #endregion

    }
}
