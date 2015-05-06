/*Problem 13.* Comparing Floats
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
*/

using System;

class FloatComparison
{
    static void Main()
    {
        Console.WriteLine("Please enter a number x and press Enter:");
        double a = double.Parse(Console.ReadLine());
//If you want to be on the safe side, use Double.TryParse and remember that in some cultures the decimal separator is , while in others it's . and be aware of other pitfalls of different ways to express numbers
        Console.WriteLine("Please enter a number z and press Enter:");
        double b = Convert.ToDouble(Console.ReadLine()); 
//Alternative to Parse. // Convert.ToDouble calls System.Double.Parse. The only difference is that
//Convert.ToDouble returns 0 when Nothing is passed, whereas Double.Parse throws an exception. 
//TryParse first verifies that the string is a number using an internal Number.TryStringToNumber, whereas Parse assumes it already is a number/double
        bool equal = Math.Abs(a - b) < 0.000001;
        Console.WriteLine("a == b with precision 0.000001 --> " + equal);
//If the difference 0.000001 == eps. We consider the numbers are different.
    }
}