//Problem 13. Binary to Decimal Number
//• Using loops write a program that converts a binary integer number to
//its decimal form.
//• The input is entered as string. The output should be a variable of type long.
//• Do not use the built-in .NET functionality.

//Examples:
//binary                          decimal
//0                               0 
//11                              3 
//1010101010101011                43691 
//1110000110000101100101000000    236476736 

using System;

class Binary_to_Decimal
{
    static void Main()
    {
        Console.WriteLine("Enter your binary integer: ");
        string binary = Console.ReadLine();
        long convertedToDec = 0;
        int powerOfTwo = 1;
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            int bit = binary[i] - 48;
            if (bit == 1)
            {
                convertedToDec += bit * powerOfTwo;
            }
            powerOfTwo *= 2;
        }

        Console.WriteLine("Here it is in decimal form: " + convertedToDec);
    }
}

//Second option:
//        Console.WriteLine("Enter your binary integer: ");
//        string binary = Console.ReadLine();
//        long convertedToDec = 0;
//        for (int i = 0; i < binary.Length; i++)
//        {
//            convertedToDec *= 2;
//            convertedToDec += binary[i] - 48;
//        }
//        Console.WriteLine("Here it is in decimal form: " + convertedToDec);