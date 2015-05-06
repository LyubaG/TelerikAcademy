//Problem 4. Sub-string in text
//    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is 'in'
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9

using System;
using System.Collections.Generic;
using System.Linq;

class SubstringCount
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        int currentIndex = 0;
        int count = 0;
        while (currentIndex < text.Length -1)
        {
            int occurrence = text.IndexOf("in", currentIndex);
            if (occurrence < 0)
            {
                break;
            }
            currentIndex = occurrence + 1; // +2 also works
            count++;
        }
        Console.WriteLine(count);
    }
}
