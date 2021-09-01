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
        }

        //constructor
        public Movie(string title, string category)
        {
            this._title = title;
            this._category = category;
        }



       

    }
}

