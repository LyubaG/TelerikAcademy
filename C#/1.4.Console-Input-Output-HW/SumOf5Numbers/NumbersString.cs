//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Globalization;
using System.Threading;

class NumbersString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a row of 5 numbers and separate them with only a space: ");
        string numbersRow = Console.ReadLine();
        double sum = 0;
        string[] numberString = numbersRow.Split(' ');
        for (int i = 0; i < numberString.Length; i++) // i.e. for each part of the numberString array; also works with i<5 in this case
        {
            sum += double.Parse(numberString[i]);
        }

        Console.WriteLine("Their sum is " + sum);
    }
}