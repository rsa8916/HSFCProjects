using System;

namespace FlowChart
{
    class Program
    {
        static void Main(string[] args)
        { string currentReg;
            Console.WriteLine("Does your car have a current registration enter yes or no");
            currentReg = Console.ReadLine();
            if (currentReg == "yes")
            {
                string yearReg;
                Console.WriteLine("Is it registerd after 2001, answer yes or no");
                yearReg = Console.ReadLine();
                if (yearReg == "yes")
                {
                    int actualYearOfReg;
                    Console.WriteLine("Please enter year of registration");


                    Console.WriteLine("Please enter your reg num");
                    String registration = Console.ReadLine());
                    if (CheckRegNum(registration)==true)
               


            }

        }
    }
}
    bool CheckRegNum(String registration)
    {
        bool success = true;
        //lets check first letter
        char letter = registration[0];
        if ((letter < 'A') | (letter > 'Z') | (letter == 'I') | (letter == 'Q'))
        {
            Console.WriteLine("error first letter");
            success = false;
        }
        //2nd letter 
        char letter = registration[1];
        if ((letter < 'A') | (letter > 'Z') | (letter == 'I') | (letter == 'Q'))
        {
            Console.WriteLine("error second letter");
            success = false;
        }
        //3rd
        char letter = registration[2];
        if ((letter < '0') | (letter > 9))
        {
            Console.WriteLine("error third letter");
            success = false;
        }
        //4th
        char letter = registration[3];
        if ((letter < '0') | (letter > 9))
        {
            Console.WriteLine("error fourth letter");
            success = false;
        }
        //5th
        char letter = registration[4];
        if ((letter >= 'A') | (letter >= '0'))
        {
            Console.WriteLine("error fith letter");
            success = false;
        }
        // 6th
        char letter = registration[5];
        if ((letter = 'I') | (letter = 'Q'))
        {
            Console.WriteLine("error in sixth leter");
            success = false;
        }
        //7th
        char letter = registraiton[6];
        if ((letter = 'I') | (letter = 'Q'))
        {
            Console.WriteLine("error sixth letter");
            success = false;
        }
        //8th
        char letter = registration[7];
        if ((letter = 'I') | (letter = 'Q'))
        {
            Console.WriteLine("error last letter");
            success = false;
        }
        return true;
        // if all ok.
    }

  
    


        