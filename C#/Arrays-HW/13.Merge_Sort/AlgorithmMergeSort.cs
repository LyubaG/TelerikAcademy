//Problem 13.* Merge sort
//    Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

class AlgorithmMergeSort
{
    static void Main()
    {
        //test:
        //int[] numArr = { 3, 1, 5, 4, 8, 12, 2, 20, 0, -11 };
        int[] numArr = {-9, 23, 45, -14, 0, 1, 2, 13, 37, 3, 4, 12, 11, 54, 0, 0, 11, 12 };
        numArr = MergeSort(numArr);
        Console.WriteLine(string.Join(", ", numArr)); //avoids the last comma :)
    }

    static int[] MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }
        int middle = arr.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[arr.Length - middle];
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < middle)
            {
                left[i] = arr[i];
            }
            else
            {
                right[i - middle] = arr[i];
            }
        }
        left = MergeSort(left);
        right = MergeSort(right);
        return Merge(left, right);
    }

    static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int i, j;
        for (i = 0, j = 0; i < left.Length && j < right.Length; )
        {
            if (left[i] < right[j])
            {
                result[i + j] = left[i];
                i++;
            }
            else
            {
                result[i + j] = right[j];
                j++;
            }
        }
        for (; i < left.Length; i++)
        {
            result[i + j] = left[i];
        }
        for (; j < right.Length; j++)
        {
            result[i + j] = right[j];
        }
        return result;
    }
}

