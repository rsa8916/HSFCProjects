using System;

namespace three_int_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number...");
            string sNumber1 = Console.ReadLine();
            int iNumber1 = int.Parse(sNumber1);

            Console.Write("Please enter another number...");
            string sNumber2 = Console.ReadLine();
            int iNumber2 = int.Parse(sNumber2);

            Console.Write("Please enter another number...");
            string sNumber3 = Console.ReadLine();
            int iNumber3 = int.Parse(sNumber3);

            int iAnswer = iNumber1 + iNumber2 + iNumber3;

            Console.Write(" \n\n Your answer is: " + " " + iAnswer);        
            Console.WriteLine(" \n\n Press space to exit...bye");
            Console.ReadLine();



        }
    }
}
