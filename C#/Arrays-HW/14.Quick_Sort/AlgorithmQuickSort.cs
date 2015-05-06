//Problem 14. Quick sort
//    Write a program that sorts an array of integers using the Quick sort algorithm.

// :) Quicksort is a 'divide and conquer algorithm'. :)

using System;
using System.Collections.Generic;

class AlgorithmQuickSort
{
    static void Main()
    {
        List<int> intArray = new List<int>() { 3, 1, 5, 4, 8, 12, 2, 20, 0, -11 }; //it's easier to turn it into a list
        //another test:
        //List<int> intArray = new List<int>() { -9, 23, 45, -14, 0, 1, 2, 13, 37, 3, 4, 12, 11, 54, 0, 0, 11, 12 };

        List<int> sortedArray = QuickSort(intArray);

        for (int i = 0; i < sortedArray.Count; i++)
        {
            Console.Write(sortedArray[i] + " ");
        }
        Console.WriteLine();
    }

    static List<int> QuickSort(List<int> array)
    {
        if (array.Count <= 1)
        {
            return array;
        }

        int pivot = array[array.Count / 2];
        List<int> smallList = new List<int>(); //left side array
        List<int> bigList = new List<int>(); //right side array

        for (int i = 0; i < array.Count; i++)
        {
            if (i != (array.Count / 2))
            {
                if (array[i] <= pivot)
                {
                    smallList.Add(array[i]);
                }
                else
                {
                    bigList.Add(array[i]);
                }
            }
        }
        return ConcatenateArrays(QuickSort(smallList), pivot, QuickSort(bigList));
    }

    static List<int> ConcatenateArrays(List<int> less, int pivot, List<int> greater)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < less.Count; i++)
        {
            result.Add(less[i]);
        }

        result.Add(pivot);

        for (int i = 0; i < greater.Count; i++)
        {
            result.Add(greater[i]);
        }
        return result;
    }

    //Lovely implmentation without recursion: http://www.codeproject.com/Articles/29467/Quick-Sort-Without-Recursion

}

