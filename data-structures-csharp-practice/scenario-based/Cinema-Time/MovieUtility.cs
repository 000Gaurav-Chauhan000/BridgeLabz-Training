using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_Time
{
    internal class MovieUtility : IMovieManager{

        Movie[] movies=new Movie[2];
        int movieCount = 0;

        public void AddMovie() { 
            if (movieCount >= movies.Length){
                Console.WriteLine("Movie list is full.");
                return;
            }

            Movie movie = new Movie();

            Console.WriteLine("Enter movie title: ");
            movie.Title = Console.ReadLine();

            Console.WriteLine("Enter movie time: ");
            movie.Time = Console.ReadLine();

            movies[movieCount] = movie;
            movieCount++;

            Console.WriteLine("Movie added successfully.");

        }
        public void DisplayMovies()
        {
            if (movieCount == 0)
            {
                Console.WriteLine("No movies to display.");
                return;
            }

            for (int i = 0; i < movieCount; i++)
            {
                Console.WriteLine($"Title: {movies[i].Title}, Time: {movies[i].Time}");
            }
        }
        public string SearchMovie(string name)
        {
            for (int i = 0; i < movieCount; i++)
            {
                if (movies[i].Title.Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    return "Movie found: " + movies[i].Title;
                }
            }
            return "Movie not found.";
        }
    }
}
