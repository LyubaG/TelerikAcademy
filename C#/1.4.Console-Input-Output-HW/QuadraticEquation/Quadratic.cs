//Problem 6. Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
using System.Globalization;
using System.Threading;

class Quadratic
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a, b, c, x1;
        Console.Write("Your quadratic equation's coefficient a = ");
        if (double.TryParse(Console.ReadLine(), out a)) ;
        else Console.WriteLine("You didn't enter a number...");
        Console.Write("b = ");
        if (double.TryParse(Console.ReadLine(), out b)) ;
        else Console.WriteLine("You didn't enter a number...");
        Console.Write("c = ");
        if (double.TryParse(Console.ReadLine(), out c)) ;
        else Console.WriteLine("You didn't enter a number...");
        Console.WriteLine();
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0) Console.WriteLine("No real roots, sorry.");
        else if (discriminant == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("The roots are x1 = x2 = {0}", x1);
        }
        else
        {
            x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The roots are x1 = {0} and x2 = {1}", x1, x2);
        }
        Console.WriteLine();
    }
}