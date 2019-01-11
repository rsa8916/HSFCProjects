using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class Address
    {
        private int number;
        private string street;
        private string town;
        private string postcode;

        public void SetNumber(int theNumber)
        {
            number = theNumber;
        }
        public int GetNumber()
        {
            return number;
        }

        public void SetStreet(string theStreet)
        {
            street = theStreet;
        }
        public string GetStreet()
        {
            return street;
        }

        public void SetTown(string theTown)
        {
            town = theTown;
        }
        public string GetTown()
        {
            return town;
        }

        public void SetPostcode(string thePostcode)
        {
            postcode = thePostcode;
        }

        public string GetPostcode()
        {
            return postcode;
        }
    }
}
