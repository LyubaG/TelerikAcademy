//Problem 2. Reverse string
//    Write a program that reads a string, reverses it and prints the result at the console.
//Example:
//input 	output
//sample 	elpmas

using System;
using System.Collections.Generic;
using System.Linq;

class StringReversal
{
    static void Main()
    {
        Console.WriteLine("Enter string:");
        string input = Console.ReadLine();
        char[] outputArr = new char[input.Length];
        for (int i = input.Length - 1, j = 0; i >= 0; i--, j++)
        {
            outputArr[j] = input[i];
        }
        string output = string.Join("", outputArr);
        Console.WriteLine(output);
    }
}

////shorter version, but doesn't exactly reverse the string
//char[] str = Console.ReadLine().ToCharArray();
//Array.Reverse(str);
//Console.WriteLine(str);