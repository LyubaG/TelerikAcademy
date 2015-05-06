//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.
//Example:
//input 	            result
//3, 2, 3, 4, 2, 2, 4 	2, 3, 4

using System;
using System.Linq;

class MaxIncreasingSequence
{
    static void Main()
    {
        //read input
        Console.WriteLine("Enter your array's elements, separated by a comma:");
        int[] elements = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).
                                            Select(x => int.Parse(x)).ToArray();
        int n = elements.Length;

        //for testing
        //int[] elements = new int[] { 3, 2, 3, 4, 5, 6, 2, 2, 4 };
        //int n = 9;
        //int[] elements = new int[] { 3, 2, 2, 2, 3, 4, 5, 11, 14, 6, 2, 2, 4 }; //to test increasing sequence even if sequence is not +1
        //int n = 13;

        //calculations
        int countSequence = 0;
        int[] sequenceArr = new int[n];
        int[] copiedSeq = (int[])sequenceArr.Clone();
        int countStored = 0;
        int i2 = 0;
        for (int i = 1; i < n; i++)
        {
            if (elements[i] > elements[i - 1])
            {
                countSequence++;
                sequenceArr[i2] = elements[i - 1];
                sequenceArr[i2 + 1] = elements[i];
                i2++;
            }
            else if (countSequence > countStored)
            {
                countStored = countSequence + 1;

                copiedSeq = (int[])sequenceArr.Clone();
                Array.Clear(sequenceArr, 0, n);
                countSequence = 0;
            }
            else
                continue;
        }

        //output
        for (int w = 0; w < countStored; w++)
        {
            Console.Write("{0}  ", copiedSeq[w]);
        }
        Console.WriteLine();
    }
}

