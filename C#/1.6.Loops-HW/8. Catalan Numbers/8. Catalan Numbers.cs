//Problem 8. Catalan Numbers•
//In combinatorics, the Catalan numbers are calculated by the following formula: (2*n)!/((n + 1)!* n!)
//• Write a program to calculate the  nth  Catalan number by given  n  (1 < n < 100). 

//Examples:
//n   Catalan(n)
//0   1 
//5   42 
//10  16796 
//15  9694845 

using System;
using System.Numerics;

class Catalan_Numbers
{
    static void Main()
    {
        //Note: n>0, so example 1 is wrong!
        int n;
        Console.WriteLine("Enter n (1 < n < 100): ");
        bool validN = int.TryParse((Console.ReadLine()), out n);
        BigInteger factorialTop = 1;
        BigInteger factorialBottom = 1;
        if (validN && 1 < n && n < 100)
        {
            for (int i = n + 1; i <=  2*n; i++)
                factorialTop *= i;

            for (int j = 1; j <= n + 1; j++)
                factorialBottom *= j;

            Console.WriteLine("The Nth Catalan number is {0}. Wow!", factorialTop / factorialBottom);
        }
        else Console.WriteLine("Invalid entry. Console very, very sad.");
 
    }
}
