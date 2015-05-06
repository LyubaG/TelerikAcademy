//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class AssignNullVal
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Print attempt ::: First: {0}, Second: {1}.", nullInt, nullDouble);
        Console.WriteLine("Adding 12 and 5, respectively -->");
        nullInt = 12;
        nullDouble = 5;
        Console.WriteLine("First: {0}, Second: {1}.", nullInt, nullDouble);
    }
}