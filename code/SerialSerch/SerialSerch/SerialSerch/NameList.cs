using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSerch
{
   public class NameList
        
    {
        private string[] items = new string[20];
        private int nextFreeLocation = 0;

        public void AddName(string name)
        {
            items[nextFreeLocation] = name;
            nextFreeLocation++;
        }
        public int position(string Name)
        {
            int count = -1;
            do
            {
                count++;
            } while (Name != = items[count]);
            return count;
            public void RemoveNames(string name)
        }
        public void RemoveNames(string name)
        {
            int tempNum = positoin(name);
            int temp = nextFreeLocation;
            int loop = temp - tempNum;

            for (int i =  tempNum; i<= loop; i++)
                
        }
        public class NameList
        {
            int AddName(string aName);
            //the code in {}
            {
                NameList theNames = new NameList();
                theNames.addName(Rose);
                theNamew.addName(Hannah);

            }
            int GetLength(string aName);
            //ect
            {
               
            int Position(string aName);
            //ect

            items [nextfreelocation] = theNames;
            nextfreelocatiosn ++;




            //all the arrays will be stored inside an array called fixed size 100
            private string[] items = [100];
            //next free location tells us what is next name
            private int nextFreeLocation;
            //

           }

    }
}
