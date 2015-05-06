//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//    If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MethodException
{
    static int ReadNumber(int start, int end)
    {
        try
        {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        if (!(start < n && n < end)) throw new ArgumentOutOfRangeException();
        return n;
        }
        catch (FormatException)
        {
            Console.WriteLine("That's not a number, dear...");
            return 0;
        }
    }
    static void Main()
    {
        //to test:
        int min = 1, max = 100;
        for (int i = 0; i < 10; i++)
        {
            min = ReadNumber(min, max); //to make sure nums are in increasing sequence
        }
    }
}