using System;
namespace MovieLibrary
{
    /*
Name: Dakota McGregor
Date: 04/17/2021 

Validation methods to validate user input accross other classes

*/

    public class Validation
    {
        public static bool BoolValidation(string message)
        {
            Console.WriteLine($"{message}");

            string z = Console.ReadLine();

            while (z.ToLower() != "yes" && z.ToLower() != "no")

            {
                Console.WriteLine("\r\nError: Please only type \"Yes\" or \"No\"\r\n");
                Console.Write($"{message}");
                z = Console.ReadLine();
            }

            return (z == "yes");
        }


        
        public static string StringValidation(string y)
        {
            Console.Write(y);
            string x = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(x))
            {
                Console.WriteLine("\r\nERROR: Please do not leave blank\r\n");
                Console.Write("Please re-enter your answer: ");
                x = Console.ReadLine();
            }

            return x;
        }

        public static string DarkLight(string y)
        {
            Console.WriteLine(y);
            string x = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(x) && x.ToLower() != "dark" && x.ToLower() != "light")
            {
                Console.WriteLine("\r\nERROR: Please do not leave blank\r\n");
                Console.Write("Please re-enter your answer: ");
                x = Console.ReadLine();
            }
            y = x.ToLower();

            return y;
        }

        public static int IntergerValidation(string message)
        {
            Console.Write(message);

            string i = Console.ReadLine();
            int z;

            while (!(int.TryParse(i, out z)))
            {
                Console.WriteLine("\r\nERROR: Please only enter a valid number.\r\n");
                Console.Write("Please re-enter your answer: ");
                i = Console.ReadLine();
            }
            return z;
        }


        public static int RangeValidation(string y, int min, int max)
        {
            Console.Write(y);

            string z = Console.ReadLine();
            int i;
            while (!(int.TryParse(z, out i)) || i < min || i > max)
            {

                Console.Write("\r\nERROR: Please re-enter your answer: ");
                z = Console.ReadLine();

            }
            return i;   
        }

        public static double DoubleValidation(string message)
        {
            Console.Write($"{message}");

            string z = Console.ReadLine();
            double number;
            while (!(double.TryParse(z, out number)))
            {
                Console.WriteLine("Oops! That doesnt apper to be a vaid answer.\r\n");
                Console.Write($"Please re enter your answer: ");

                z = Console.ReadLine();
            }
            return number;
        }
    }
}
