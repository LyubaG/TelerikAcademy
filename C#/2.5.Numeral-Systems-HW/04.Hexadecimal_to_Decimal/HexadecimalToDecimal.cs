//• Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a number in hexadecimal form: ");
        string hexNum = Console.ReadLine();
        Console.WriteLine("This number in decimal form is:");
        Console.WriteLine(HexToDecimal(hexNum));
    }

    static long HexToDecimal(string hex)
    {
        long decimalNum = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            int digit = 0;
            if (hex[i] >= '0' && hex[i] <= '9')
            {
                digit = hex[i] - '0';
            }
            else if (hex[i] >= 'A' && hex[i] <= 'F')
            {
                digit = hex[i] - 'A' + 10;
            }
            decimalNum += digit * (long)Math.Pow(16, hex.Length - 1 - i);
        }
        return decimalNum;
    }
}