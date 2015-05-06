//Problem 6. The Biggest of Five Numbers
//• Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Globalization;
using System.Threading;

class The_Biggest_of_Five_Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("You'll have to enter 5 numbers.");
        double[] numbers = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter a number {0}: ", i + 1);
            while (!(double.TryParse(Console.ReadLine(), out numbers[i])))
            {
                Console.WriteLine("Not a number. Try again: ");
            }
        }
        double biggest = numbers[0];
        for (int count = 0; count < 5; count++)
        {
            if (numbers[count] > biggest)
            {
                biggest = numbers[count];
            }
        }
        Console.WriteLine("The biggest number is {0}.", biggest);


    }
}


//Option with more 'If's:
//if (a >= b && a >= c && a >= d && a >= e)
//{
//Console.WriteLine("Biggest :" + a);
//}
//else if (a <= b && b >= c && b >= d && b >= e)
//{
//Console.WriteLine("Biggest :" + b);
//}
//else if (c >= a && b <= c && c >= d && c >= e)
//{
//Console.WriteLine("Biggest :" + c);
//}
//else if (d >= a && d >= b && d >= c && d >= e)
//{
//Console.WriteLine("Biggest :" + d);
//}
//else if (e >= a && e >= b && e >= c && e >= d)
//{
//Console.WriteLine("Biggest :" + e);
//}