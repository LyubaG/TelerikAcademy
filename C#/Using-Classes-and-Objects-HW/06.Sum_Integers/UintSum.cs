//    You are given a sequence of positive integer values written into a string, separated by spaces.
//    Write a function that reads these values from given string and calculates their sum.
//Example:
//input           	output
//"43 68 9 23 318" 	461

using System;
using System.Collections.Generic;
using System.Linq;

class UintSum
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer string (int row separated by a space): ");
        string inputStr = Console.ReadLine();
        StringToInt.Addition(inputStr);
    }
}

class StringToInt
{
    static uint sum = 0;
    public static void Addition(string input)
    {
       try
       {
        uint[] integers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Where(a => a.Any()).Select(uint.Parse).ToArray();
        for (int i = 0; i < integers.Length; i++)
        {
            sum += integers[i];
        }
        Console.WriteLine("The sum of the integers is {0}.", sum);
       }
        catch (OverflowException)
       {
           Console.WriteLine("You entered negative numbers. Don't do that to me.");
       }

    }
}
