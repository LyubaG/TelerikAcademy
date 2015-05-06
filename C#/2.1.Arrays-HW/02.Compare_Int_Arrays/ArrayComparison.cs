//Problem 2. Compare arrays
//    Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class ArrayComparison
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements in first array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        Console.WriteLine("Enter each element on a new line: ");
        for (int i = 0; i < n; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter number of elements in second array: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] array2 = new int[n2];
        Console.WriteLine("Enter each element on a new line: ");
        for (int i = 0; i < n2; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }
        //for testing:
        //int[] array1 = new int[] { 1, 2, 3, 4, 5, 6 };
        //int[] array2 = new int[] { 1, 2, 3, -3, 8, 6 };
        //
        //int[] array1 = new int[] { 1, 2, 3};
        //int[] array2 = new int[] { 1, 2};

        bool equal = true;
        if (array1.Length != array2.Length) equal = false;
        else
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    equal = false;
                    break;
                }
            }
        }
        Console.WriteLine("The arrays are equal --> " + equal);
    }
}

