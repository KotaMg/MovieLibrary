using System;
using System.IO;

/*
Name: Dakota McGregor
Date: 04/17/2021

Class objexts to store specific details about each new movie that will be added from the text file

*/

namespace MovieLibrary
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Summary { get; set; }

        public Movie()
        {
        }
    }
}

