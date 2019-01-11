using System;

namespace fizzBuzzProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double userNum;

            void GenerateFizzBuzz() //procdure goes here
            {
                for (int Count = 0; Count < userNum; Count++)
                {
                    if (userNum % 3 == 0)
                    {
                        Console.WriteLine("fizz");
                        Console.WriteLine();

                    }
                    if (userNum % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                        Console.WriteLine();

                    }
                    if (userNum % 15 == 0)
                    {
                        Console.WriteLine("fizz buzzz");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(Count);
                        Console.ReadLine();

                    }
                }// main program start here


                Console.WriteLine("Please enter your number here for the fizz buzz game'");
                userNum = Convert.ToInt32(Console.ReadLine());
                GenerateFizzBuzz();
                Console.ReadLine();

            }
        }
    }
}









    

