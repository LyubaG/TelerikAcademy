//Problem 9. Sorting array
//    Write a method that return the maximal element in a portion of array of integers starting at given index.
//    Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;

class FindMaxElementAndSortArr
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array:");
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[n];
        //test:
        //int[] array = {12,-9,1,4,7,2,78,9,34,-120,5,9};
        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}] = ", i);
            intArray[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter index where to start the check: ");
        int givenIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("Maximal element in selected portion of the array: {0}", MaxElementInPortion(intArray, givenIndex));
       
        Console.WriteLine("Enter 1 if you want to sort the array in Ascending order: ");
        Console.WriteLine("Enter number 2 if you want to sort the array in Descending order: ");
        
        int sortingChoice = int.Parse(Console.ReadLine());
        if (sortingChoice == 1)
        {
            SortArrayAscending(intArray);
            PrintArray(intArray);
        }
        if (sortingChoice == 2)
        {
            SortArrayDescending(intArray);
            PrintArray(intArray);
        }
        else if (sortingChoice != 1 && sortingChoice != 2)
        {
            Console.WriteLine("Wrong input, dear...");
        }
    }


    static int MaxElementInPortion(int[] array, int startIndex)
    {
        int biggestIndex = startIndex;
        for (int i = startIndex; i < array.Length; i++)
        {
            if (array[startIndex] < array[i])
            {
                biggestIndex = i;
            }
        }
        return array[biggestIndex];
    }

    static void SortArrayAscending(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int elementMin = i;
            for (int p = i + 1; p < array.Length; p++)
            {
                if (array[p] < array[elementMin])
                {
                    elementMin = p;
                }
            }
            if (elementMin != i)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[elementMin];
                array[elementMin] = temp;
            }
        }
    }
    static void SortArrayDescending(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int elementMin = i;
            for (int p = i + 1; p < array.Length; p++)
            {
                if (array[p] < array[elementMin])
                {
                    elementMin = p;
                }
            }
            if (elementMin != i)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[elementMin];
                array[elementMin] = temp;
            }
        }
        Array.Reverse(array);
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}