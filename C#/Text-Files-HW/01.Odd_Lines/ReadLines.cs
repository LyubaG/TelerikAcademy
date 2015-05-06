//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;


class ReadLines
{
    static void Main()
    {
        int n = 1;
        using (StreamReader textFile = new StreamReader("../../ReadLines.cs"))
            for (string line; (line = textFile.ReadLine()) != null; n++)
                if (n % 2 == 1)
                {
                    Console.WriteLine(n + " -->  " + line);
                }


    }
}