using Class05.HM.Task02.Classes;
using System;
using System.Collections.Generic;

namespace Class05.HM.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driverN_1 = new Driver("Bob", 2);
            Driver driverN_2 = new Driver("Greg", 5);
            Driver driverN_3 = new Driver("Jill", 8);
            Driver driverN_4 = new Driver("Anne", 7);

            Car carN_1 = new Car("Hyundai", 160);
            Car carN_2 = new Car("Mazda", 200);
            Car carN_3 = new Car("Ferrari", 300);
            Car carN_4 = new Car("Porsche", 320);

            Car[] carsArr = new Car[4] { carN_1, carN_2, carN_3, carN_4 };
            Driver[] driversArr = new Driver[] { driverN_1, driverN_2, driverN_3, driverN_4 };

            bool again = false;
            do
            {
                again = false;
                Console.WriteLine("Choose car n.1");
                foreach (Car car in carsArr)
                {
                    Console.WriteLine(car.Model);
                }
                string carNum1 = Console.ReadLine();

                Console.WriteLine("Choose driver n.1");
                foreach (Driver driver in driversArr)
                {
                    Console.WriteLine(driver.Name);
                }
                string driverNum1 = Console.ReadLine();

                Console.WriteLine("Choose car n.2");
                string carNum2 = Console.ReadLine();

                Console.WriteLine("Choose driver n.2");
                string driverNum2 = Console.ReadLine();

                Race(carNum1, carNum2, carsArr, driverNum1, driverNum2, driversArr);

                Console.WriteLine("Do you want to race again? Yes/No");
                string raceAgain = Console.ReadLine();
                again = (raceAgain.ToLower() == "yes");
            } while (again);


            Console.ReadLine();
        }

        public static void Race(string carModelInp1, string carModelInp2, Car[] carsArr, string driverNum1, string driverNum2, Driver[] driversArr)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Driver driver1 = new Driver();
            Driver driver2 = new Driver();

            for (int i = 0; i < carsArr.Length; i++)
            {
                if (carModelInp1.ToLower() == carsArr[i].Model.ToLower())
                {
                    car1 = carsArr[i];
                }
                else if (carModelInp2.ToLower() == carsArr[i].Model.ToLower())
                {
                    car2 = carsArr[i];
                }
            }

            foreach (Driver driver in driversArr)
            {
                if (driverNum1.ToLower() == driver.Name.ToLower())
                {
                    driver1 = driver;
                }
                else if (driverNum2.ToLower() == driver.Name.ToLower())
                {
                    driver2 = driver;
                }
            }

            if (car1.CalculateSpeed(driver1) > car2.CalculateSpeed(driver2))
            {
                Console.WriteLine($"The car {car1.Model} won the race with speed of {car1.CalculateSpeed(driver1)}mph driven by: {driver1.Name}");
            }
            else
            {
                Console.WriteLine($"The car {car2.Model} won the race with speed of {car2.CalculateSpeed(driver2)}mph driven by: {driver2.Name}");
            }
        }
    }
}
