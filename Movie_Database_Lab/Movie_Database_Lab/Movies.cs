using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Build a movie class with two member variables, title and 
//cateogry. Both should have a string and constructor.
//class should have correct member variables and constructor. 
namespace Movie_Database_Lab
{
    internal class Movies
    {
        public string movieTitle;
        public string movieCategory;

        public Movies(string title, string category)
        {
            movieTitle = title;
            movieCategory = category;
        }
    }
}
