using System;
using System.Collections.Generic;

/*
Name: Dakota McGregor
Date: 04/17/2021
*/

namespace MovieLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.Theme();

            List<string> addmovie = new List<string>() { "Add Movie" };
            Menu addMov = new Menu(addmovie);

            bool keepGoing = true;
            while (keepGoing)
            {
                Library lib = new Library();
                Menu titles = new Menu(lib.ViewTitles());

                Console.Clear();

                UI.Header(" Movie library");
                Console.WriteLine($"{lib.Address} ");
                UI.Separator();
                Console.WriteLine("");
                titles.Display(1);
                Console.WriteLine("");
                addMov.Display(0);

                int maxCount = lib.ViewTitles().Count;
                keepGoing = MenuSelection(lib, maxCount);
            }


        }

        private static bool MenuSelection(Library lib, int max)
        {
            UI.Footer("");
            int input = Validation.RangeValidation("Please choose Option: ", 0, max);

            bool keepGoing = true;

            if (input>0)
            {
                lib.ViewMovie(input+1);

            }else if (input == 0)
            {
                Console.Clear();
                lib.AddMovie();
            }

            return keepGoing;
        }
    }
}
