//Problem 6.* Matrix class
//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and 
//multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;
using System.Collections.Generic;

public class MatrixUI
{
    static void Main()
    {
        //feel free to change the matrix dimensions for testing
        Matrix matrix1 = new Matrix(2, 2);
        for (int rows = 0; rows < matrix1.Rows; rows++)
        {
            for (int cols = 0; cols < matrix1.Cols; cols++)
            {
                Console.Write("matrix1 [{0},{1}] = ", rows, cols);
                matrix1[rows, cols] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();

        Matrix matrix2 = new Matrix(2, 2);
        for (int rows = 0; rows < matrix2.Rows; rows++)
        {
            for (int cols = 0; cols < matrix2.Cols; cols++)
            {
                Console.Write("matrix1 [{0},{1}] = ", rows, cols);
                matrix2[rows, cols] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();

        Matrix sum = matrix1 + matrix2;
        Console.WriteLine("Sum:\n" + sum.ToString());
        Matrix difference = matrix1 - matrix2;
        Console.WriteLine("Difference:\n" + difference.ToString());
        Matrix product = matrix1 * matrix2;
        Console.WriteLine("Product:\n" + product.ToString());
    }
}