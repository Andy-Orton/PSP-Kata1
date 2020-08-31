using System;
using System.Collections.Generic;
using System.IO;

namespace Kata1
{
    class Program
    {
        const string STRINGPATH = "./Data/BankOrcStory1_SampleInput.txt";

        //Bank of digits 
        //public static readonly char[,,] DigitCodes = new char[10, 3, 3]
        //{
        //    { { }, { }, { } },
        //    { , , },
        //    { , , },
        //    { , , },
        //    { , , },
        //    { , , },
        //    { , , },
        //    { , , },
        //    { , , },
        //    { , , },

        //};

        static void Main(string[] args)
        {
            
        }

        public List<String> ReadFile()
        {
            List<string> lines = new List<string>();


            using (StreamReader streamReader = File.OpenText(STRINGPATH))
            {

                string line;
                while ((line = streamReader.ReadLine()) != null )
                {
                    lines.Add(line);
                }
            }

            return lines;
        }

        public const int DIGITROWCOUNT = 3;
        public const int DIGITCOLCOUNT = 3;
        public const int DIGITCOUNT = 9;
        public const int NUMACCOUNTNUMBERS = 500;
        public void stringToMatrix(List<string> lines)
        {
            AccountNumber[] accountNumbers = new AccountNumber[500];

            char[,,] charBuffer = new char[DIGITROWCOUNT, DIGITCOLCOUNT, DIGITCOUNT];


            //run through each account number
            for (int accountNumberIndex = 0; accountNumberIndex < NUMACCOUNTNUMBERS; ++accountNumberIndex)
            {
                //for each account number iterate through every digit
                for (int digitIndex = 0; digitIndex < DIGITCOUNT; ++digitIndex)
                {
                    //read through 3x3 matrix representing a digit
                    for (int charRowIndex = 0; charRowIndex < DIGITROWCOUNT; ++charRowIndex)
                    {
                        for (int charColIndex = 0; charColIndex < DIGITCOLCOUNT; ++charColIndex)
                        {
                            //Since an account number is comprised of four rows of characters and a digit is comprised of a 3x3 matrix of characters, offsets (e.g. [accountNumberIndex * (DIGITROWCOUNT + 1) + charRowIndex])
                            //are required to properly read digits in to memory 
                            charBuffer[charRowIndex, charColIndex, digitIndex] = lines[accountNumberIndex * (DIGITROWCOUNT + 1) + charRowIndex][digitIndex * DIGITCOLCOUNT + charColIndex];
                        }
                    }
                }
                accountNumbers[accountNumberIndex] = new AccountNumber(charBuffer);
            }
        }
    }

}
            