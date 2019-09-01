using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise4
{
    class Program
    {
        static void Main(string[] args)
        {

            var movie1 = new Movie();
            var movie2 = new Movie();
            var movie3 = new Movie();
            

            movie1._Movie("Casino Royale", "Eon Productions", "PG­-13");
            movie2._Movie("Glass", "Buena Vista International", "PG-­13");
            movie3._Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            Movie[] manyMovies = new Movie[3];
            manyMovies[0] = movie1;
            manyMovies[1] = movie2;
            manyMovies[2] = movie3;

            //Array.ForEach(manyMovies, Console.WriteLine);
            Movie[] newmovies = new Movie[3];
             newmovies = GetPG(manyMovies);
            foreach (var movie in newmovies)
            {
                if (movie != null)
                {
                    Console.WriteLine(movie.ReturnTitle());
                }
               
            }
            Console.ReadLine();
        }

        private static Movie[] GetPG(Movie[] manyMovies)
        {
            Movie[] pgMovies = new Movie[manyMovies.Length];
            
            int newArrayIndex = 0;
            foreach (var item in manyMovies)
            {
                if (item.ReturnRating() == "PG")
                {
                    pgMovies[newArrayIndex] = item;
                    newArrayIndex++;
                }
            }
            
            return pgMovies;
        }

    }
}
