using Class07.Hm.Cars.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Hm.Cars.Business.Models
{
    public class ElecticCar : Car
    {
        public int BateryCapacity { get; set; }
        public int BateryUsage { get; set; }


        public ElecticCar(string brand, string model, Consumption consumation, int bateryCapasity, int bateryUsage) : base( brand, model, consumation)
        {
            EngineType = EngineType.Electic;
            BateryCapacity = bateryCapasity;
            BateryUsage = bateryUsage;
        }
        public void Drive(int distance)
        {
           int bateryUsage = (distance *  (int)Consumation) / 10;
           if(bateryUsage > BateryCapacity)
           {
                Console.WriteLine("You can't drive anymore!");
            }
            else
            {
                int leftBatery = BateryCapacity - bateryUsage;
                if(leftBatery == 0)
                {
                    Console.WriteLine("You need to recharge you car!");
                }
                else
                {
                    Console.WriteLine($"You can drive your batery is at {leftBatery}%");
                }
                
            }
            
        }

        public void Recharge(int minuites)
        {
            if(minuites > 1000)
            {
                Console.WriteLine($"Can't charge longer than 1000 minuites");
            }else if(minuites == 1000)
            {
                Console.WriteLine("Batery fully charged");
            }else if(minuites < 1000)
            {
                Console.WriteLine("Your batery isn't fully charged");
            }
        }
    }
}
