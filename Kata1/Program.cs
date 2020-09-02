using System;
using System.Collections.Generic;
using System.IO;

namespace Kata1
{
    class Program
    {
       
        static void Main(string[] args)
        {

            List<string> lines = OcrFileReader.ReadFile();
            List<AccountNumber> acntNumbers =  OcrFileReader.ProcessRawAccountNumbers(lines);

            foreach (AccountNumber accountNumber in acntNumbers)
            {
                Console.Out.WriteLine(accountNumber.ToString());
            }
        }

           

    }

}
            