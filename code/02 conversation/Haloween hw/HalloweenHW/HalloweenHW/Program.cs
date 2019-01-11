using System;

namespace HalloweenHW
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int userAnswer;

            Console.WriteLine("Hello what is your name?");
            userName = Console.ReadLine();

            Console.WriteLine("There is something in the shadows {0} . Which weaponn will you choose?" ,userName);
            Console.WriteLine("1. A silver bulle");
            Console.WriteLine("2. A wooden spoon");
            Console.WriteLine("3. A priest");

            userAnswer = Convert.ToInt32(Console.ReadLine()); // converting the answer into a int.

            if ( userAnswer == 1) // if the answer is one then this will show
            {
                Console.WriteLine("You have choosed a silver bullet");
                Console.ReadLine();
            }
            if (userAnswer == 2) // if the answer is two
            {
                Console.WriteLine("You have choosed a wooden spoon");
                Console.ReadLine();
            }
            if (userAnswer == 3) // if the answer is three 
            {
                Console.WriteLine("You have choosen a wooden spoon");
                Console.ReadLine();
            }
            Console.WriteLine("The shape in the shodows moves towards you. Closer and closer it comes until you can tell it is a...");
            Console.WriteLine("...a cat");
            Console.WriteLine("You hide your weapon and both go your seperate ways.");
            Console.ReadLine();// this  will shoe for all of them
        
        }
    }
}
