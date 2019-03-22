using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic
{
    class Student
    {
        String[] names = new String[] { "Rose", "Serena", "Hannah" };
        private string name; // every student has a name
     //   private String[] myCollection = new String[];//every student has there own collection of music

        public Student()//a class constructor method to set defaukt values for all its vaiable members
        {
          

        }
      // inserting setter methods for each variable member
      public void setName(string name)
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
