//Problem 3. Min, Max, Sum and Average of N Numbers
//• Write a program that reads from the console a sequence of  n  integer numbers and returns 
//the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//• The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
//• The output is like in the examples below.

//Example 1:
//input       output
//3           min = 1 
//2           max = 5 
//5           sum = 8 
//1           avg = 2.67 

//Example 2:
//input       output
//2           min = -1 
//-1          max = 4 
//4           sum = 3 
//            avg = 1.50 

using System;

class Min_Max_Sum_and_Average_of_N_Numbers
{
    static void Main()
    {
        // divide by 1000 etc
        Console.WriteLine("How many numbers will you enter?");
        uint n = uint.Parse(Console.ReadLine());
        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        Console.WriteLine("Enter each one on a separate line:");
        int i = 1;
        while (i <= n)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number >= max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            i++;
        }
        decimal average = (decimal)sum / n;
        Console.WriteLine("Minimal: {0}, Maximal: {1}, Sum: {2}, Average: {3:0.00}", min, max, sum, average);
        Console.WriteLine();




    }
}

