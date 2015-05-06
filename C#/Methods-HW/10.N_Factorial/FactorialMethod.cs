//Problem 10. N Factorial
//    Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;

class FactorialMethod
{
    static void Main()
    {
        int[] hundredNumbers = new int[100];
        for (int i = 1; i < 100; i++)
        {
            hundredNumbers[i] = i;
        }
        foreach (var item in hundredNumbers)
        {
            Console.WriteLine(CalcualteFactorial(hundredNumbers, item));
        }
    }
    
    static BigInteger CalcualteFactorial(int[] array, int n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result = result * array[i];
        }
        return result;
    }

    //note: depending on the console size, output might seem a bit strange
}