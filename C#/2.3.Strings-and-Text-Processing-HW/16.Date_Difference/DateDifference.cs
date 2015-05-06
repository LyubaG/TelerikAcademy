//Problem 16. Date difference
//    Write a program that reads two dates in the format: day.month.year and 
//calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;
using System.Collections.Generic;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter first date: ");
        DateTime dateOne = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Enter second date: ");
        DateTime dateTwo = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        TimeSpan dateDifference = dateOne - dateTwo;
        Console.WriteLine("The difference (in days) is: " + Math.Abs(dateDifference.Days));
    }
}
