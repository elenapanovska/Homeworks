using System;
using System.Collections.Generic;
using System.Text;

namespace Class05.HM.Task01.Classes
{
   public class Dog
   {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public string Eat()
        {
            Console.WriteLine($"The dog {Name} is eating");
            return "The dog is eating";
        }

        public string Play()
        {
            Console.WriteLine($"The dog {Name} is now playing");
            return "The dog is now playing";
        }

        public string ChaseTaill()
        {
            Console.WriteLine($"The dog {Name} is now chasing its tail.");
            return "Dog is now chasing its tail.";
        }
    }
}
