using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10_1
{
    public class Movie
    {
        //fields
        private string _title;
        private string _category;

        //properties
        public string Title
        {
            get
            {
                return _title;
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
        }

        //constructor
        public Movie(string Title, string Category)
        {
            this._title = Title;
            this._category = Category;
        }



        //method (ok)
        public static List<Movie> GetMovie()
        {
            List<Movie> MovieList = new List<Movie>();
            MovieList.Add(new Movie("Tangled", "Animation"));
            MovieList.Add(new Movie("Frozen", "Animation"));
            MovieList.Add(new Movie("Final Destination", "Horror"));
            MovieList.Add(new Movie("Knives Out", "Drama"));
            MovieList.Add(new Movie("Metropolis", "Drama"));
            MovieList.Add(new Movie("The Godfather", "Drama"));
            MovieList.Add(new Movie("Donnie Darko", "Scifi"));
            MovieList.Add(new Movie("Serenity", "Scifi"));
            MovieList.Add(new Movie("The Martian", "Scifi"));

            return MovieList;
        }

        //method
        public static List<Movie> GetMovieByCategory(string userInput)
        {
            List<Movie> MovieList = GetMovie();

            
            foreach (Movie movie in MovieList)
            {
                List<Movie> resultList = new List<Movie>(MovieList.FindAll(movie => movie.Category == userInput));
                
            }

            return ;\\ got lost here

        }

        //method
        public static void MovieListApplication()
        {
            string continueAnswer = string.Empty;
            string userInput = string.Empty;

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 Movies in this list.");

            do
            {
             
                \\also got lost here
                Console.WriteLine("What category are you interested in? ");
                userInput = Console.ReadLine().ToLower();

                
                GetMovieByCategory(userInput);

                Console.WriteLine("What category are you interested in? ");
                continueAnswer = Console.ReadLine().ToLower();

            } while (continueAnswer == "y");

        }   

    }

}

