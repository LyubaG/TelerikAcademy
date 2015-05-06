//Problem 10. Find sum in array
//    Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:
//array 	            S 	result
//4, 3, 1, 4, 2, 5, 8 	11 	4, 2, 5

using System;

class FindGivenSumInArray
{
    static void Main()
    {
        //test integer arrays:
        int[] numArray = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //int[] numArray = new int[] { 3, 2, 2, 2, 3, 4, 5, 11, 14, 6, 2, 2, 4 };
        //int[] numArray = new int[] { -13, 15, 18, -27, -13, -7, 11, 12, 11 };

        Console.WriteLine("Enter desired sum: ");
        int S = int.Parse(Console.ReadLine());

        int currSum = 0;
        int startIndex = 0;
        bool hasSum = false;
        Console.WriteLine("The following sequences result in this sum: ");
        for (int i = 0; i < numArray.Length - 1; i++)
        {
            currSum += numArray[i];
            startIndex = i;

            for (int j = i + 1; j < numArray.Length; j++)
            {
                currSum += numArray[j];
                if (currSum == S)
                {
                    for (int k = startIndex; k <= j; k++)
                    {
                        Console.Write("{0}  ", numArray[k]);
                    }
                    Console.WriteLine();
                    hasSum = true;
                    break;
                }
            }
            currSum = 0;
        }

        if (hasSum == false)
        {
            Console.WriteLine("None, sorry.");
        }
    }
}

