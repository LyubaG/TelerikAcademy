//Problem 22. Words count
//    Write a program that reads a string from the console and lists all different words in the string along 
//with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class CountWordsThenOrder
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        //test "...in different letters in the string and with information how many different times each letter is found"
        string input = Console.ReadLine().ToLower();
        var wordStack = new Dictionary<string, int>();
        foreach (Match word in Regex.Matches(input, @"\w+")) //finds words
        {
            if (!wordStack.ContainsKey(word.Value))
            {
                wordStack.Add(word.Value, 1);
            }
            else if (wordStack.ContainsKey(word.Value))
            {
                wordStack[word.Value]++;
            }
        }
        foreach (var word in wordStack.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
        {
            Console.WriteLine("{0,-15} --> {1} time(s)", word.Key, word.Value);
        }
    }
}
