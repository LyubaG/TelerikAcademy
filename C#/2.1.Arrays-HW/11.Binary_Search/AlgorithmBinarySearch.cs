//Problem 11. Binary search
//    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class AlgorithmBinarySearch
{
    static void Main()
    {

        //int[] array = { 3, 1, 5, 4, 8, 12, 2, 20 };
        int[] array = { -9, 23, 45, -14, 0, 1, 2, 13, 37, 3, 4, 12, 11, 54, 0, 0, 11, 12 };
        Array.Sort(array);
        
        Console.WriteLine("Number to find: ");
        int soughtNum = int.Parse(Console.ReadLine());
        int startIndex = 0, endIndex = array.Length;       //if it's array.Length -1, last number is not found
        while (startIndex <= endIndex)
        {
            int mid = (startIndex + endIndex) / 2;
            if (soughtNum == array[mid])
            {
                break;
            }
            else
            {
                if (soughtNum > array[mid])
                {
                    startIndex = mid;
                }
                else
                {
                    endIndex = mid;
                }
            }
        }
        int position = (startIndex + endIndex) / 2;
        Console.WriteLine("When the array is sorted, the number {0} is on position {1}.", array[position], position);
    }
}

