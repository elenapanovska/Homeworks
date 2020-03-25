using System;

namespace Task0._01._02
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 0

            //Console.WriteLine("Enter a number!");
            //Substrings();

            #endregion

            #region Task01

            //PalidromeCheck();
            #endregion

            #region Task 02

            int[] arr = {3,4,5,7,8,1,6};
            MaxValueOfArr(arr);

            #endregion


            Console.ReadLine();

        }

        #region Task 0 method
        public static void Substrings()
        {
            string helloMessage = "Hello from SEDC Codecademy v7.0";
            int num;
            int.TryParse(Console.ReadLine(), out num);
           
            if(num > helloMessage.Length)
            {
                Console.WriteLine($"Cannot enter a number larger than {helloMessage.Length}");
            }
            else
            {
                string subst = helloMessage.Substring(0, num);
                Console.WriteLine(subst);
                Console.WriteLine(subst.Length);
            }
        }

        #endregion

        #region Task01 method 

        public static void PalidromeCheck()
        {
            Console.WriteLine("Enter a string!");
            string str = Console.ReadLine().ToLower();
            char[] strCharArr = str.ToCharArray();

            char[] reversedArr = str.ToCharArray();
            Array.Reverse(reversedArr);

            for( int i = 0; i < strCharArr.Length; i++)
            {
                if(strCharArr[i] == reversedArr[i])
                {
                    Console.WriteLine($"The string {str} is a paldrome");
                    break;
                }
                else
                {
                    Console.WriteLine($"The string {str} is not  a paldrome");
                    break;
                }
            }


            

        }

        #endregion

        #region Task 02 method 

        public static int MaxValueOfArr(int[] arrayOfNum)
        {
            int max;
            max = arrayOfNum[0];

            for(int i = 1; i < arrayOfNum.Length; i++)
            {
               if(arrayOfNum[i] > max)
               {
                 max = arrayOfNum[i];
               }
            }
            Console.WriteLine($"The greatest value in the array is {max}");
            return max;
            
        }

        #endregion
    }
}
