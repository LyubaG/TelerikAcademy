//Problem 7. Reverse number
//    Write a method that reverses the digits of given decimal number.
//Example:
//input 	output
//256 	    652
//123.45 	54.321

using System;
using System.Collections.Generic;
using System.Linq;

class DecimalDigitReversal
{
    static void Main()
    {
        decimal input = decimal.Parse(Console.ReadLine());
        ReversedNumber(input);
    }

    private static void ReversedNumber(decimal input)
    {
        char[] tempArr = input.ToString().ToCharArray();
        char[] reversed = new char[tempArr.Length];
        for (int index = 0; index < tempArr.Length; index++)
        {
            reversed[tempArr.Length  - 1 - index] = tempArr[index];
        }
        Console.WriteLine("Reversed number:" + decimal.Parse(new string(reversed)));
    }
}
