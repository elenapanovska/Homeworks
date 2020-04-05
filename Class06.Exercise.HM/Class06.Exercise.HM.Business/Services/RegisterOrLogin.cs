using Class06.Exercise.HM.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.Exercise.HM.Business.Services
{
    public class RegisterOrLogin
    {
        public void RegisterUser(List<User> registeredUsers)
        {
            Console.WriteLine("To register please enter: Email, password, first name, last name and date of birth");

            string email = Console.ReadLine();
            string password = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            User user1 = new User(email, password, firstName, lastName, dateOfBirth);

            registeredUsers.Add(user1);
            
        }
    }
}
