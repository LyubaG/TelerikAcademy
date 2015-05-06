//Problem 2. Get largest number
//    Write a method GetMax() with two parameters that returns the larger of two integers.
//    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;

class GetMaxMethod
{
    static void Main()
    {
        int[] threeNums = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter integer number {0}: ", i + 1);
            threeNums[i] = int.Parse(Console.ReadLine());
        }
        int tempMax = GetMax(threeNums[0], threeNums[1]);
        Console.WriteLine("The biggest of the three is " + GetMax(threeNums[2], tempMax));
    }

    static int GetMax(int num1, int num2)
    {
        int result = Math.Max(num1, num2);
        return result;
    }
}
