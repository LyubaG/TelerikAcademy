//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class PerimeterArea
{
    static void Main()
    {
        Console.WriteLine("What's the width of your rectangle (in cm)? ");
        double side1 = double.Parse(Console.ReadLine());
        Console.WriteLine("How about the other?");
        double side2 = double.Parse(Console.ReadLine());
        double area = side1 * side2;
        double perimeter = 2 * (side1 + side2);
        Console.WriteLine("The perimeter is {0}cm, and the area is {1}cm^2.", perimeter, area);
    }
}
