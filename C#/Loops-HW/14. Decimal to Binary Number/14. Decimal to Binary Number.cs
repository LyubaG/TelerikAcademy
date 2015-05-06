//Problem 14. Decimal to Binary Number
//• Using loops write a program that converts an integer number to its binary
//representation.
//• The input is entered as long. The output should be a variable of type string.
//• Do not use the built-in .NET functionality.

//Examples:
//decimal     binary
//0           0 
//3           11 
//43691       1010101010101011 
//236476736   1110000110000101100101000000 

using System;

class Decimal_to_Binary_Number
{
    static void Main()
    {
        Console.WriteLine("Enter your integer: ");
        long decimalNum = long.Parse(Console.ReadLine());
        string binaryNum = String.Empty;
        if (decimalNum == 0) binaryNum = "0";

        long currentDecimal = decimalNum;
        while (currentDecimal != 0)
        {
            int remainder = (int)currentDecimal % 2;
            currentDecimal /= 2;
            binaryNum = remainder + binaryNum;
        }
        Console.WriteLine("In binary form: " + binaryNum);
    }
}
