using Class06.Exercise.HM.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.Exercise.HM.Business.Services
{
    public class RegisterOrLogin
    {
        public void RegisterUser(User[] users)
        {
            Console.WriteLine("To register please enter: Email, password, first name, last name and date of birth");

            string email = Console.ReadLine();
            string password = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            User user1 = new User(email, password, firstName, lastName, dateOfBirth);

            foreach(User user in users)
            {
                if (user1.Email != user.Email)
                {
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = user1;
                }
                else
                {
                    Console.WriteLine("That email is alredy in use!");
                    return;
                }
                Console.WriteLine(user1.GetFullName());
                Console.WriteLine(user.GetFullName());
            }
        }

        public void LoginUser(string email, string password, User[] users)
        {
            var validation = new ValidationService();

            if (validation.ValidateEmail(email) && validation.ValidatePassword(password))
            {
                foreach (User user in users)
                {
                    if (email == user.Email && password == user.Password)
                    {
                        Console.WriteLine("You succesfully loged in!");
                    }
                    Console.WriteLine(user.GetFullName());
                }
            }
            else
            {
                Console.WriteLine("You typed your email or password incorectly");
            }
        }
    }
}
