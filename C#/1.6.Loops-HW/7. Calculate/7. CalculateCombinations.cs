//Problem 7. Calculate N! / (K! * (N-K)!)
//• In combinatorics, the number of ways to choose  k  different members out 
//of a group of  n  different elements (also known as the number of combinations)
//is calculated by the following formula: "https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png"
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck 
//of 52 cards.• Your task is to write a program that calculates  n! / (k! * (n-k)!)
//for given  n  and  k  (1 < k < n < 100). Try to use only two loops.

//Examples:
//n   k   n! / (k! * (n-k)!)
//3   2   3 
//4   2   6 
//10  6   210 
//52  5   2598960 

using System;
using System.Numerics;

class CalculateCombinations
{
    static void Main()
    {
        int n, k;
        Console.WriteLine("Enter n (1 < n < 100): ");
        bool validN = int.TryParse((Console.ReadLine()), out n);
        Console.WriteLine("Enter k (1 < k < n): ");
        bool validX = int.TryParse((Console.ReadLine()), out k);
        BigInteger factorialTop = 1;
        BigInteger factorialBottom = 1;
        if (validN && validX && 1 < k && n > k && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
                factorialTop *= i;

            for (int j = 1; j <= n - k; j++)
                factorialBottom *= j;

            Console.WriteLine("Result: {0}. Phew!", factorialTop / factorialBottom);
        }
        else Console.WriteLine("Invalid entry. Console sad.");
    }
}
