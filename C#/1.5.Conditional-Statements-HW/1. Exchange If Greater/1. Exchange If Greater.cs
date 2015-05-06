//Problem 1. Exchange If Greater
//• Write an if-statement that takes two double variables a and b and
//exchanges their values if the first one is greater than the second one.
//As a result print the values a and b, separated by a space.

//Examples:
//a       b       result
//5       2       2 5 
//3       4       3 4 
//5.5     4.5     4.5 5.5 

using System;
using System.Globalization;
using System.Threading;

class Exchange_If_Greater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a, b;
        Console.WriteLine("Enter a: ");
        while (!(double.TryParse(Console.ReadLine(), out a)))
        {
            Console.WriteLine("Follow the instructions, please...again: ");
        }
        Console.WriteLine("Enter b: ");
        while (!(double.TryParse(Console.ReadLine(), out b)))
        {
            Console.WriteLine("Follow the instructions...again: ");
        }
        if (a > b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine("Your result is (small value, big value): {0} {1}", a, b);

    }
}

