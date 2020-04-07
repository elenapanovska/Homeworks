using Class07.Hm.Cars.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class07.Hm.Cars.Business.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumation { get; set; }
        public EngineType EngineType { get; set; }

        public Car(string brand, string model, Consumption consumation)
        {
            Id = GenerateId();
            Brand = brand;
            Model = model;
            Consumation = consumation;
           
        }

        public string PrintInfo()
        {
            return $"Id: {Id}, Brand: {Brand}, Model: {Model}, Consumation: {Consumation}, Engine type: {EngineType}";
        }

        public int GenerateId()
        {
            Random rand = new Random();
            return rand.Next(0, 10_000_000);
        }
    }
}
