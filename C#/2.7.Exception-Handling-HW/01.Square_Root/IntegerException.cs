//Write a program that reads an integer number and calculates and prints its square root.
//    If the number is invalid or negative, print Invalid number.
//    In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

class IntegerException
{
    static void Main()
    {
        Console.WriteLine("Enter a non-negative integer: ");
        string input = Console.ReadLine();
        try
        {
            uint.Parse(input);
            Console.WriteLine("The square root is {0}.", Math.Sqrt(uint.Parse(input)));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number :(");
        }
        finally
        {
            Console.WriteLine("Good-bye!");
        }

    }
}

