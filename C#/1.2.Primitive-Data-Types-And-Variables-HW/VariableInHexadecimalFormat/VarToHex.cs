/*
Problem 3. Variable in Hexadecimal Format
Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
Use Windows Calculator to find its hexadecimal representation.
Print the variable and ensure that the result is 254.
*/

using System;

class VarToHex
{
    static void Main()
    {
        int var = 0xFE;
        Console.WriteLine("The decimal value of 0xFE is {0}.", var);
    }
}

