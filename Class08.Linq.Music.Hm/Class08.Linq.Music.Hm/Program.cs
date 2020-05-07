using Class08.Linq.Music.Hm.Business.Models;
using Class08.Linq.Music.Hm.Business.Services;
using System;
using System.Collections.Generic;

namespace Class08.Linq.Music.Hm
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new Services();

            services.Jerry();
            Console.WriteLine("-----------------------------");

            services.Maria();
            Console.WriteLine("-----------------------------");

            services.Jane();
            Console.WriteLine("-----------------------------");

            services.Stefan();
            Console.WriteLine("-----------------------------");

            services.FansWith4orMoreSongs();

            Console.ReadLine();
        }
    }
}
