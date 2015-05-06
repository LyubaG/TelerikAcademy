//Problem 4. Binary search
//    Write a program, that reads from the console an array of N integers and an integer K, sorts 
//    the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;

class BinSearchMethod
{
    static void Main()
    {
        //Console.WriteLine("Enter array length N: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] intArray = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine("Please enter integer number {0}", i + 1);
        //    intArray[i] = int.Parse(Console.ReadLine());
        //}
        
        //test 1:
        int[] intArray = { -8, 1, 15, 2, 0, 64, 35, 11, -13, -2, -1, 7, 6, 6, 7 };
        //test 2:
        //int[] array = {8, 1, 0, 2, 3, 6, 6, 7};
        Console.WriteLine("Enter an integer K: ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(intArray);
        int searchedNumber = Array.BinarySearch(intArray, k);
        Console.WriteLine("The sorted array:");
        foreach (int number in intArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        if (searchedNumber < -1)    //if K is larger than max array element
        {
            Console.WriteLine("Largest number smaller than or equal to {0} is {1}", k, intArray[~searchedNumber - 1]);
        }
        else if (~searchedNumber == 0)
        {
            Console.WriteLine("All numbers are bigger than K, sorry...");
        }
        else
        {
            Console.WriteLine("Largest number smaller than or equal to {0} is {1}", k, intArray[searchedNumber]);
        }
    }
}

//easier option (mgiht take longer)
//while (Array.BinarySearch(intArray, k) < 0) k--;
//Console.WriteLine("Largest number smaller than or equal to  K is " + k);