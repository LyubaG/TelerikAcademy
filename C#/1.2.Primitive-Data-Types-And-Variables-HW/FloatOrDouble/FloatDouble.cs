/*
Problem 2. Float or Double?
Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/

using System;

class FloatDouble
{
    static void Main()
    {
        float age = 12.345f;
        float seconds = 3456.091f;
        double adultAge = 34.567839023;
        double minutes = 8923.1234857;
        Console.WriteLine("My numbers are {0}, {1} (floats), {2} and {3} (doubles). Yay!", age, seconds, adultAge, minutes);
        //Note for self: minutes can't be float because precision digits include those to the left of the point, too.
    }
}

