    //Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
    //Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

namespace _07.Replace_Sub_String
{
    class ReplaceStringInFile
    {
        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader("../../input.txt"))
            using (StreamWriter output = new StreamWriter("../../output.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                    output.WriteLine(line.Replace("start", "finish"));                     
        }
    }
}
