using System;

namespace StudnetGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[] { "Tomce", "Marko", "Darko", "Mine", "Sara" };


            string userInt = Console.ReadLine();
            if (!int.TryParse(userInt, out int groupNum))
            {
                Console.WriteLine("Invalid input");
            };

            if(groupNum == 1)
            {
                Console.WriteLine("The studnets in G1 are:");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            } else
            {
                Console.WriteLine("The studnets in G2 are:");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            };

            Console.ReadLine();

        }
    }
}
