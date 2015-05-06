//Problem 20. Palindromes
//    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text.RegularExpressions;

class PalindromesInText
{
    static void Main()
    {
        string text = "Let's try to extract all palindromes, e.g. ABBA, lamal, exe.";
        foreach (Match word in Regex.Matches(text, @"\w+")) //finds words
        {
            if (word.Length > 1 && PalindromeCheck(word.Value))
            {
                Console.WriteLine(word);
            }
        }
    }

    static bool PalindromeCheck(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
