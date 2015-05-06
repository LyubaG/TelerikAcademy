//Problem 8. Numbers from 1 to n
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
//Note: You may need to use a for-loop.

using System;
using System.Globalization;
using System.Threading;

class NumbersUntilN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n;
        Console.Write("Enter an integer: ");
        while (!(int.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("Wiser you must be, says the master. Try again: ");
        }
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Hooray!");

    }
}
