using System;
using System.Collections.Generic;

/*
 Name: Dakota McGregor
Date: 04/17/2021

Dynamic menu that will take any list that is passed to it and display the list.

 */

namespace MovieLibrary
{   
    public class Menu
    {
        private List<string> _myList = new List<string>();

        public Menu(List<string> myList)
        {
            _myList = myList;
        }

        public void Display(int i)
        {
            foreach (string item in _myList)
            {

                Console.WriteLine($"[{i}] {item}");
                i++;
            }
            Console.WriteLine("");
        }
    }
}
