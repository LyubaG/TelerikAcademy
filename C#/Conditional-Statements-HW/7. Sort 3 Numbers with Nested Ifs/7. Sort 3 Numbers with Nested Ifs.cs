//Problem 7. Sort 3 Numbers with Nested Ifs
//• Write a program that enters 3 real numbers and prints them sorted in descending order. ◦ Use nested  if  statements.
//Note: Don’t use arrays and the built-in sorting functionality.
//Examples:
//a       b       c       result
//5       1       2       5 2 1 
//-2      -2      1       1 -2 -2 
//-2      4       3       4 3 -2 
//0       -2.5    5       5 0 -2.5 
//-1.1    -0.5    -0.1    -0.1 -0.5 -1.1 
//10      20      30      30 20 10 
//1       1       1       1 1 1 

using System;
using System.Globalization;
using System.Threading;

class Sort_3_Numbers_with_Nested_Ifs
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a, b, c;
        Console.WriteLine("Enter a: ");
        while (!(double.TryParse(Console.ReadLine(), out a)))
        {
            Console.WriteLine("Oh come on, dear: ");
        }
        Console.WriteLine("Enter b: ");
        while (!(double.TryParse(Console.ReadLine(), out b)))
        {
            Console.WriteLine(":( I asked for a number: ");
        }
        Console.WriteLine("Enter c: ");
        while (!(double.TryParse(Console.ReadLine(), out c)))
        {
            Console.WriteLine("Whaaa! Do it again: ");
        }
        Console.WriteLine("Now enjoy your numbers sorted by my humble persona:");

        if (a > b)
        {
            if (a > c)
            {
                if (b >= c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else
        {
            if (a > c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
        }
    }
}

