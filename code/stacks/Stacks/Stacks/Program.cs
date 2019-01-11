using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Stacks s1 = new Stacks(100);
            Random rnd = new Random();
            int theNum = rnd.Next(0,99);
            string userAns;

            Console.WriteLine("What do you want to do");
            Console.WriteLine(" push or pop");
            userAns = Console.ReadLine();
            if (userAns == "pop")
            {
                
                Stacks.Pop(theNum);
                

            }
            if (userAns == "push")
            {
                Stacks.Push(theNum);
            }
        }
    }
}
