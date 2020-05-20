using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Workshop.MovieRent.Business.Helpers;
using Workshop.MovieRent.Business.Loaders;
using Workshop.MovieRent.Business.Menus;
using Workshop.MovieRent.Data.Database;
using Workshop.MovieRent.Data.Models;

namespace Workshop.MovieRent.Business.Services
{
    public class MovieService
    {
        private MovieRepository _movieRepository;

        public MovieService()
        {
            _movieRepository = new MovieRepository();
        }

        public void ViewMovieList(User user)
        {
            string errorMessage = string.Empty;
            var movies = _movieRepository.GetAllMovies();


            bool isFinished = false;
            while (!isFinished)
            {
                Screen.ClearScreen();
                Screen.ErrorMessage(errorMessage);
                if (movies.Count != 0)
                {
                    PrintMoviesInfo(movies);
                }
                Screen.OrderingMenu();
                var selection = InputParser.ToInteger(0, 9);

                switch (selection)
                {
                    case 1:
                        movies = _movieRepository.GetAllMovies();
                        break;
                    case 2:
                        movies = _movieRepository.OrderByGenre();
                        break;
                    case 3:
                        var genre = InputParser.ToGenre();
                        movies= _movieRepository.GetByGenre(genre);
                        break;
                    case 4:
                        movies = _movieRepository.OrderByRelaseDate();
                        break;
                    case 5:
                        Console.WriteLine("Enter year:");
                        var year = InputParser.ToInteger(
                            _movieRepository.GetAllMovies().Min(_movie => _movie.ReleaseDate.Year),
                            DateTime.Now.Year - 1
                            );
                        movies = _movieRepository.GetByYear(year);
                        break;
                    case 6:
                        movies= _movieRepository.OrederByAvaibility();
                        break;
                    case 7:
                        movies = _movieRepository.GetAvailableMovies();
                        break;
                    case 8:
                        Console.WriteLine("Enter search phrase:");
                        string titlePart = Console.ReadLine();
                        movies = _movieRepository.SearchMoviesByTitle(titlePart);
                        break;
                    case 9:
                        try
                        {
                            RentVideo(user);
                        }
                        catch (Exception ex)
                        {
                            errorMessage = ex.Message;

                        }
                        break;
                    case 0:
                        isFinished = !isFinished;
                        break;
                }
            }
        }

        private void RentVideo(User user)
        {
            Console.Write("Enter movie id:");
            var movieId = InputParser.ToInteger( 
                _movieRepository.GetAllMovies().Min(_movie => _movie.Id),
                _movieRepository.GetAllMovies().Max(_movie => _movie.Id));

            var movie = _movieRepository.GetMovieById(movieId);

            if (movie != null)
            {
                if (!movie.IsAvailable)
                {
                    throw new Exception($"Movie {movie.Title} is not aviable at the moment!");
                    
                }
                Console.WriteLine($"Are you sure you want to rent {movie.Title}? y/n");
                bool confirm = InputParser.ToConfirm();
                if (!confirm)
                {
                    return;
                }
                Console.WriteLine("Renting movie please wait...");
                LoadingHelpers.Spinner();
                movie.Quantity--;
                if(movie.Quantity == 0)
                {
                    movie.IsAvailable = !movie.IsAvailable;
                }
                user.RentedMovies.Add(movie);
                Console.WriteLine("Succesfully rented movie");
                Thread.Sleep(2000);
            }
            else
            {
                throw new Exception($"No movie was found with {movieId} id!");
            }
        }

        private void PrintMoviesInfo(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                string aviability = movie.IsAvailable ? "Yes" : "No";
                Console.WriteLine(
                    String.Format("Rent id: {0} Title: {1} Release date: {2} Genre: {3} Avaiable: {4} Quantity: {5}",
                    movie.Id, movie.Title, movie.ReleaseDate.ToString("MMMM dd yyyy"),
                    movie.Genre, aviability, movie.Quantity));
            }
        }
    }
}
