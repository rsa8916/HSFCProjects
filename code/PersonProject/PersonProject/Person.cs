using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    public class Person
    {
        private string surname;
        private string otherNames;
        private int age;
        private string houseName;
        private int yearOfBirth;


        public void SetHouseName(string theHouseName)
        {
            houseName = theHouseName;
        }
        public string GetHouseName()
        {
            return houseName;
        }

        public void SetYearOfBirth(int theYearOfBirth)
        {
            yearOfBirth = theYearOfBirth;
        }
        public int GetYearOfBirth()
        {
            return yearOfBirth;
        }



        public void SetSurname(string theSurname)
        {
            surname = theSurname;
        }
        public string GetSurname()
        {
            return surname;
        }


        public void SetOtherNames(string theOtherNames)

        {
            otherNames = theOtherNames;
        }

        public string GetOtherNames()
        {
            return otherNames;
        }

        public void SetAge(int theAge)
        {
            age = theAge;
        }
        public int SetAge()
        {
            return age;
        }
    }

}
