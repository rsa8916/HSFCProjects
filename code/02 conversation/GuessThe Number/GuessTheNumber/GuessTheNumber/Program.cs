using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int intNumber;
            int intGuess;
            int intCount = 0;


            intNumber = rnd.Next(0, 11); // delivers a random value from 1 to 10
            do
            {

                Console.WriteLine("guess a random number that the computer generated between 1 and 10. please." );
                intGuess = Convert.ToInt32(Console.ReadLine());


                intCount = intCount + 1;


                if (intGuess > intNumber)
                {
                    Console.WriteLine("your guess was too high");

                    

                }
                if (intGuess < intNumber)
                {
                    Console.WriteLine("your number was too low");
                    
                }

                if (intGuess == intNumber)
                   
                {

                    Console.WriteLine("you got it in {0} " ,intCount);
                }

            } while (intGuess != intNumber);
            


            Console.ReadLine(); 
         

        }
    }
}
