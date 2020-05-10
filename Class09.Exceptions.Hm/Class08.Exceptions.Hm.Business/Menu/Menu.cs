using Class08.Exceptions.Hm.Business.Models;
using Class08.Exceptions.Hm.Business.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class08.Exceptions.Hm.Business.Menu
{
    public class Menu : Database
    {
        public void ChooseCinema()
        {
            try
            {
                Console.WriteLine("Choose a cinema: Cineplexx or Milenium?");
                string cinemaChoice = Console.ReadLine();
                var cinema = ListOfCinemas.FirstOrDefault(cinema => cinema.Name.ToLower() == cinemaChoice.ToLower());

                if(cinema == null)
                {
                    Exception custumEx = new Exception("There is no such cinema");
                    throw custumEx;

                }
                Console.WriteLine("Do you want to see all movies or only by genre? enter 1 or 2");
                string moviesOrGenre = Console.ReadLine();

                if(moviesOrGenre != "1" && moviesOrGenre != "2")
                {
                    Exception custumEx2 = new Exception("You enteret something wrong!");
                    throw custumEx2;
                }
                else
                {
                    switch (moviesOrGenre)
                    {
                        case "1":
                            PrintMovies(cinema);
                            break;
                        case "2":
                            SerchByGenre(cinema);
                            break;
                    }
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }

        public List<Movie> PrintMovies(Cinema cinema)
        {
            List<Movie> movieList = new List<Movie>();

            foreach (var movie in cinema.ListOfMovies)
            {
                Console.WriteLine(movie.Title);
                movieList.Add(movie);
            }

            return movieList;
        }

        public List<Movie> SerchByGenre(Cinema cinema)
        {
            List<Movie> movieList = new List<Movie>();
            try
            {
                Console.WriteLine("Choose genre");
                string genreChoice = Console.ReadLine();
                var genreList = cinema.ListOfMovies
                                .Where(genre => genre.Genre.ToString().ToLower() == genreChoice.ToLower())
                                .ToList();

                if (genreList.Count == 0)
                {
                    Exception customEx = new Exception("There are no movies with that genre");
                    throw customEx;
                }
                else
                {
                    foreach (var movie in genreList)
                    {
                        Console.WriteLine(movie.Title);
                        movieList.Add(movie);
                    }
                    ChooseAMovie(cinema);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return movieList;
        }

        public Movie ChooseAMovie(Cinema cinema)
        {
            Console.WriteLine("Choose a movie");
            string movieChoice = Console.ReadLine();

            var movie = cinema.ListOfMovies.FirstOrDefault(movie => movie.Title.ToLower() == movieChoice.ToLower());

            cinema.MoviePlaying(movie);

            return movie;
        }

       
    }

    
} 

