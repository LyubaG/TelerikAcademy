//Problem 3. Sequence n matrix
//    We are given a matrix of strings of size N x stringMatrix. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//    Write a program that finds the longest sequence of equal strings in the matrix.
//Example:
//matrix 	                result 		
//ha 	fifi 	ho 	hi
//fo 	ha 	hi 	xx
//xxx 	ho 	ha 	xx
//                       ha, ha, ha 		
//s 	qq 	s
//pp 	pp 	s
//pp 	qq 	s
//                         s, s, s

using System;

class StringSequenceInMatrix
{
    static void Main()
    {
        //test 1:
        string[,] stringMatrix = {{"ha", "fifi","ho", "hi"},
                                    {"fo", "ha","hi", "xx"},
                                    {"xxx", "ho","ha", "xx"} };
        //test 2:
        //string[,] stringMatrix = {
        // {"s", "qq", "s", "r"},
        // {"pp", "pp", "s", "z"},
        // {"pp", "qq", "s", "pp"} };

        int sequenceCount = 0;
        int currentRow = 0;
        int currentCol = 0;
        int currentDiag = 0;
        int temp = 0;
        string commonString = string.Empty;
        for (int rows = 0; rows < stringMatrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < stringMatrix.GetLength(1); cols++)
            {
                string currentString = stringMatrix[rows, cols];
                currentRow = FindSequence(stringMatrix, rows, cols, 0);
                currentDiag = FindSequence(stringMatrix, rows, cols, 1);
                currentCol = FindSequence(stringMatrix, rows, cols, 2);
                temp = Math.Max(Math.Max(currentRow, currentCol), currentDiag);
                if (temp > sequenceCount)
                {
                    sequenceCount = temp;
                    commonString = currentString;
                }
            }
            if (sequenceCount == stringMatrix.GetLength(0))
            {
                break;
            }
        }
        //print
        Console.WriteLine("The longest sequence of equal strings is:");
        for (int i = 0; i < sequenceCount; i++)
        {
            Console.Write(commonString + "  ");
        }
        Console.WriteLine();
    }

    static int FindSequence(string[,] stringMatrix, int startRow, int startCol, int direction)
    {
        int count = -1;
        //check row
        if (direction == 0)
        {
            count = 1;
            for (int i = startCol + 1; i < stringMatrix.GetLength(1); i++)
            {
                if (stringMatrix[startRow, i] == stringMatrix[startRow, startCol])
                {
                    count++;
                }
            }
        }
        //check diagonal
        else if (direction == 1)
        {
            count = 1;
            int diagonalSize = (stringMatrix.GetLength(0) < stringMatrix.GetLength(1)) ? stringMatrix.GetLength(0) : stringMatrix.GetLength(1);
            for (int i = startCol + 1; i < diagonalSize; i++)
            {
                if (stringMatrix[i, i] == stringMatrix[startRow, startCol])
                {
                    count++;
                }
            }
        }
        //check column
        else if (direction == 2)
        {
            count = 1;
            for (int rows = startRow + 1; rows < stringMatrix.GetLength(0); rows++)
            {
                if (stringMatrix[rows, startCol] == stringMatrix[startRow, startCol])
                {
                    count++;
                }
            }
        }
        return count;
    }
}

