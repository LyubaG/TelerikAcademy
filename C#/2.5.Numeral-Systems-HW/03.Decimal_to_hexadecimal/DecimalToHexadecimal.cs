//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter a number in decimal form: ");
        long decimalNum = long.Parse(Console.ReadLine());
        Console.WriteLine("This number in hexadecimal form is:");
        Console.WriteLine(DecimalToHex(decimalNum));
    }

    static string DecimalToHex (long decimalNum)
    {
        string hexResult = string.Empty;
        while (decimalNum > 0)
        {
            int digit = (int)decimalNum % 16; //digit is practically the remainder
            if (digit >= 0 && digit <= 9)
            {
                hexResult = (char)(digit + '0') + hexResult;
            }
            else
            {
                hexResult = (char)(digit - 10 + 'A') + hexResult;
            }
            decimalNum /= 16;
        }
        return hexResult;
    }

}