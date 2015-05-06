//Problem 15. Hexadecimal to Decimal Number
//• Using loops write a program that converts a hexadecimal integer number
//to its decimal form.
//• The input is entered as string. The output should be a variable of type long.
//• Do not use the built-in .NET functionality.

//Examples:
//hexadecimal         decimal
//FE                  254 
//1AE3                6883 
//4ED528CBB4          338583669684 

using System;

class Hexadecimal_to_Decimal_Number
{
    static void Main()
    {
        Console.WriteLine("Enter your hexadecimal integer: ");
        string hexInt = Console.ReadLine();
        long convertedToDec = 0;
        long power = 1;
        for (int index = hexInt.Length - 1; index >= 0; index--)
        {
            int hexDigit;
            switch (hexInt[index])    // fill in string to the left to avoid having to reverse it
            {
                case 'A': hexDigit = 10; break;
                case 'B': hexDigit = 11; break;
                case 'C': hexDigit = 12; break;
                case 'D': hexDigit = 13; break;
                case 'E': hexDigit = 14; break;
                case 'F': hexDigit = 15; break;
                default: hexDigit = (int)hexInt[index] - 48; break;
            }
            convertedToDec += hexDigit * power;
            power *= 16;
        }

        Console.WriteLine("Here it is in decimal form: " + convertedToDec);
    }
}
