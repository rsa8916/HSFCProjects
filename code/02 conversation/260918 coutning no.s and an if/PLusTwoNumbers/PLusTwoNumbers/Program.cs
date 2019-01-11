using System;

namespace PLusTwoNumbers
{
    class Program
    {
        static void DisplayMenuGetsResults()

        {
            Console.WriteLine("Welcome to the a level quiz!");
            Console.WriteLine("Which would you like to do ");
            Console.WriteLine("- for subtraction");
            Console.WriteLine("+ for addition");
            Console.WriteLine("* for multiplication");
            Console.WriteLine("/ for division");

        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            string option;
            int num1 = 0;
            int num2 = 0;





            int userAnswer = 0;
            int total = 0;
            int skillLevel = 1;

          




            for (int count = 1; count < 11; count++)

            {
                num1 = rnd.Next(0, skillLevel * 10);
                num2 = rnd.Next(0, skillLevel * 12);

                DisplayMenuGetsResults();
                option = Console.ReadLine();

                if (option == "+")
                {


                    Console.WriteLine("what does " + num1 + "+" + num2 + "equal ?");
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    if (userAnswer == num1 + num2)

                    {
                        Console.WriteLine("correct");

                        total = total + 1;
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }
                    if (total % 3 == 0)
                    {
                        skillLevel++;

                        Console.WriteLine("your running total is:" + total + "/" + count);
                    }

                }
                if (option == "-")
                {
                    Console.WriteLine("what does " + num1 + "-" + num2 + "equal ?");
                    userAnswer = Convert.ToInt32(Console.ReadLine());

                    if (userAnswer == num1 - num2)

                    {
                        Console.WriteLine("correct");

                        total = total + 1;
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }
                    if (total % 3 == 0)
                    {
                        skillLevel++;

                        Console.WriteLine("your running total is:" + total + "/" + count);
                    }
                }
                if (option == "*")
                {
                    Console.WriteLine("what does " + num1 + "*" + num2 + "equal ?");
                    userAnswer = Convert.ToInt32(Console.ReadLine());

                    if (userAnswer == num1 * num2)

                    {
                        Console.WriteLine("correct");

                        total = total + 1;
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }
                    if (total % 3 == 0)
                    {
                        skillLevel++;

                        Console.WriteLine("your running total is:" + total + "/" + count);
                    }
                }
                if (option == "/")
                {
                    Console.WriteLine("what does " + num1 + "/" + num2 + "equal ?");
                    userAnswer = Convert.ToInt32(Console.ReadLine());

                    if (userAnswer == num1 / num2)

                    {
                        Console.WriteLine("correct");

                        total = total + 1;
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }
                    if (total % 3 == 0)
                    {
                        skillLevel++;

                        Console.WriteLine("your running total is:" + total + "/" + count);
                    }
                }




                

            }
            Console.ReadLine();
        }
    }
}
