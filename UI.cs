using System;

/*
Name: Dakota McGregor
Date: 04/17/2021

UI layout is used for design and theme to be used accross the entire program.
*/

namespace MovieLibrary
{
    public static class UI
    {
        public static void Header(string y)
        {
            Console.WriteLine($"===============================================\r\n {y.ToUpper()}\r\n===============================================\r\n");
        }

        public static void Footer(string y, bool pause = false)
        {
            Console.Write($"=====================\r\n{y.ToUpper()}");
            if (pause) Console.ReadLine();
        }

        public static void Separator()
        {
            Console.WriteLine("---------------------");
        }

        public static void Theme()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

        }
    }
}    
 

