using SEDC.VideoRental.Data.Database;
using SEDC.VideoRental.Data.Enums;
using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.VideoRental.Services.Services
{
    public class MovieService
    {
        private MovieRepository _movieService;

        public MovieService()
        {
            _movieService = new MovieRepository();
        }

        public List<Movie> OrderByGenre()
        {
            var orderedMoviesByGenre = _movieService.OrderByGenre();

            return orderedMoviesByGenre;
        }

        public List<Movie> OrderByReleaseDate()
        {
            var orderedByRelaseDate = _movieService.OrderByReleaseDate();

            return orderedByRelaseDate;
        }

        public List<Movie> OrderByAviability()
        {
            var orderedByAviability = _movieService.OrderByAvailability();
            return orderedByAviability;
        }


        public List<Movie> GetMoviesByGenre()
        {
            Console.WriteLine("Enter genre you want to search");
            var genre = Console.ReadLine();
            var moviesByGenre = _movieService.GetByGenre(genre);

            foreach(var movie in moviesByGenre)
            {
                Console.WriteLine(movie.Title);
            }
            return moviesByGenre;
        }

        public List<Movie> GetMoviesByReleaseYear()
        {
            Console.WriteLine("Enter the release year:");
            int year = InputParser.ToInteger(1955, DateTime.Now.Year);
            var moviesByYear = _movieService.GetByYear(year);

            foreach (var movie in moviesByYear)
            {
                Console.WriteLine($"{movie.Title} , {movie.ReleaseDate}" );
            }

            return moviesByYear;

        }

        public List<Movie> SearhMoviesByTitle()
        {
            Console.WriteLine("Enter the title of the movie:");
            string title = Console.ReadLine();
            var moviesByTitle = _movieService.SearchMoviesByTitle(title);

            foreach (var movie in moviesByTitle)
            {
                Console.WriteLine(movie.Title);
            }

            return moviesByTitle;
        }

        public List<Movie> HistoryOfRentedMovies(User user)
        {
            var rentedMoviesHistory = user.RentedMoviesHistory;
            
            foreach(var movie in rentedMoviesHistory)
            {
                Console.WriteLine(movie.Title);
            }

            return rentedMoviesHistory;
        }

        public List<Movie> RentedMovies(User user)
        {
            var rentedMovies = user.RentedMovies;

            foreach (var movie in rentedMovies)
            {
                Console.WriteLine(movie.Title);
            }
            
            return rentedMovies;
        }

        public Movie RentVideo()
        {
            Console.WriteLine("Enter the id of the movie you want to rent");
            var id = InputParser.ToInteger(1, 1000);

            var rentedVideo = _movieService.GetAllMovies().FirstOrDefault(movie => movie.Id == id);
            rentedVideo.Quantity--;

            return rentedVideo;
        }

        public Movie ReturnVideo()
        {
            Console.WriteLine("Enter the id of the movie you want to return");
            var id = InputParser.ToInteger(1, 1000);

            var returnVideo = _movieService.GetAllMovies().FirstOrDefault(movie => movie.Id == id);
            returnVideo.Quantity++;

            return returnVideo;

        }


    }
}
