using System;
using System.Collections.Generic;
using System.Text;

namespace Kata1
{
    public class AccountNumber
    {
        //public static readonly char[3, 3, 10] digitCodes

        public char[,,] digits = new char[3, 3, 9];
        public int[] convertedDigits = new int[9];

        public void convert()
        {

        }

        public AccountNumber(char[,,] digits)
        {
            this.digits = digits;
            convert();
        }

        public Boolean ValidChecksum()
        {
            return true;
        }
    }
}
