//Problem 3. English digit
//    Write a method that returns the last digit of given integer as an English word.
//Examples:
//input 	output
//512   	two
//1024  	four
//12309 	nine

using System;
using System.Collections.Generic;
using System.Linq;

class DigitToWord
{
    static void Main()
    {
        Console.WriteLine("Your integer:");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit is: " + DigitToWord(input));
    }

    static string DigitToWord(int num)
    {
        int lastDigit = num % 10;
        string result = string.Empty;
        switch (lastDigit)
        {
            case 1: result = "one";
                break;
            case 2: result = "two";
                break;
            case 3: result = "three";
                break;
            case 4: result = "four";
                break;
            case 5: result = "five";
                break;
            case 6: result = "six";
                break;
            case 7: result = "seven";
                break;
            case 8: result = "eight";
                break;
            case 9: result = "nine";
                break;
            case 0: result = "zero";
                break;
            default:
                break;
        }
        return result;
    }
}
