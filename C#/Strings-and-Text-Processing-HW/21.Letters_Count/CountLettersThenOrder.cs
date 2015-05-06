//Problem 21. Letters count
//    Write a program that reads a string from the console and prints all different letters in the string along 
//with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Linq;

class CountLettersThenOrder
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        //test "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found"
        string input = Console.ReadLine().ToUpper();
        var letterStack = new Dictionary<char, int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (!letterStack.ContainsKey(input[i]) && char.IsLetter(input[i]))
            {
                letterStack.Add(input[i], 1);
            }
            else if (letterStack.ContainsKey(input[i]) && char.IsLetter(input[i]))
            {
                letterStack[input[i]]++;
            }
        }
        foreach (var letter in letterStack.OrderByDescending(i => i.Value).ThenBy(i=>i.Key))
        {
            Console.WriteLine("{0} is present {1} time(s)", letter.Key, letter.Value);
        }

    }
}
