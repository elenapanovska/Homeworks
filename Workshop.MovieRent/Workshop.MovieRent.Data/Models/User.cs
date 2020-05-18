﻿using System;
using System.Collections.Generic;
using System.Text;
using Workshop.MovieRent.Data.BaseModels;

namespace Workshop.MovieRent.Data.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CardNumber { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        //public DateTime SubscriptionRenewd { get; set; }
        public List<Movie> RentedMovies { get; set; }
        public List<Movie> RentedMoviesHistory { get; set; }

        public User()
        {
            IsSubscriptionExpired = false;
            RentedMovies = new List<Movie>();
            RentedMoviesHistory = new List<Movie>();

        }

    }
}
