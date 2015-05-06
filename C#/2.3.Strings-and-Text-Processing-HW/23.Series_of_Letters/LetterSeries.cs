//Problem 23. Series of letters
//    Write a program that reads a string from the console and replaces all series 
//of consecutive identical letters with a single one.
//Example:
//input 	                output
//aaaaabbbbbcdddeeeedssaa 	abcdedsa

using System;
using System.Linq;
using System.Text;

class LetterSeries
{
    static void Main()
    {
        //Console.Write("Enter a string: ");
        //string text = Console.ReadLine();
        string text = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder uniqueLetters = new StringBuilder();
        uniqueLetters.Append(text[0]);
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])
            {
                uniqueLetters.Append(text[i]);
            }
        }
        Console.WriteLine("Ta-daaaa! -> " + uniqueLetters);
        
        
    }
}
