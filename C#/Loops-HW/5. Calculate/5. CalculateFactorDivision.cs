//Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//• Write a program that, for a given two integer numbers  n  and  x ,
//calculates the sum  S = 1 + 1!/x + 2!/x2+ … + n!/xn .
//• Use only one loop. Print the result with  5  digits after the decimal point.

//Examples:
//n   x   S
//3   2   2.75000 
//4   3   2.07407 
//5   -4  0.75781 

using System;
using System.Numerics;

class CalculateFactorDivision
{
    static void Main()
    {
        decimal result = 1;
        uint n;
        int x;
        Console.WriteLine("Enter n:");
        bool validN = uint.TryParse((Console.ReadLine()), out n);
        Console.WriteLine("Enter x:");
        bool validX = int.TryParse((Console.ReadLine()), out x);
        long divider = 1;
        BigInteger factorial = 1;
        if (validN && validX)
        {
            for (uint i = 1; i <= n; i++)
            {
                factorial *= i;
                divider *= x;
                result += (decimal)factorial / divider;
            }
            Console.WriteLine("Result: {0 :F5}", result);
        }
        else Console.WriteLine("Invalid entry. Console sad.");

    }
}
