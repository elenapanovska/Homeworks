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

            var registerUser = new RegisterOrLogin();
            List<User> registeredUsers = new List<User>();
           

            registerUser.RegisterUser(registeredUsers);

            foreach(User user in registeredUsers)
            {
                Console.WriteLine($"{user.GetFullName()}");
                Console.WriteLine(registeredUsers.Count);
            }

            Console.ReadLine();
        }
    }
}
