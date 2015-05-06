//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

namespace _03.Line_Numbers
{
    class InsertNumbers
    {
        static void Main(string[] args)
        {
            int n = 1;
            StreamReader input = new StreamReader("../../InsertNumbers.cs");
            StreamWriter output = new StreamWriter("../../output.txt");

            using (input)
            using (output)
            {
                for (string line; (line = input.ReadLine()) != null; n++)
                    output.WriteLine("{0}. {1}", n, line);
            }
            Console.WriteLine("Done! Check the file :)");
        }
    }
}
