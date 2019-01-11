using System;

namespace forename_and_surname
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Please enter your forname...");
            string forname = Console.ReadLine();
            Console.WriteLine("Please enter your surname...");
            string surname = Console.ReadLine();
            Console.WriteLine("Hello " +  forname + " " + surname);
            Console.ReadKey();
        }
    }
}
