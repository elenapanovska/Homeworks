using Class06.Exercise.HM.Business.Models;
using Class06.Exercise.HM.Business.Services;
using System;
using System.Collections.Generic;

namespace Class06.Exercise.HM.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var registerOrLogin = new RegisterOrLogin();
            var valdate = new ValidationService();

            User[] users = InitializeUsers();

            Console.WriteLine("to log in enter 1, to register enter 2!");
            string choose = Console.ReadLine();

            if(choose == "1")
            {
               Console.WriteLine("Enter your email and password to log in.");
               string username = Console.ReadLine();
               string password = Console.ReadLine();

               registerOrLogin.LoginUser(username, password, users);
            }else if(choose == "2")
            {
                registerOrLogin.RegisterUser(users);
            }

            Console.ReadLine();
        }
        public static User[] InitializeUsers()
        {
            User[] users = new User[]
            {
                new User("bob.bobsky@gmail.com", "Bobsky1234", "Bob", "Bobsky", new DateTime(1999,3,12)),
                new User("anne_marie@hotmail.com", "Marie1221", "Anne", "Marie", new DateTime(2000,5,16)),
            };
            return users;
        }
    }

   
}
