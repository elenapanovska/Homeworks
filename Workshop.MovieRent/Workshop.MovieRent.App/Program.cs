using System;
using Workshop.MovieRent.App.Menus;
using Workshop.MovieRent.Business.Helpers;
using Workshop.MovieRent.Business.Services;
using Workshop.MovieRent.Data.Models;

namespace Workshop.MovieRent.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var _userService = new UserService();
            User user;

            Screen.HomeScreen();

            bool isLoggedIn = false;
            while (!isLoggedIn)
            {
                Screen.StartMenu();
                var startMenuInput = InputParser.ToInteger(1,3);
                switch (startMenuInput)
                {
                    case 1:
                        while (!isLoggedIn)
                        {
                            user = _userService.LogIn();
                            isLoggedIn = !isLoggedIn;
                        }
                        break;
                    case 2:
                        while (!isLoggedIn)
                        {
                            user = _userService.SignUp();
                            isLoggedIn = !isLoggedIn;
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
