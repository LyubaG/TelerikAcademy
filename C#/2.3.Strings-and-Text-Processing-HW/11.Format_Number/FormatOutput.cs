//Problem 11. Format number
//    Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//    Format the output aligned right in 15 symbols.

using System;

class FormatOutput
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine("{0,15}", num); // Decimal
        Console.WriteLine("{0,15:X}", (int)num); // Hexadecimal
        Console.WriteLine("{0,15:P}", num/100); // Percentage
        Console.WriteLine("{0,15:E}", num); // Scientific notation
    }
}
