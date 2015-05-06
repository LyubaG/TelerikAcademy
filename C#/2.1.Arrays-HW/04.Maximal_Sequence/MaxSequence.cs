//Problem 4. Maximal sequence
//    Write a program that finds the maximal sequence of equal elements in an array.
//Example:
//input 	                    result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	2, 2, 2

using System;
using System.Linq;

class MaxSequence
{
    static void Main()
    {
        Console.WriteLine("Enter your array's elements, separated by a comma:");
        string input = Console.ReadLine();
        //for testing:
        //string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        //string input = "2, 5, 6, 8, 8, 8, 12, 12, 12, 12, 3, 4, 5, 6, 0";

        string[] elementsString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = elementsString.Length;
        int[] elements = new int[n];
        for (int i = 0; i < n; i++)
        {
            elements[i] = int.Parse(elementsString[i]);
        }
        ////Another, quicker option (we need using System.Linq;):
        //int[] elements = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        //int n = elements.Length;

        //calculations
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

        //output
        for (int w = 0; w <= countStored; w++)
        {
            Console.Write("{0}   ", repElementStored);
        }
        Console.WriteLine();
    }
}

