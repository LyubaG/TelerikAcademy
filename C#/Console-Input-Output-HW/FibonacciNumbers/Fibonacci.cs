//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

using System;
using System.Globalization;
using System.Threading;

class Fibonacci
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.ForegroundColor = ConsoleColor.Green;
        int n;
        Console.Write("How many Fibonacci numbers do you want to see? ");
        while (!(int.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("You can't have that. Try again: ");
        }
        Console.WriteLine();
        Console.WriteLine("Et voila:");
        int fib1 = 0;
        int fib2 = 1;
        int fibTotal;
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}, ", fib1);
            fibTotal = fib1 + fib2;
            fib1 = fib2;
            fib2 = fibTotal;
        }
        Console.ReadLine();
    }
}