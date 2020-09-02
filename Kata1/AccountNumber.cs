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
    
        public int[] decodedDigits = new int[9];

        public override string ToString()
        {
            string str = "";
            for (int digitIndex = 0; digitIndex < ACCOUNT_NUMBER_LENGTH; ++digitIndex)
            {
                str += decodedDigits[digitIndex];
            }

            return str;
        }

        public void DecodeTextDigits()
        {
            for (int digitIndex = 0; digitIndex < ACCOUNT_NUMBER_LENGTH; ++digitIndex)
            {
                decodedDigits[digitIndex] = NUMBER_CODES.IndexOf(digitStrings[digitIndex]);
            }
        }

        public AccountNumber(string[] digits)
        {
            this.digitStrings = digits;
            DecodeTextDigits();
        }

        public Boolean ValidChecksum()
        {
            int sum = 0;

            for (int i = 0; i < 10; ++i)
            {
                sum += decodedDigits[10 - i] * i;
            }

            return sum % 11 == 0;
        }
    }
}
