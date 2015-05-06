//Problem 8. Maximal sum
//    Write a program that finds the sequence of maximal sum in given array.
//  Example:
//  input 	                            result
//  2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4
//    Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaxSumInSequence
{
    static void Main()
    {
        //test:
        //int[] numbers = new int[] { 3, 2, -9, -5, 3, 4, 5, 6, -11, 11, 4 };
        int[] numbers = new int[] { 8, 14, 28, 135, -234, -300, 54, 65, 12, 24, 25, 7, 8, -9, 78, -89 };

        int maxSum = int.MinValue;
        int currentSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            currentSum += numbers[i];
            if (currentSum < 0)
            {
                currentSum = 0;
                startIndex = i + 1;
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                endIndex = i;
            }
        }
        Console.WriteLine("The sequence resulting in the maximal sum is:");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(numbers[i] + "  ");
        }
        Console.WriteLine("\nThe sum is: " + maxSum);
    }
}

