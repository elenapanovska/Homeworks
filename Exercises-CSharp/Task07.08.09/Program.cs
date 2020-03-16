using System;

namespace Task07._08._09
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task07

            //char[] alphabetArr = new char[] { 'a', 'b', 'c', 'd' };

            //Console.WriteLine("Array before resversing:");
            //foreach (char letter in alphabetArr)
            //{
            //    Console.WriteLine(letter);

            //};

            //Array.Reverse(alphabetArr);

            //Console.WriteLine("Array after resversing:");
            //foreach (char letter in alphabetArr)
            //{

            //    Console.WriteLine(letter);

            //};
            #endregion

            #region Task08
            //Console.WriteLine("Enter the size of the array");
            //string sizeOfArr = Console.ReadLine();
            //if (!int.TryParse(sizeOfArr, out int size))
            //{
            //    Console.WriteLine("Invalid input!");
            //}

            //Console.WriteLine("Enter the elements in the array");
            //int[] compareArr1 = new int[size];



            //for (int i = 0; i < compareArr1.Length; i++)
            //{
            //    string elmentsArr1 = Console.ReadLine();
            //    if (!int.TryParse(elmentsArr1, out int parsedElement))
            //    {
            //        Console.WriteLine("Invalid input!");
            //    }

            //    compareArr1[i] = parsedElement;

            //}


            //Console.WriteLine("Enter the size of the second  array");
            //string sizeSecondArr = Console.ReadLine();
            //if (!int.TryParse(sizeSecondArr, out int size2))
            //{
            //    Console.WriteLine("Invalid input!");
            //}

            //Console.WriteLine("Enter the elements in the array");
            //int[] compareArr2 = new int[size2];


            //for (int i = 0; i < compareArr2.Length; i++)
            //{
            //    string elmentsArr2 = Console.ReadLine();
            //    if (!int.TryParse(elmentsArr2, out int parsedElement2))
            //    {
            //        Console.WriteLine("Invalid input!");
            //    }

            //    compareArr2[i] = parsedElement2;

            //}

            //for(int i = 0; i < compareArr1.Length; i++)
            //{

            //    if(compareArr1[i] == compareArr2[i])
            //    {
            //        Console.WriteLine("The arrays are equal");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("The arrays are not equal");
            //        break;
            //    }
            //}



            #endregion

            #region Task09
            Console.WriteLine("Numbers 1-1000 that divide the sum composed of their digits.");

            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;
                int number = i;
               
               while(number != 0)
               {
                    int digits = number % 10;
                    sum = sum + digits;
                    number = number / 10;
               }
                
                if (i % sum == 0)
                {
                    Console.WriteLine(i);

                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}
