//Problem 5. Formatting Numbers
//Write a program that reads 3 numbers:
//    integer a (0 <= a <= 500)
//    floating-point b
//    floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//    The number a should be printed in hexadecimal, left aligned
//    Then the number a should be printed in binary form, padded with zeroes
//    The number b should be printed with 2 digits after the decimal point, right aligned
//    The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Globalization;
using System.Threading;

class NumbersTable
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int a;
        double b, c;
        Console.WriteLine("Enter an integer (from 0 to 500): ");
        if ((int.TryParse(Console.ReadLine(), out a)) && (a >= 0 && a<= 500));
        else Console.WriteLine("You didn't follow the instructions, so results will be displayed incorrectly...");
        Console.WriteLine("And a floating-point number: ");
        if (double.TryParse(Console.ReadLine(), out b));
        else Console.WriteLine("You should have entered a floating-point...");
        Console.WriteLine("And another: ");
        if (double.TryParse(Console.ReadLine(), out c));
        else Console.WriteLine("You should have entered a floating-point...");
        Console.WriteLine();
        Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:0.00}|{3,-10:F3}| ", a, (Convert.ToString(a, 2).PadLeft(10, '0')), b, c);

    }
}
