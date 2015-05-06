//Problem 7. Selection sort
//    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
//    smallest from the rest, move it at the second position, etc.
//NOTE: it's a very slow algorithm

using System;
using System.Linq;

class AlgorithmSelectionSort
{
    static void Main(string[] args)
    {
        //pick an array for testing:
        //int[] arr = new int[] { 1, 1, 1, 4, 4, 4, 5, 6, 7, 12, 43, 32, 78 };
        //int[] arr = new int[] { 3, 2, 3, 4, 5, 6, 2, 2, 4 };
       int[] arr = new int[] { 12, 11, 9, 8, 0, -9, 13, -54 };

        int minValue;
        int minIndex = -1;
        for (int i = 0; i < arr.Length-1; i++)
        {
            minValue = int.MaxValue;
            minIndex = i;
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[minIndex] > arr[j])
                {
                    minValue = arr[j];
                    minIndex = j;
                }
            }
            int temp = arr[i];
            arr[i] = minValue;
            arr[minIndex] = temp;
        }

        Console.WriteLine(String.Join("  ", arr));

    }
}

