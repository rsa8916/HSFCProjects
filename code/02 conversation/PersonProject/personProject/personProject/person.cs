using System;
using System.Collections.Generic;
using System.Text;

namespace personProject
{
    public class Person
    {
        private String name;
        private int age;
        private string nationality;

        public void SetName(string aName)
        {
            name = aName;
        }

        public String GetName()
        {
            return name;
        }

        public void SetAge(int anAge)
        {
            age = anAge;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetNationaity(string aNationality)
        {
            nationality = aNationality;
        }

        public String GetNationality()
        {
            return nationality;
        }
    }
}
