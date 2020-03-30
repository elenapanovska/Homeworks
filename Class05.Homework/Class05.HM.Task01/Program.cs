using Class05.HM.Task01.Classes;
using System;

namespace Class05.HM.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dogs's name, race and color");

            Dog dog1 = new Dog()
            {
                Name = Console.ReadLine(),
                Race = Console.ReadLine(),
                Color = Console.ReadLine()

            };

            Console.WriteLine("Choose an anction: Eat, Play, ChaseTail");
            string dogAction = Console.ReadLine();

            ActionChoice(dogAction, dog1);

            Console.ReadLine();
        }

        public static void ActionChoice(string dogAction, Dog dog)
        {
            if (dogAction.ToLower() == "eat")
            {
                dog.Eat();
            } else if(dogAction.ToLower() == "play")
            {
                dog.Play();
            }
            else
            {
                dog.ChaseTaill();
            }
        }

    }
}
