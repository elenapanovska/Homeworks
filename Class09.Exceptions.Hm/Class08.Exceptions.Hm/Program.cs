using Class08.Exceptions.Hm.Business.Menu;
using Class08.Exceptions.Hm.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Class08.Exceptions.Hm
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();

            menu.ChooseCinema();

            Console.ReadLine();
        }

        
    }
}
