using System;

namespace fish_tank_hw
{
    class Program
    {
        static void Main(string[] args)
        {

            double height;
            double depth;
            double lenght;
            double litres;
            double gallons;


            Console.WriteLine("Please enter the height of the fish tank in cm");
            height = Convert.ToInt32(Console.ReadLine());
         

            Console.WriteLine("Please enter the depth of the fish tank in cm");
            depth = Convert.ToInt32(Consle.ReadLine());


            Console.WriteLine("Please enter the legth of the fish tank in cm");
            lenth = Convert.ToInt32(Console.ReadLine());

            volume = (heigth * depth * length) / 1000;

            Console.Writeline("Your volume of water: {0}", volume);
            Console.ReadLine();

            gallons = volume * 0.219969;

            Console.WriteLine("Your water in UK gallons: {0}", gallons);
            Console.ReadLine();












        }
    }
}
