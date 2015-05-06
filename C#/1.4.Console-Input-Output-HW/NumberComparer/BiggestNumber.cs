//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
using System.Globalization;
using System.Threading;

class BiggestNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a, b;
        Console.WriteLine("Enter a number: ");
        if (double.TryParse(Console.ReadLine(), out a)) ;
        else Console.WriteLine("That's not a number. I'm not happy with you.");
        Console.WriteLine("And another: ");
        if (double.TryParse(Console.ReadLine(), out b)) ;
        else Console.WriteLine("That's not a number. I'm not happy with you.");
        //Note: this is extra, I'm not using 'if' to implement the solution but t check for correct input.
        double bigger = a > b ? a : b;
        string equalCheck = a == b ? "equal" : "different";
        Console.WriteLine("The biggest number is {0} (the two numbers are {1}). ", bigger, equalCheck);
    }
}

//Option using Math:  Math.Max(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine())));