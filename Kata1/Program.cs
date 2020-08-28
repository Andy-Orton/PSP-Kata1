using System;
using System.Collections.Generic;

namespace Kata1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void stringToMatrix(List<string> lines)
        {
            Boolean[,,] characters = new Boolean[3, 3, 9];

            for (int entry = 0; entry < 27; ++entry)
            {
                for (int line = 0; line < 3; ++line)
                {
                    for (int character = 0; character < 3; ++character)
                    {
                        characters[entry, line, character] = !lines[character][entry].Equals(" ");
                    }
                }

            }
        }
    }

}
            