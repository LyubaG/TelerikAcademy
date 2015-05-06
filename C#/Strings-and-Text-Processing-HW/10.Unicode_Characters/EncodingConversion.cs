//Problem 10. Unicode characters
//    Write a program that converts a string to a sequence of C# Unicode character literals.
//    Use format strings.
//Example:
//input 	output
//Hi! 	\u0048\u0069\u0021

using System;
using System.Collections.Generic;
using System.Text;

class EncodingConversion
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        var finalText = new StringBuilder();
        foreach (var symbol in text)
        {
            finalText.Append(string.Format("\\u{0:X4}", (int)symbol));
        }
        Console.WriteLine(finalText);
    }
}
