//Problem 6. Maximal K sum
//    Write a program that reads two integer numbers N and K and an array of N elements from the console.
//    Find in the array those K elements that have maximal sum.

using System;
using System.Linq;

class MaxKSum
{
    static void Main()
    {
        //input
        Console.WriteLine("Enter your array's elements, separated by a comma:");
        int[] elements = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).
                                            Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("Enter k:");
        int k = int.Parse(Console.ReadLine());

        //for testing
        //int[] elements = new int[] { 3, 2, 3, 4, 5, 6, 2, 2, 4 };
        //int k = 5;

        int sum = 0;
        int n = elements.Length;

        //calculations & output
        Array.Sort(elements);
        Console.WriteLine("The biggest k elements are:");
        for (int i = n - 1; i >= n - k; i--)
        {
            sum += elements[i];
            Console.Write("{0}, ", elements[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The sum of the biggest k number of elements is: {0}", sum);
        Console.WriteLine();
    }
}
