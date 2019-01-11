using System;
using System.Collections.Generic;
using System.Text;

namespace ConversionProject
{
    class Conversion
    {
        // method to reverse a string

        public String ReverseString(String binaryString)
        {
            String newString = "";
            for (int i = 0; i < binaryString.Length; i++)
            {
                newString = binaryString.Substring(i, 1) + newString;
            }
            return newString;
        }
        String DenaryToBinary(int denaryNum)
        {
            string binaryString = "";
            while (denaryNum > 1)
            {
                binaryString = (denaryNum % 2) + binaryString;
                    denaryNum = denaryNum / 2;
            }

            return denaryNum + binaryString;
        }



    }
}
}
