//    Write a program that reads a text file containing a square matrix of numbers.
//    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//        The first line in the input file contains the size of matrix N.
//        Each of the next N lines contain N numbers separated by space.
//        The output should be a single number in a separate text file.

//Example:
//input 	output
//4
//2 3 3 4
//0 2 3 4
//3 7 1 2
//4 3 3 2 	17

using System;
using System.IO;


class GetMatrixFromFile
{
    static int[,] ReadMatrix()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            int n = int.Parse(input.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = input.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
matrix[i, j] = int.Parse(numbers[j]);
                }
                    
            }
            return matrix;
        }
    }
    static int GetMax(int[,] matrix)
    {
        int maxSum = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                maxSum = Math.Max(maxSum, matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1]);
        return maxSum;
    }
    static void WriteResult(int maxSum)
    {
        using (StreamWriter output = new StreamWriter("../../output.txt"))
            output.WriteLine(maxSum);
    }
    static void Main()
    {
        WriteResult(GetMax(ReadMatrix()));
    }
    //to test, delete the result from the output file
}
