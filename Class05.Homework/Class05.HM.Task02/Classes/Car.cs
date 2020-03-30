using System;
using System.Collections.Generic;
using System.Text;

namespace Class05.HM.Task02.Classes
{
    public class Car
    {
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public Car()
        {

        }
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }
        public int CalculateSpeed(Driver driver)
        {
            int carSpeed = driver.Skill * Speed;
            return carSpeed;
        }
    }
}
