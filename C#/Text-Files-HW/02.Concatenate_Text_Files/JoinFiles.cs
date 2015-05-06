//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class JoinFiles
{
    static void WriteToFile(StreamWriter finalFile, string text)
    {
        using (StreamReader input = new StreamReader(text))
            for (string line; (line = input.ReadLine()) != null; )
                finalFile.WriteLine(line);
    }
    static void Main()
    {
        string[] files = { "../../JoinFiles.cs", "../../newfile.txt" };
        using (StreamWriter output = new StreamWriter("../../output.txt"))
            foreach (string file in files)
            {
                WriteToFile(output, file);
            }
        Console.WriteLine("Done! Check the file :)");
    }
}
