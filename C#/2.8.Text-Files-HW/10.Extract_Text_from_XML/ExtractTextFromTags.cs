//    Write a program that extracts from given XML file all the text without the tags.

//Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

using System;
using System.IO;

namespace _10.Extract_Text_from_XML
{
    class ExtractTextFromTags
    {
        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader("../../input.txt"))
            {
                for (int i; (i = input.Read()) != -1; ) // Read char by char
                {
                    if (i == '>') 
                    {
                        string text = String.Empty;
                        while ((i = input.Read()) != -1 && i != '<')
                        {
                            text += (char)i;
                        }
                        if (!String.IsNullOrWhiteSpace(text)) Console.WriteLine(text.Trim());
                    }
                }
            }
        }
    }
}
