using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSerch
{
    class Program
    {
        public static void Main(string[] args)
        {
            NameList theNames = new NameList();
            theNames.AddName("Rose");
            theNames.AddName("unasigned");

            Console.WriteLine("There are now" + theNames.GetLength() + " entries in the table");
            theNames.RemoveName("Rose");
            Console.WriteLine("There are now " + theNames.GetLength() + "entries in the table");

                
        }
    }
}
