using System;
using System.Collections.Generic;
using System.Text;
using Workshop.MovieRent.Data.Models;

namespace Workshop.MovieRent.Data.Database
{
    public class InMemoryDatabase
    {
        protected List<User> Users { get; set; }
        protected List<Movie> Movies { get; set; }

        public InMemoryDatabase()
        {
            InitDatabase();
        }

        private void InitDatabase()
        {
            Users = new List<User>
            {
                new User(){CardNumber = 123, FullName = "Elena Panovska"}
            };

            Movies = new List<Movie>
            {

            };
        }


    }
}
