//Problem 11.* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;
using System.Globalization;
using System.Threading;

class NumbersInInterval
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.ForegroundColor = ConsoleColor.Green;
        int a;
        Console.Write("Tell me an integer: ");
        while (!(int.TryParse(Console.ReadLine(), out a)))
        {
            Console.WriteLine("C'mon. Try again: ");
        }
        int b;
        Console.Write("Tell me another one: ");
        while (!(int.TryParse(Console.ReadLine(), out b)))
        {
            Console.WriteLine("Integer, I said. Try again: ");
        }
        Console.WriteLine();
        int bigN = Math.Max(a, b);
        int smallN = Math.Min(a, b);
        int count = 0;
        for (int i = smallN; i <= bigN; i++)
        {
            if (i % 5 == 0) count += 1;
        }
        Console.WriteLine("There are {0} numbers that are divisible by 5 without a remainder \nwithin your integers' interval.", count);
        Console.ReadLine();
    }
}