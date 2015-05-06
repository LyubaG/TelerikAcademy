//Problem 16.* Subset with sum S
//    We are given an array of integers and a number S.
//    Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:
//input array 	            S 	result
//2, 1, 2, 4, 3, 5, 2, 6 	14 	yes

using System;

class FindSubsetForGivenSumInArray
{
    static void Main()
    {
        //Note: the task is to say yes or no, not to print all subsets, so I'm sticking to this.

        //test integer arrays:
        int[] numArray = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //int[] numArray = new int[] { 3, 2, 2, 2, 3, 4, 5, 11, 14, 6, 2, 2, 4 };
        //int[] numArray = new int[] { -13, 15, 18, -27, -13, -7, 11, 12, 11 };

        Console.WriteLine("Enter desired sum: ");
        int S = int.Parse(Console.ReadLine());

        int maxi = (int)Math.Pow(2, numArray.Length) - 1;
        bool hasSum = false;
        for (int i = 1; i <= maxi; i++)
        {
            int currentSum = 0;
            for (int j = 1; j <= numArray.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentSum += numArray[j - 1];
                }
            }
            if (currentSum == S)
            {
                hasSum = true;
            }
        }
        if (hasSum)
        {
            Console.WriteLine("The answer is yes.");
        }
        else
        {
            Console.WriteLine("Nonono...");
        }

    }
}

