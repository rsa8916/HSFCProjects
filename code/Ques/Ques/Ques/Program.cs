using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue rose = new Queue(20);
            rose.EnQueue(4);
            rose.EnQueue(5);
            Console.WriteLine(rose.DeQueue());
            Console.ReadLine();


    }
}
}
