using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAddressProTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            p1 = new Person();
            p1.SetOtherNames("Rose");
            Console.WriteLine(p1.GetOtherNames());
            p1.SetAge(16);


        }
    }
}
