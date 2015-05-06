//    Write a program that reads a year from the console and checks whether it is a leap one.
//    Use System.DateTime.

using System;

class DateTimeLeapCheck
{
    static void Main()
    {
        Console.Write("Enter year:  ");
        int inputYear = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(inputYear);
        Console.WriteLine("It's a leap year --> " + isLeap);
    }
}
