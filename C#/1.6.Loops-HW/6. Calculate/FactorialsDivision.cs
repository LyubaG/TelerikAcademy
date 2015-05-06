//Problem 6. Calculate N! / K!
//• Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
//• Use only one loop.

//Examples:
//n       k       n! / k!
//5       2       60 
//6       5       6 
//8       3       6720 

using System;
using System.Numerics;

class FactorialsDivision
{
    static void Main()
    {
        int n, k;
        Console.WriteLine("Enter n (1 < n < 100): ");
        bool validN = int.TryParse((Console.ReadLine()), out n);
        Console.WriteLine("Enter k (1 < k < n): ");
        bool validX = int.TryParse((Console.ReadLine()), out k);
        BigInteger factorialResult = 1;
        if (validN && validX && 1 < k && n > k && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
            {
                factorialResult *= i;
            }
            Console.WriteLine("Result: {0}", factorialResult);
        }
        else Console.WriteLine("Invalid entry. Console sad.");
    }
}
