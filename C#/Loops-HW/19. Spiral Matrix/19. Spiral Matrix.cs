//Problem 19.** Spiral Matrix
//• Write a program that reads from the console a positive integer number 
//n  (1 = n = 20) and prints a matrix holding the numbers from  1  to  n*n
//in the form of square spiral like in the examples below.

//Examples:
//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1  2  3  4
//        4 3                 8 9 4               12 13 14 5
//                            7 6 5               11 16 15 6
//                                                10 9  8  7

using System;

class Spiral_Matrix
{
    static void Main()
    {
        uint n;
        Console.Write("Enter an integer n (1 <= n <= 20): ");
        bool validN = uint.TryParse((Console.ReadLine()), out n);
        if (validN && 1 <= n && n <= 20)
        {
            Console.WriteLine("\nTa-daaaaa!");
            Console.WriteLine();
            int[,] matrix = new int[n, n]; //2d matrix
            int row = 0;
            int col = 0;
            uint maxValue = n * n;
            string direction = "right";

            for (int i = 1; i <= maxValue; i++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0)) //!= 0 to check if there's already a number there, so we don't overwrite it
                {
                    direction = "down"; //when you finish with rightwards direction -> next is down, etc.
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            //print the matrix
            Console.ForegroundColor = ConsoleColor.Green;
            for (int rowCount = 0; rowCount < n; rowCount++)
            {
                for (int colCount = 0; colCount < n; colCount++)
                {
                    Console.Write("{0, 3}", matrix[rowCount, colCount]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //for (uint i = (n*n)-1, j = 0, index = n * n; i > 0; i--, j++) {
            //      for (uint k = j; k < i; k++) curentValue = index--;
            //      for (uint k = j; k < i; k++) curentValue = index--;
            //      for (uint k = i; k > j; k--) curentValue= index--;
            //      for (uint k = i; k > j; k--) {
            //      Console.Write("{0, 3}", j + i);}
            //}


            //            for (uint row = 0; row < n; row++)
            //            {
            //                for (uint col = 0; col < n; col++)
            //                {
            //            matrix[row,col] = (int)(1+ maxValue*row +col);       
            //Console.Write("{0, 3}", matrix[row, col]);
            //                }
            //                Console.WriteLine();
            //            }





        }
        else Console.WriteLine("You entered a wrong number.");

    }
}
