using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10_1
{
    class Program
    {

        static void Main(string[] args)
        {

            string continueAnswer = string.Empty;

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 Movies in this list.");

            do
            {

                Console.Write("What category are you interested in? ");
                string userInput = Console.ReadLine().ToLower();



                List<Movie> MovieList = GetMovie();

                var resultList = MovieList.Where(movie => movie.Category == userInput).ToList();
                foreach (var movie in resultList)
                {
                    Console.WriteLine(movie.Title);
                    
                }

                Console.Write("Would you like to continue searching? (y/n): ? ");
                continueAnswer = Console.ReadLine().ToLower();

            } while (continueAnswer == "y");


        }

        public static List<Movie> GetMovie()
        {
            List<Movie> MovieList = new List<Movie>();
            MovieList.Add(new Movie("Tangled", "animation"));
            MovieList.Add(new Movie("Frozen", "aimation"));
            MovieList.Add(new Movie("Final Destination", "horror"));
            MovieList.Add(new Movie("Scream", "horror"));
            MovieList.Add(new Movie("Knives Out", "drama"));
            MovieList.Add(new Movie("Metropolis", "drama"));
            MovieList.Add(new Movie("The Godfather", "drama"));
            MovieList.Add(new Movie("Donnie Darko", "scifi"));
            MovieList.Add(new Movie("Serenity", "scifi"));
            MovieList.Add(new Movie("The Martian", "scifi"));

            return MovieList;
        }

        //method
        //public static List<Movie> GetMovieByCategory(string userInput)
        //{
        //    string continueAnswer = string.Empty;

        //    Console.WriteLine("Welcome to the Movie List Application!");
        //    Console.WriteLine("There are 10 Movies in this list.");

        //    do
        //    {

        //        Console.WriteLine("What category are you interested in? ");
        //        string userInput = Console.ReadLine().ToLower();

 

        //        List<Movie> MovieList = GetMovie();

        //        var resultList = MovieList.Where(movie => movie.Category == userInput).ToList();
        //        foreach (var movie in resultList)
        //        {
        //            Console.WriteLine(movie.Title);
        //            return resultList;
        //        }

               

        //        Console.WriteLine("What category are you interested in? ");
        //        continueAnswer = Console.ReadLine().ToLower();

        //    } while (continueAnswer == "y");
        //}
    
        ////method
        //public static string MovieListApplication()
        //{
        //    string continueAnswer = string.Empty;


        //    Console.WriteLine("Welcome to the Movie List Application!");
        //    Console.WriteLine("There are 10 Movies in this list.");

        //    do
        //    {

        //        Console.WriteLine("What category are you interested in? ");
        //        string userInput = Console.ReadLine().ToLower();


        //        GetMovieByCategory(userInput);

        //        Console.WriteLine("What category are you interested in? ");
        //        continueAnswer = Console.ReadLine().ToLower();

        //    } while (continueAnswer == "y");

        

    }

}

