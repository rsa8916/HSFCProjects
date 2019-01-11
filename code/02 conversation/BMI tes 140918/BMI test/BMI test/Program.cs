using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_test
{
    class Program
    {
        static void Main(string[] args)

                 double weight;
                 double height;
                 double sngBMI;
                 string name;
        
               Console.WriteLine("Please enter your name.");
               name = (Console.ReadLine());

               Console.Writeline("Please enter your weight in kg.");
               decimal Weight = Convert.ToInt32();

              Console.WriteLine("Please enter your height in meters.");
              decimal Height = Convert.ToInt32();

              decimal sngBMI = "(weight / height * height)" ;
        

             Console.Writeline( name "your BMI is:" + " " + sngBMI);
             Console.Readline();





        {
        }
    }
}
