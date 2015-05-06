//Problem 10. Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Globalization;
using System.Threading;

class PointInRectAndCircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double distance, radius = 1.5;
        Console.WriteLine("Enter your points' coordinate x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("...and y: ");
        double y = double.Parse(Console.ReadLine());
        distance = Math.Sqrt(Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)); //the '2' is 'raise to the power of 2'

        bool insideCircle = distance <= radius;
        bool outOfRectangle = !(x <= 5 && x >= -1 && y >= -1 && y <= 1);
        bool inCircleOotOfRect = insideCircle && outOfRectangle;

        Console.WriteLine("The point is inside the circle and outside of the rectangle ---> " + inCircleOotOfRect);
    }
}