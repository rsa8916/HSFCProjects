using System;

namespace PersonAddressProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person p1;
            p1 = new Person();
            p1.SetOtherNames("Rose");
            Console.WriteLine(p1.GetOtherNames());
            p1.SetAge(16);




        }
    }
}
