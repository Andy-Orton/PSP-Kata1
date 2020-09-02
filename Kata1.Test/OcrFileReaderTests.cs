using Kata1;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata1.Test
{
    public class OcrFileReaderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProcessesRawText()
        {

            List<string> lines = new List<string> { "    _  _     _  _     _  _ ",
                                                    "  | _| _||_||_ |_   | _| _|",
                                                    "  ||_  _|  | _||_|  ||_  _|"};


            List<AccountNumber> accountNumber = OcrFileReader.ProcessRawAccountNumbers(lines);


            //Assert that the first encoded digit in the processed account number is 1
            Assert.True(accountNumber[0].DigitStrings[0] == AccountNumber.NUMBER_CODES[1]);

        }

    }
}