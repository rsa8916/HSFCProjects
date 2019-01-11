using System;

namespace ConversionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion myConvert = new Conversion();
            int option = 0;
            while (option != 4)
            {
                Console.WriteLine("1. Reverse a string");
                Console.WriteLine("2. Convert miles to km");
                Console.WriteLine("3. Convert km to miles");
                Console.WriteLine(" 4 Convert decimal to binary");
                Console.WriteLine("Quit");
                Console.WriteLine("Enter your option");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: // option = 1
                        String userString;
                        Console.WriteLine("Enter your string");
                        userString = Console.ReadLine();
                        Console.WriteLine(myConvert.ReverseString(userString));
                        break;

                    case 2: // option = 2
                        double miles;
                        double km;
                        Console.WriteLine("Enter your miles to be converted to km");
                        miles = Convert.ToInt32(Console.ReadLine());
                        km = miles * 1.60934;
                        Console.WriteLine("Your answwer is:", km);
                        Console.ReadLine();
                        break;

                    case 3: // option =3
                        double km;
                        double miles;
                        Console.WriteLine("Please enter your km so can be converted to miles.");
                        km = Convert.ToInt32(Console.ReadLine());
                        miles = km / 1.60934;
                        Console.WriteLine("Your miles is: ", miles);
                        Console.ReadLine();
                        break;

                    case 4:
                        int decimalNum;
                        Console.WriteLine("Enter your denary num");
                        int decimalNum = Convert.ToInt32(Console.ReadLine());
                        break;


                    default:
                        Console.WriteLine("invalid option");
                        break;


                }
            }
        }
    }
}
