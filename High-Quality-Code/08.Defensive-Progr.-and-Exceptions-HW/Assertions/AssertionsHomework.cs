﻿using System;
using System.Linq;
using System.Diagnostics;

public class AssertionsHomework
{
    private static bool IsSorted<T>(T[] elements) where T : IComparable<T>
    {
        T current = elements.First();
        foreach (T item in elements.Skip(1))
        {
            if (current.CompareTo(item) > 0)
            {
                return false;
            }

            current = item;
        }

        return true;
    }

    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null && arr.Length > 0, "Empty or non-initialised array in method call");
        Debug.Assert(arr.Length > 1, "Array has one element; no need to be sorted.");
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(startIndex < endIndex);
        Debug.Assert(arr.Length > endIndex);
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null && arr.Length > 0, "Empty or non-initialised array in method call");
        Debug.Assert(value != null, "Value is null");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null || arr.Length > 0, "Empty or non-initialised array in method call");
        Debug.Assert(value != null, "Value is null");
        Debug.Assert(startIndex >= 0 || endIndex <= arr.Length, "Index out of array boundaries");
        Debug.Assert(startIndex < endIndex, "Start index should be smaller than end index");
        bool isSorted = IsSorted(arr);
        Debug.Assert(isSorted, "The array is not sorted!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }
        // Assert our search algorithm did well
        Debug.Assert(!arr.Contains(value), String.Format("Array does contain {0}!", value));

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}