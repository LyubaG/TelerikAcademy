//Problem 9. Frequent number
//    Write a program that finds the most frequent number in an array.
//Example:
//input 	                                result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)

using System;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        //read input
        Console.WriteLine("Enter your array's elements, separated by a comma:");
        int[] elements = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).
                                            Select(x => int.Parse(x)).ToArray();
        //for testing
        //int[] elements = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //int[] elements = new int[] { 3, 2, 2, 2, 3, 4, 5, 11, 14, 6, 2, 2, 4 };
 
        int n = elements.Length;

        //calculations
        Array.Sort(elements);
        int countSequence = 0;
        int repElement = 0, countStored = 0, repElementStored = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (elements[i] == elements[i + 1])
            {
                countSequence++;
                repElement = elements[i];
            }
            else if (countSequence >= countStored)
            {
                countStored = countSequence;
                repElementStored = repElement;
                countSequence = 0;
            }
            else
                continue;
        }

        Console.WriteLine("Most frequent number: " + repElementStored + "  (repeated {0} times)", (countStored + 1));

    }
}
