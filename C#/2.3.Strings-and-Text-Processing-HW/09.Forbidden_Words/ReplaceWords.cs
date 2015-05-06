//Problem 9. Forbidden words
//    We are given a string containing a list of forbidden words and a text containing some of these words.
//    Write a program that replaces the forbidden words with asterisks.
//Example text: 
//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 
//4.0 and is implemented as a dynamic language in ***.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReplaceWords
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter forbidden words list: ");
        string[] bannedList = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
        string finalText = string.Empty;
        foreach (var bannedWord in bannedList)
        {
            text = text.Replace(bannedWord, new String('*', bannedWord.Length));
        }
        Console.WriteLine(text);
    }
}
 
//Another approach is to use RegEx.Replace(…) with a suitable regular expression and a 
//suitable MatchEvaluator method.
