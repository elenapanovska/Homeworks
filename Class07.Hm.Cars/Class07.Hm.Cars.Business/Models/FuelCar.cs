using Class07.Hm.Cars.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Hm.Cars.Business.Models
{
    public class FuelCar : Car
    {
        public int FuelCapasity { get; set; }
        public int CurrentFuel { get; set; }

        public FuelCar(string brand, string model, Consumption consumation, int fuelCapasity, int currentFuel) : base(brand, model, consumation)
        {
            EngineType = EngineType.Petrol;
            FuelCapasity = fuelCapasity;
            CurrentFuel = currentFuel;
        }

        public void Drive(int distance)
        {
            int fuelUsage = (distance * (int)Consumation) / 10;

            if(fuelUsage > CurrentFuel)
            {
                Console.WriteLine($"You can not drive {distance}km, you don't have that much fuel!");
            }
        }

        public int Refuel(int fuel)
        {
            if (CurrentFuel + fuel > FuelCapasity)
            {
                Console.WriteLine($"Can't refuel more than {FuelCapasity} litres");
            }
            else
            {
                CurrentFuel = CurrentFuel + fuel;
                Console.WriteLine($"Your tank now has {CurrentFuel} liters ");
            }
            return CurrentFuel;
        }
        
       
    }
}
