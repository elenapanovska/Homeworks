using System;
using System.Collections.Generic;
using System.Text;

namespace Class08.Exceptions.Hm.Business.Models
{
    public class Cinema
    {
        public  string Name { get; set; }
        public int Halls { get; set; }
        public  List<Movie> ListOfMovies { get; set; }


        public Cinema(string name, int halls)
        {
            Name = name;
            Halls = halls;
        }

        public Cinema()
        {

        }
        public void MoviePlaying(Movie movie) 
        {
            Console.WriteLine($"Watching movie:{movie.Title}");
        }

    }
}
