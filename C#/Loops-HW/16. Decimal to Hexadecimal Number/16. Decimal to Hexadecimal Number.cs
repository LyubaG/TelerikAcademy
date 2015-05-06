//Problem 16. Decimal to Hexadecimal Number
//• Using loops write a program that converts an integer number to its
//hexadecimal representation.
//• The input is entered as long. The output should be a variable of type string.
//• Do not use the built-in .NET functionality.

//Examples:
//decimal         hexadecimal
//254             FE 
//6883            1AE3 
//338583669684    4ED528CBB4 

using System;

class Decimal_to_Hexadecimal_Number
{
    static void Main()
    {
        Console.WriteLine("Enter your integer: ");
        long decimalNum = long.Parse(Console.ReadLine());
        string hexNum = String.Empty;
        if (decimalNum == 0) hexNum = "0";

        long currentDecimal = decimalNum;
        while (currentDecimal > 0)
        {
            long remainder = currentDecimal % 16; //don't use int
            currentDecimal /= 16;
            switch (remainder)
            {
                case 10: hexNum = "A" + hexNum; break;
                case 11: hexNum = "B" + hexNum; break;
                case 12: hexNum = "C" + hexNum; break;
                case 13: hexNum = "D" + hexNum; break;
                case 14: hexNum = "E" + hexNum; break;
                case 15: hexNum = "F" + hexNum; break;
                default: hexNum = remainder + hexNum; break;
            }
        }
        Console.WriteLine("In hexadecimal form: " + hexNum);
    }
}
