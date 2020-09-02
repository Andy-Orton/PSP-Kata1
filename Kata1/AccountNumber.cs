using System;
using System.Collections.Generic;
using System.Text;

namespace Kata1
{
    public class AccountNumber
    {
        public const int ACCOUNT_NUMBER_LENGTH = 9;
        public const int DIGIT_CHAR_LENGTH = 3;
        public const int DIGIT_ROW_COUNT = 4;

        public static readonly List<string> NUMBER_CODES = new List<string>() 
        {
            " _ \n" +
            "| |\n" +
            "|_|\n",

            "   \n" +
            "  |\n" +
            "  |\n",

            " _ \n" +
            " _|\n" +
            "|_ \n",

            " _ \n" +
            " _|\n" +
            " _|\n",

            "   \n" +
            "|_|\n" +
            "  |\n",

            " _ \n" +
            "|_ \n" +
            " _|\n",

            " _ \n" +
            "|_ \n" +
            "|_|\n",

            " _ \n" +
            "  |\n" +
            "  |\n",

            " _ \n" +
            "|_|\n" +
            "|_|\n",

            " _ \n" +
            "|_|\n" +
            " _|\n"
        };

        public string[] digitStrings = new string[9];
        public string[] DigitStrings
        {
            set { digitStrings = value; }
            get => digitStrings;
        }
    
        public int[] convertedDigits = new int[9];

        public override string ToString()
        {
            string str = "";
            for (int digitIndex = 0; digitIndex < ACCOUNT_NUMBER_LENGTH; ++digitIndex)
            {
                str += convertedDigits[digitIndex];
            }

            return str;
        }

        public void Convert()
        {
            for (int digitIndex = 0; digitIndex < ACCOUNT_NUMBER_LENGTH; ++digitIndex)
            {
                convertedDigits[digitIndex] = NUMBER_CODES.IndexOf(digitStrings[digitIndex]);
            }
        }

        public AccountNumber(string[] digits)
        {
            this.digitStrings = digits;
            Convert();
        }

        public Boolean ValidChecksum()
        {
            return true;
        }
    }
}
