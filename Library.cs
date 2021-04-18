using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
Name: Dakota McGregor
Date: 04/17/2021

        Library contains methods to read data from a text file and add to a list of the Movie Object(Load) ,add a movie, view movie titles, view specific a movie, and remove a movie from the Library.

        # Add movie method will store user input and append it to the Movies.txt file.

        # View titles will iterate over the Movie objects, add them to a list, and return the list of itiles.

        # View Movie will show the Title,Year,Director,and summary based on the user input.

        # Remove movie will store the text file to a list, remove the line number that the user
        wanted to rent from the list, then write the updated text file to the text file.

        # Load check to see if the text file exists, if not, creates a text file.
        It will then add data to the Movie object for each line in the text file.

*/

namespace MovieLibrary
{
    public class Library
    {
        private List<Movie> _movie;
        private string _file = "../../../Movies.txt";

        public string FilePath { get; set; }
        public string Address { get; set; }

        public Library()
        {
            FilePath = _file;
            _movie = new List<Movie>();
            Address = "123 Main St.";
            Load();
        }

        public void AddMovie()
        {
            UI.Header(" Add movie");

            string title = Validation.StringValidation("\r\nTitle: ");
            int year = Validation.IntergerValidation("\r\nYear: ");
            string director = Validation.StringValidation("\r\nDirector: ");
            string summary = Validation.StringValidation("\r\nSummary: ");

            using (StreamWriter sw = File.AppendText(FilePath))
            {
                sw.WriteLine($"{title},{year},{director},{summary}");
            }
            Load();
        }

        public List<string> ViewTitles()
        {
            List<string> titles = new List<string>();
            foreach (Movie title in _movie)
            {
                titles.Add(title.Title);
            }
            return titles;
        }


        public void ViewMovie(int i)
        {
            int input = 0;
            int num = 1;
            foreach (Movie movie in _movie)
            {

                var item = movie;
                num++;
                if (num == i)
                {
                    Console.Clear();
                    UI.Header($" {item.Title}");
                    Console.WriteLine(Convert.ToString($"\r\nYear: {item.Year}"));
                    Console.WriteLine($"Director: {item.Director}");
                    Console.WriteLine($"\r\nSummary: {item.Summary}");
                }
            }
            UI.Separator();
            Console.WriteLine("\r\n[1] Rent Movie");
            Console.WriteLine("[0] Return to Library\r\n");
            UI.Footer("");
            input = Validation.RangeValidation("Select menu option: ", 0, 1);

            if (input == 1)
            {
                RemoveMovie(i);
            }
        }

        
        private void RemoveMovie(int i)
        {
            List<string> newFile = new List<string>(File.ReadAllLines(FilePath));
            newFile.RemoveAt(i-2);
            File.WriteAllLines(FilePath, newFile);
        }

        private void Load()
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('º');
                        _movie.Add(new Movie
                        {
                            Title = data[0],
                            Year = Convert.ToInt32(data[1]),
                            Director = data[2],
                            Summary = data[3]
                        });
                    }
                }
            }
            else
            {
                using (File.Create(FilePath))
                {
                    Console.WriteLine("File path was empty");
                }
            }
        }
    }
}
