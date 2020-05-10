using System;
using System.Collections.Generic;
using System.Text;

namespace Class08.Exceptions.Hm.Business.Models.Data
{
    public class Database
    {
        protected List<Cinema> ListOfCinemas;
        public Database()
        {
            AddMovies();
        }

        public List<Cinema> AddMovies()
        {
            ListOfCinemas = new List<Cinema>();

            Movie movie1 = new Movie("Home alone", Genre.Comedy, 5);
            Movie movie2 = new Movie("Missinon Imposible", Genre.Action, 4);
            Movie movie3 = new Movie("It", Genre.Horror, 3);
            Movie movie4 = new Movie("Joker", Genre.Drama, 5);
            Movie movie5 = new Movie("Avatar", Genre.SciFi, 5);
            Movie movie6 = new Movie("StarWars", Genre.SciFi, 5);
            Movie movie7 = new Movie("Dump and dumper", Genre.Comedy, 4);
            Movie movie8 = new Movie("Bad boys", Genre.Action, 2);
            Movie movie9 = new Movie("The conjuring", Genre.Horror, 1);
            Movie movie10 = new Movie("Little women", Genre.Drama, 3);

            Cinema cinema1 = new Cinema("Cineplexx", 3);
            Cinema cinema2 = new Cinema("Milenium", 2);

            cinema1.ListOfMovies = new List<Movie>();

            cinema1.ListOfMovies.Add(movie1);
            cinema1.ListOfMovies.Add(movie3);
            cinema1.ListOfMovies.Add(movie5);
            cinema1.ListOfMovies.Add(movie4);
            cinema1.ListOfMovies.Add(movie9);

            cinema2.ListOfMovies = new List<Movie>();

            cinema2.ListOfMovies.Add(movie2);
            cinema2.ListOfMovies.Add(movie10);
            cinema2.ListOfMovies.Add(movie7);
            cinema2.ListOfMovies.Add(movie8);
            cinema2.ListOfMovies.Add(movie6);

            ListOfCinemas = new List<Cinema>() { cinema1, cinema2 };

            return ListOfCinemas;
        }


    }
}
