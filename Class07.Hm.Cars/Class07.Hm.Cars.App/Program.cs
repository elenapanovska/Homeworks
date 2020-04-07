using System;
using Class07.Hm.Cars.Business.Models;
using Class07.Hm.Cars.Enumerations;

namespace Class07.Hm.Cars.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ElecticCar electicCar1 = new ElecticCar("Tesla", "Model-X", Consumption.Economic, 100, 20);
            ElecticCar electicCar2 = new ElecticCar("Tesla", "Model-S", Consumption.Medium, 100, 40);

            FuelCar fuelCar1 = new FuelCar("Maserati", "Levante", Consumption.Medium, 10, 6);
            FuelCar fuelCar2 = new FuelCar("Ferrai", "Levante", Consumption.High, 15, 8);

            Console.WriteLine(electicCar1.PrintInfo());
            Console.WriteLine(electicCar2.PrintInfo());
            electicCar1.Drive(45);
            electicCar2.Drive(1000);
            electicCar2.Recharge(2000);
            electicCar1.Recharge(1000);
            electicCar1.Recharge(500);

            Console.WriteLine(fuelCar1.PrintInfo());
            Console.WriteLine(fuelCar2.PrintInfo());
            fuelCar1.Drive(45);
            fuelCar1.Refuel(9);
            fuelCar1.Refuel(2);
            fuelCar2.Drive(10);
            fuelCar2.Refuel(11);

            Console.ReadLine();
        }
    }
}
