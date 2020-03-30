using System;

namespace BonusTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth date ");

            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            AgeCalculator(birthDate);

            Console.ReadLine();
        }

        public static int AgeCalculator(DateTime birthdayDate)
        {
            int age = DateTime.Today.Year - birthdayDate.Year;

            if ((birthdayDate.Month > DateTime.Now.Month) || (birthdayDate.Month == DateTime.Now.Month && birthdayDate.Day > DateTime.Now.Day))
            {
                age--;
            }

            Console.WriteLine(age);
            return age;
        }
    }

}
