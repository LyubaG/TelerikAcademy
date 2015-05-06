//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Globalization;
using System.Threading;

class AddNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter a number: ");
        double a, b, c;
        if (double.TryParse(Console.ReadLine(), out a));
        else Console.WriteLine("That's not a number. I'm not happy with you.");
        Console.WriteLine("And another: ");
        if (double.TryParse(Console.ReadLine(), out b));
        else Console.WriteLine("That's not a number. I'm not happy with you.");
        Console.WriteLine("And another: ");
        if (double.TryParse(Console.ReadLine(), out c));
        else Console.WriteLine("That's not a number. I'm not happy with you.");
        Console.WriteLine("The sum of your numbers is " + (a + b + c));
    }
}
