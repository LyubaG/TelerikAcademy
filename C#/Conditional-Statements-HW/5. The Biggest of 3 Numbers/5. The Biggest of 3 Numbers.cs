//Problem 5. The Biggest of 3 Numbers
//• Write a program that finds the biggest of three numbers.

//Examples:
//a       b       c       biggest
//5       2       2       5 
//-2      -2      1       1 
//-2      4       3       4 
//0       -2.5    5       5 
//-0.1    -0.5    -1.1    -0.1 

using System;
using System.Globalization;
using System.Threading;

class The_Biggest_of_3_Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a, b, c;
        Console.WriteLine("Enter a: ");
        while (!(double.TryParse(Console.ReadLine(), out a)))
        {
            Console.WriteLine("Follow the instructions, please...again: ");
        }
        Console.WriteLine("Enter b: ");
        while (!(double.TryParse(Console.ReadLine(), out b)))
        {
            Console.WriteLine("Oh man, I asked for a number: ");
        }
        Console.WriteLine("Enter c: ");
        while (!(double.TryParse(Console.ReadLine(), out c)))
        {
            Console.WriteLine("I'm not happy with you! Enter it now: ");
        }
        double biggest = 0;
        if (a >= b && a >= c) biggest = a;
        else if (a <= c && b <= c) biggest = c;
        else if (a <= b && b >= c) biggest = b;
        
        Console.WriteLine("The biggest number is {0}.", biggest);

       
    }
}

