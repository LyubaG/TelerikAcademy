//Problem 6. String length
//    Write a program that reads from the console a string of maximum 20 characters. 
//    If the length of the string is less than 20, the rest of the characters should be filled with *.
//    Print the result string into the console.

using System;
using System.Text;

class AppendString
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        if (text.Length >= 20)
        {
            Console.WriteLine(text.Substring(0, 20));
            Console.WriteLine();
        }
        else
        {
            var finalText = new StringBuilder();
            finalText.Append(text);
            for (int i = text.Length + 1; i <= 20; i++)
            {
                finalText.Append('*');
            }
            Console.WriteLine(finalText);
            Console.WriteLine();
        }
    }
}
