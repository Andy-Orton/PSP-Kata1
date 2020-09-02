using Kata1;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata1.Test
{
    public class AccountNumberTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DecodesTextDigits()
        {
            List<string> testDigits = new List<string>()
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
                "|_|\n"

            };

            AccountNumber accountNumber = new AccountNumber(testDigits.ToArray());

            Assert.AreEqual("012345678", accountNumber.ToString());


        }

        [Test]
        public void DetectsInvalidTextDigit()
        {
            List<string> testDigits = new List<string>()
            {
                "___\n" +
                "| |\n" +
                "|_|\n",

                "  |\n" +
                "  |\n" +
                "  |\n",

                " _ \n" +
                " _|\n" +
                "|  \n",

                " _ \n" +
                "  |\n" +
                " _|\n",

                "|  \n" +
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
                "|_|\n"

            };

            AccountNumber accountNumber = new AccountNumber(testDigits.ToArray());

            Assert.AreEqual("-1-1-1-1-15678", accountNumber.ToString());
        }

    }
}