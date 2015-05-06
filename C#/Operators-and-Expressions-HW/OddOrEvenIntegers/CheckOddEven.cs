//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.

using System;

class CheckOddEven
{
    static void Main()
    {
        Console.Write("Enter an integer:");
        int num = int.Parse(Console.ReadLine()); //Note to self: Console.Read doesn't work :( so user has to press Enter...
        bool even = (num % 2 == 0);
        Console.WriteLine("Your number is even? " + even);

        /*  Option 2:
        if (num % 2 == 0)
        {
            Console.WriteLine("Your number is even.");
        }
        else
        {
            Console.WriteLine("Your number is odd. Hooray!");
        }
        */
    }
}
