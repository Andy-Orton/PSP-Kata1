using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kata1
{
    public class OcrFileReader
    {
        const string FILE_PATH = "../../../Data/BankOrcStory1_SampleInput.txt";


        public static List<string> ReadFile()
        {

            List<string> lines = new List<string>();


            using (StreamReader streamReader = File.OpenText(FILE_PATH))
            {

                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }

        public static List<AccountNumber> ProcessRawAccountNumbers(List<string> lines)
        {
            List<AccountNumber> accountNumbers = new List<AccountNumber>();

            //char[,,] charBuffer = new char[DIGITROWCOUNT, DIGITCOLCOUNT, DIGITCOUNT];
            string[] accountNumberBuffer = new string[AccountNumber.ACCOUNT_NUMBER_LENGTH];


            string bufferString = "";



            //run through each account number
            for (int accountNumberIndex = 0; accountNumberIndex <= lines.Count / AccountNumber.DIGIT_ROW_COUNT; ++accountNumberIndex)
            {
                //for each account number iterate through every digit
                for (int digitIndex = 0; digitIndex < AccountNumber.ACCOUNT_NUMBER_LENGTH; ++digitIndex)
                {
                    //read through 3x3 matrix representing a digit
                    for (int charRowIndex = 0; charRowIndex < AccountNumber.DIGIT_ROW_COUNT - 1; ++charRowIndex)
                    {
                        for (int charColIndex = 0; charColIndex < AccountNumber.DIGIT_CHAR_LENGTH; ++charColIndex)
                        {
                            //Since an account number is comprised of four rows of characters and a digit is comprised of a 3x3 matrix of characters, offsets (e.g. [accountNumberIndex * (DIGITROWCOUNT + 1) + charRowIndex])
                            //are required to properly read digits in to memory 
                            //charBuffer[charRowIndex, charColIndex, digitIndex] = lines[accountNumberIndex * (DIGITROWCOUNT + 1) + charRowIndex][digitIndex * DIGITCOLCOUNT + charColIndex];
                            //Console.Out.WriteLine(lines[accountNumberIndex * DIGITROWCOUNT + charRowIndex]);

                            bufferString += lines[(accountNumberIndex * AccountNumber.DIGIT_ROW_COUNT) + charRowIndex][digitIndex * AccountNumber.DIGIT_CHAR_LENGTH + charColIndex];
                        }
                        bufferString += "\n";
                    }
                    // Console.Out.WriteLine(bufferString);
                    accountNumberBuffer[digitIndex] = bufferString;
                    bufferString = "";
                }
                // accountNumbers[accountNumberIndex] = new AccountNumber(accountNumberBuffer);
                accountNumbers.Add(new AccountNumber(accountNumberBuffer));

            }

            return accountNumbers;

        }
    }
}
