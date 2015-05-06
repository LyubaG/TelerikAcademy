using System;
using System.Collections.Generic;
using System.Text;

class Matrix
{
    private int[,] matrix;
    //constructor (not method) - initial values of the fields
    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }
    //properties
    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0); //no 'set', so user can't change the rows
        }
    }

    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }
    //indexers of matrix
    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }
    //operator +
    public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix result = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

        if (!(firstMatrix.Rows == secondMatrix.Rows && firstMatrix.Cols == secondMatrix.Cols))
        {
            Console.WriteLine("The matrices can't be added. You get an empty matrix as a present.");
        }
        else
        {
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    result[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
                }
            }

        }
        return result;
    }
    //operator -
    public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix result = new Matrix(firstMatrix.Rows, firstMatrix.Cols);
        if (!(firstMatrix.Rows == secondMatrix.Rows && firstMatrix.Cols == secondMatrix.Cols))
        {
            Console.WriteLine("The matrices can't be subtracted. You get an empty matrix as a present.");
        }
        else
        {
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    result[row, col] = firstMatrix[row, col] - secondMatrix[row, col];
                }
            }

        }
        return result;
    }
    //operator *
    public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix result = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

        if (firstMatrix.Cols != secondMatrix.Rows)
        {
            Console.WriteLine("The matrices can't be multiplied. You get an empty matrix as a present.");
        }
        else
        {
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    result[row, col] = firstMatrix[row, col] * secondMatrix[row, col];
                }
            }

        }
        return result;
    }
    //override ToString
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Cols; col++)
            {
                result.AppendFormat("{0,4}", matrix[row, col]);
                //I welcome ideas on how to format the output 
                //properly without using System.Text :)
            }
            result.AppendLine();
            //without System.Text: result += Environment.NewLine; // \r\n
        }
        return result.ToString();
    }

}
