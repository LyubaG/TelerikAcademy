//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;
using System.Globalization;
using System.Threading;

class NumbersNSum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n;
        double sum = 0;
        Console.Write("How many numbers do you want to enter? ");

        while (!(int.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("You can't have that. Try again: ");
        }
        Console.WriteLine();
        Console.WriteLine("Go ahead:");
        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is {0}.", sum);

    }
}