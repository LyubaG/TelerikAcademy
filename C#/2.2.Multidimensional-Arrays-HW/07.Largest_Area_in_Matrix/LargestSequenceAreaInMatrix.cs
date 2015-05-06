//Problem 7.* Largest area in matrix
//    Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
//Example:
//matrix 	                result
//1 	3 	2 	2 	2 	4
//3 	3 	3 	2 	4 	4
//4 	3 	1 	2 	3 	3
//4 	3 	1 	3 	3 	1
//4 	3 	3 	3 	1 	1
//                            13

//Hint: you can use the algorithm Depth-first search or Breadth-first search.

using System;
using System.Collections.Generic;
using System.Linq;


class LargestSequenceAreaInMatrix
{
    static int[,] matrix;
    static int bestLength = 0, commonElement = 0;
    static int currentLength = 0, currentNumber = 0;
    static void Main()
    {
        matrix = new[,]
                        {{ 1, 3, 2, 2, 2, 4 },
                        { 3, 3, 3, 2, 4, 4 },
                        { 4, 3, 1, 2, 3, 3 },
                        { 4, 3, 1, 3, 3, 1 },
                        { 4, 3, 3, 3, 1, 1 }};
        PrintMatrix(matrix);
        FindLargestAreaLength(matrix);
    }
    static void FindLargestAreaLength(int[,] tempMatrix)
    {
        bestLength = 0;
        commonElement = 0;
        for (int row = 0; row < tempMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < tempMatrix.GetLength(1); col++)
            {
                currentNumber = tempMatrix[row, col];
                currentLength = 0;
                FindArea(row, col);
                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    commonElement = currentNumber;
                }
            }
        }
        Console.WriteLine("Largest area is composed of the number {0}, repeated {1} times.\n", commonElement, bestLength);
    }
    static void FindArea(int row, int col)
    {
        if (row < 0 || row >= matrix.GetLength(0) ||
        col < 0 || col >= matrix.GetLength(1) ||
        matrix[row, col] == 0) return;
        if (matrix[row, col] == currentNumber)
        {
            matrix[row, col] = 0;
            currentLength++;
            FindArea(row - 1, col);
            FindArea(row + 1, col);
            FindArea(row, col - 1);
            FindArea(row, col + 1);
        }
    }
    static void PrintMatrix(int[,] testMatrix)
    {
        Console.WriteLine("Input matrix ({0}x{1}):\n", testMatrix.GetLength(0), testMatrix.GetLength(1));
        for (int row = 0; row < testMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < testMatrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", testMatrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

//Shoutout to lnikod4s :)