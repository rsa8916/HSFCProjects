using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic
{
    public class Student //make public
    {
        String[] names = new String[3];//three names of differetn names
        public string name; // every student has a name <------Probs dont need
        private String[] myCollection = new String[14];//every student has there own collection of music up to 14 tracks casue thats the max amountss of tracks

        public Student(String aName)//a class constructor method to set default values for all its vaiable members
        {
            name = aName;

        }
      // inserting setter methods for each variable member
      public void setName(String name)
      {
            this.name = name;
      }
       //inserting getter methods for each variable member
       public string getName()
        {
            return name;
       
        }
    }
}
