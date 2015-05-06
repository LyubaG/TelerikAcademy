//Problem 2. Maximal sum
//    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;


class MaxSumPlatform
{
    static void Main()
    {
        //test1:
        int[,] matrix = { { 0, 2, 4, 0, 9, 5 },
                        { 7, 1, 3, 3, 2, 1 },
                        { 1, 3, 9, 8, 5, 6 },
                        { 4, 6, 7, 9, 1, 0}, 
                        {11,-9, 5, 14, -5, 2} };
        //test2:
        //int[,] matrix = { {7, 1, 3, 3, 2, 1},
        //                {1, 3, 9, 8, 5, 6},
        //                {4, 6, 7, 9, 1, 0} };


        int bestSum = int.MinValue;
        int bestSumRow = 0;
        int bestSumCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestSumRow = row;
                    bestSumCol = col;
                }
            }

        Console.WriteLine("Thw maximal sum is: {0}", bestSum);
        Console.WriteLine();
        Console.WriteLine("The max sum 3x3 platform is:");
        for (int rows = 0; rows < 3; rows++)
        {
            for (int cols = 0; cols < 3; cols++)
            {
                Console.Write("{0,3} ", matrix[bestSumRow + rows, bestSumCol + cols]);
            }
            Console.WriteLine();
        }

    }
}