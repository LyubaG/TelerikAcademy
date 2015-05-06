//Problem 13. Reverse sentence
//    Write a program that reverses the words in given sentence.
//Example:
//input 	                                output
//C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!

using System;
using System.Linq;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Enter sentence: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(new char[] { ' ', ',', '-', ':', ';', '?', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
        char[] nonPunctuation = sentence.Where(p => (!char.IsWhiteSpace(p) && !char.IsPunctuation(p)) || p.Equals('#')).ToArray();
        string[] separators = sentence.Split(nonPunctuation, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        var sentenceReversed = new StringBuilder();
        for (int i = 0; i < separators.Length; i++)
        {
            sentenceReversed.Append(words[i]);
            sentenceReversed.Append(separators[i]);
        }
        Console.WriteLine(sentenceReversed);
    }
}
