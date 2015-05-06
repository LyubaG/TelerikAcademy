//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;
using System.Globalization;
using System.Threading;

class CircleData
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double r;
        Console.WriteLine("Enter the circle's radius \"r\": ");
        if (double.TryParse(Console.ReadLine(), out r)) ;
        else Console.WriteLine("That's not a number. Ts ts ts...");
        Console.WriteLine("The circle's perimeter is {0:0.00}, and the area is {1:0.00}. ", (2 * r * Math.PI), (Math.PI * r * r));
        //Another option is with {0:F2}
    }
}