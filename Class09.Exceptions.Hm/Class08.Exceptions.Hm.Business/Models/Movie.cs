using System;
using System.Collections.Generic;
using System.Text;

namespace Class08.Exceptions.Hm.Business.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public  Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * rating;

            try
            {
                Title = title;
                Genre = genre;
                Rating = rating;
                TicketPrice = 5 * rating;
                if(rating > 5)
                {
                    Exception customException = new Exception("The rating should not be higer that 5");
                    throw customException;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong rating");
                throw ex;
            };
        }

      
    }
}
