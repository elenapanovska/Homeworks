using System;
using System.Collections.Generic;
using System.Text;

namespace Class08.Linq.Music.Hm.Business.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre Genre { get; set; }
        public List<Song> FavouriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, Genre genre)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Genre = genre;
            
        }

        public void GetFavSongs()
        {
            if(FavouriteSongs.Count == 0)
            {
                Console.WriteLine($"{FirstName} hates music");
            }
            else
            {
                Console.WriteLine($"{FirstName} favorite songs are:");
                foreach (var song in FavouriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }


    }
}
