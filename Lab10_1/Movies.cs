using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10_1
{
    public class Movie
    {
        //fields
        private string _title = string.Empty;
        private string _category = string.Empty;

        //properties
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
<<<<<<< HEAD
=======

            return ;\\ got lost here

>>>>>>> a9a9d952441d149c5396c801bee082f36b94f3d5
        }

        //constructor
        public Movie(string title, string category)
        {
<<<<<<< HEAD
            this._title = title;
            this._category = category;
        }
=======
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
>>>>>>> a9a9d952441d149c5396c801bee082f36b94f3d5



       

    }
}

