//Problem 24. Order words
//    Write a program that reads a list of words, separated by spaces and prints 
//   the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter words, separated by a space: ");
        //test "in different letters in the string and with information how many"
        var input = Console.ReadLine().ToLower().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
        input.Reverse();
        foreach (var word in input.OrderBy(i => i))
        {
            Console.WriteLine(word);
        }
    }
}
