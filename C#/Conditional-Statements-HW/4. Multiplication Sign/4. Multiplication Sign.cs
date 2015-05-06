//Problem 4. Multiplication Sign
//• Write a program that shows the sign (+, - or 0) of the product of three real numbers,
//without calculating it. ◦ Use a sequence of  if  operators.

//Examples:
//a       b       c       result
//5       2       2       + 
//-2      -2      1       + 
//-2      4       3       - 
//0       -2.5    4       0 
//-1      -0.5    -5.1    - 

using System;
using System.Globalization;
using System.Threading;

class Multiplication_Sign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a, b, c;
                Console.WriteLine("Enter a: ");
        while (!(double.TryParse(Console.ReadLine(), out a)))
        {
            Console.WriteLine("Follow the instructions, please...again: ");
        }
        Console.WriteLine("Enter b: ");
        while (!(double.TryParse(Console.ReadLine(), out b)))
        {
            Console.WriteLine("Follow the instructions...again: ");
        }
        Console.WriteLine("Enter c: ");
        while (!(double.TryParse(Console.ReadLine(), out c)))
        {
            Console.WriteLine("Follow the instructions, please...again: ");
        }

        if ((a == 0) || (b == 0) || (c == 0)) Console.WriteLine("Product sign is 0");
        else if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c < 0))
        {
            Console.WriteLine("Product sign is +");
        }
        else Console.WriteLine("Product sign is -");
    }
}


//Option 2:::
//if (a == 0 || b == 0 || c == 0)
//{
//Console.WriteLine("Result: {0}", "0");
//}
//else
//{
//if (a < 0)
//{
//sign++;
//}
//if (b < 0)
//{
//sign++;
//}
//if (c < 0)
//{
//sign++;
//}
//if (sign % 2 == 0)
//{
//Console.WriteLine("Result: {0}", "+");
//}
//else
//{
//Console.WriteLine("Result: {0}", "-");
//}
//}