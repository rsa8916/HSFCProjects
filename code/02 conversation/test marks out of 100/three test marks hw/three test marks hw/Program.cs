using System;

namespace three_test_marks_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first test result out of one hundred");

            int num = int.Parse(Console.ReadLine());
            int avg = 0;
            int counter = 0;

            while (num != 0) 
            {

                avg += num;
                counter++;

                Console.WriteLine("Enter another result, please. If no more resuls enter 0. ");
                num = int.Parse(Console.ReadLine());



            }
            Console.WriteLine("the average of your numbers is : {0}", avg / counter);
            Console.ReadKey();

        }
    }
}
