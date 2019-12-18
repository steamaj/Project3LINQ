using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2LINQ
{
    class Movies
    {
        public int MovieNumber { get; set; }
        public String MovieName { get; set; }
        public int Rating { get; set; }
    }//class Employee
    class Program
    {
        static void Main(string[] args)
        {
            Movies[] moviesArray = {
                new Movies() { MovieNumber = 1, MovieName = "Avengers: Endgame", Rating = 94},
                new Movies() { MovieNumber = 2, MovieName = "The Lion King", Rating = 53},
                new Movies() { MovieNumber = 3, MovieName = "Toy Story 4", Rating = 97},
                new Movies() { MovieNumber = 4, MovieName = "Captain Marvel", Rating = 78},
                new Movies() { MovieNumber = 5, MovieName = "Spider-Man: Far from Home", Rating = 90},
                new Movies() { MovieNumber = 6, MovieName = "Frozen II", Rating = 77},
                new Movies() { MovieNumber = 7, MovieName = "Aladdin", Rating = 57},
                new Movies() { MovieNumber = 8, MovieName = "Joker", Rating = 69},
                new Movies() { MovieNumber = 9, MovieName = "It Chapter Two", Rating = 63},
                new Movies() { MovieNumber = 10, MovieName = "Us", Rating = 93},
                new Movies() { MovieNumber = 11, MovieName = "Fast & Furious Presents: Hobbs & Shaw", Rating = 67},
                new Movies() { MovieNumber = 12, MovieName = "John Wick: Chapter 3 - Parabellum", Rating = 90},
                new Movies() { MovieNumber = 13, MovieName = "How to Train Your Dragon: The Hidden World", Rating = 90},
                new Movies() { MovieNumber = 14, MovieName = "The Secret Life of Pets 2", Rating = 59},
                new Movies() { MovieNumber = 15, MovieName = "Pokémon Detective Pikachu", Rating = 68},
            };

            // Querie #1
            var movie = from m in moviesArray
                        where m.Rating > 65 && m.Rating < 95
                        select m;

            foreach (var movies in movie)
            {
                Console.WriteLine("Movies that are rated between 95% and 65% on Rotten Tomatoes are : " + movies.MovieName);
            }


            // Querie #2
            var groups = from m in moviesArray
                         orderby m.Rating
                         group m by m.Rating;

            foreach (var mov in groups)
            {
                Console.WriteLine("***************************************************** Percent Rating: {0}", mov.Key);
                foreach (Movies m in mov)
                {
                    Console.WriteLine("Movie: {0}", m.MovieName);
                }
            }


            // Querie #3
            var ts = from t in moviesArray
                       where t.MovieName.StartsWith("T")
                       select t;

            foreach (var mov in ts)
            {
                Console.WriteLine("Movies that start with T are: " + mov.MovieName + " with a rating of " + mov.Rating + "%");
            }



        }
    }
}
