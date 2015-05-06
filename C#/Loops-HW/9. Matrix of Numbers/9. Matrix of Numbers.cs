

//Problem 9. Matrix of Numbers
//• Write a program that reads from the console a positive integer number 
//n  (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

//Examples:
//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7

using System;

class Matrix_of_Numbers
{
    static void Main()
    {
        //using a nested for loop
        uint n;
        Console.WriteLine("Enter an integer n (1 <= n <= 20): ");
        bool validN = uint.TryParse((Console.ReadLine()), out n);
        if (validN && 1 <= n && n <= 20)
        {
            Console.WriteLine("Et voila:");
            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 3}", row + col);
                }
                Console.WriteLine();
            }
        }
        else Console.WriteLine("You entered a wrong number.");

    }
}
