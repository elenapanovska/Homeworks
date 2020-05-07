using Class08.Linq.Music.Hm.Business.Data;
using Class08.Linq.Music.Hm.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class08.Linq.Music.Hm.Business.Services
{
    public class Services : Database
    {
        public List<Song> Jerry()
        {
            var jerry = FansList.FirstOrDefault(fan => fan.FirstName == "Jerry");
            var songsThatStartwB = Songs.Where(song => song.Title.StartsWith('B')).ToList();

            jerry.FavouriteSongs = songsThatStartwB;
            jerry.GetFavSongs();

            return jerry.FavouriteSongs;
        }

        public List<Song> Maria()
        {
            var maria = FansList.FirstOrDefault(fan => fan.FirstName == "Maria");
            var songsLongerThan6Min = Songs.Where(song => song.Lenght / 60 > 6).ToList();

            maria.FavouriteSongs = songsLongerThan6Min;
            maria.GetFavSongs();

            return maria.FavouriteSongs;
        }

        public List<Song> Jane()
        {
            var jane = FansList.FirstOrDefault(fan => fan.FirstName == "Jane");
            var rockSongs = Songs.Where(song => song.Genre == Genre.Rock).ToList();

            jane.FavouriteSongs = rockSongs;
            jane.GetFavSongs();

            return jane.FavouriteSongs;
        }
       
        public List<Song> Stefan()
        {
            var stefan = FansList.FirstOrDefault(fan => fan.FirstName == "Stefan");
            var hipHopSongs = Songs.Where(song => song.Lenght / 60 > 3 && song.Genre == Genre.Hip_Hop).ToList();

            stefan.FavouriteSongs = hipHopSongs;
            stefan.GetFavSongs();

            return stefan.FavouriteSongs;
        }

        public List<Person> FansWith4orMoreSongs()
        {
            var fans = FansList.Where(fan => fan.FavouriteSongs.Count >= 4).ToList();

            Console.WriteLine("Fans with 4 or more favoure songs:");
            foreach(var fan in fans)
            {
                Console.WriteLine(fan.FirstName);
            }

            return fans;
        }

    }
}
