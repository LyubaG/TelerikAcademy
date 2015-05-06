//Problem 1. Fill the matrix
//    Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
//a) 	b) 	c) 	d)*
//1 	5 	9 	13
//2 	6 	10 	14
//3 	7 	11 	15
//4 	8 	12 	16

//1 	8 	9 	16
//2 	7 	10 	15
//3 	6 	11 	14
//4 	5 	12 	13

//7 	11 	14 	16
//4 	8 	12 	15
//2 	5 	9 	13
//1 	3 	6 	10

//1 	12 	11 	10
//2 	13 	16 	9
//3 	14 	15 	8
//4 	5 	6 	7

using System;

class MatrixFillPatterns
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int n;
        bool validN = int.TryParse((Console.ReadLine()), out n);
        while (!validN)
        {
            Console.WriteLine("Invalid entry. Get it right this time: ");
            validN = int.TryParse((Console.ReadLine()), out n);
        }
        int[,] intMatrix = new int[n, n];
        int sequence = 1;

        //pattern1
        for (int col = 0; col < intMatrix.GetLength(0); col++)
        {
            for (int row = 0; row < intMatrix.GetLength(1); row++)
            {
                intMatrix[row, col] = sequence;
                sequence++;
            }
        }
        Console.WriteLine("\n:::Downward Arrangement:::\n");
        PrintArray(intMatrix, n);
        sequence = 1;

        //pattern2
        for (int col = 0; col < intMatrix.GetLength(0); col++)
        {
            if (col % 2 == 0)
                for (int row = 0; row < intMatrix.GetLength(1); row++)
                {
                    intMatrix[row, col] = sequence;
                    sequence++;
                }
            else
            {
                for (int row = intMatrix.GetLength(1) - 1; row >= 0; row--)
                {
                    intMatrix[row, col] = sequence;
                    sequence++;
                }
            }
        }
        Console.WriteLine(":::Snake Matrix:::\n");
        PrintArray(intMatrix, n);
        sequence = 1;

        //pattern3
        int maxSequence = n * n;
        int currentRowCount = 1, currenColCount = 0;
        for (int row = intMatrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < intMatrix.GetLength(1); )
            {
                intMatrix[row, col] = sequence;

                if (row == intMatrix.GetLength(0) - 1 && col != intMatrix.GetLength(1) - 1)
                {
                    row -= currentRowCount;
                    currentRowCount++;
                    col -= currenColCount;
                    currenColCount++;
                }
                else if (row == intMatrix.GetLength(0) - 1 || col == intMatrix.GetLength(1) - 1)
                {
                    currenColCount--;
                    col -= currenColCount;
                    currentRowCount--;
                    row -= currentRowCount;
                }
                else
                {
                    row++;
                    col++;
                }
                sequence++;
                if (sequence == maxSequence)
                {
                    break;
                }
            }
        }
        Console.WriteLine(":::Stairs:::\n");
        PrintArray(intMatrix, n);

        //pattern4
        Array.Clear(intMatrix, 0, intMatrix.Length);
        int rowCount = -1, colCount = 0;
        string direction = "down";
        for (int i = 1; i <= intMatrix.GetLength(0) * intMatrix.GetLength(1); i++)
        {
            if (direction == "down")
            {
                if (intMatrix[++rowCount, colCount] == 0) intMatrix[rowCount, colCount] = i;
                if (!IsInsideMatrix(intMatrix, rowCount + 1, colCount)) direction = "right";
            }
            else if (direction == "right")
            {
                if (intMatrix[rowCount, ++colCount] == 0) intMatrix[rowCount, colCount] = i;
                if (!IsInsideMatrix(intMatrix, rowCount, colCount + 1)) direction = "up";
            }
            else if (direction == "up")
            {
                if (intMatrix[--rowCount, colCount] == 0) intMatrix[rowCount, colCount] = i;
                if (!IsInsideMatrix(intMatrix, rowCount - 1, colCount)) direction = "left";
            }
            else if (direction == "left")
            {
                if (intMatrix[rowCount, --colCount] == 0) intMatrix[rowCount, colCount] = i;
                if (!IsInsideMatrix(intMatrix, rowCount, colCount - 1)) direction = "down";
            }
        }
        Console.WriteLine("\n:::Spiral:::\n");
        PrintArray(intMatrix, n);
    }

    static bool IsInsideMatrix(int[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLongLength(0) &&
 col >= 0 && col < matrix.GetLongLength(1) && matrix[row, col] == 0;
    }

    private static void PrintArray(int[,] matrix, int n)
    {
        for (int rowCount = 0; rowCount < n; rowCount++)
        {
            for (int colCount = 0; colCount < n; colCount++)
            {
                Console.Write("{0, 5}", matrix[rowCount, colCount]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
