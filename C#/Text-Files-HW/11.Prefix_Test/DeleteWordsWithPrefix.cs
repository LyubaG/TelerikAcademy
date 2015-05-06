    //Write a program that deletes from a text file all words that start with the prefix test.
    //Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


    class DeleteWordsWithPrefix
    {
        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader("../../input.txt"))
            using (StreamWriter output = new StreamWriter("../../output.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                    output.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
        }
    }
