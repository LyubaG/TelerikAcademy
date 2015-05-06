//Problem 4. Appearance count
//    Write a method that counts how many times given number appears in given array.
//    Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;
using System.Linq;

class ElementRepeatCount
{
    static void Main()
    {
        //reading input:
        //Console.Write("How long's the array? -->");
        //int arrLength = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the elements in a single line, separated with a space:");
        //int[] funArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
        //                             Select(x => int.Parse(x)).ToArray();
        //Console.WriteLine("Element you're searching for:");
        //int n = int.Parse(Console.ReadLine());

        //test (change n if you want):
        int[] funArray = { 12, 3, 4, 5, 6, 3, 4, 8, 9, 0, 11, 12, 15, 6, 7, 8, 7, 7, 3, 4, 0, 3 };
        int n = 3;
        Console.WriteLine("{0} is present in the array {1} times. Yay!", n, ElementCount(funArray, n));
    }

    private static int ElementCount(int[] array, int element)
    {
        int endCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
            {
                endCount++;
            }
        }
        return endCount;
    }
}
