//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type  float ).

using System;
using System.Collections.Generic;
using System.Linq;

class BinaryRepOfFloat
{
    static int GetLeftNibble(byte x)
    {
        return (x >> 4);
    }

    static int GetRightNibble(byte x)
    {
        return (x & 15);
    }

    static string NibbleToBinary(int x)
    {
        string result = "";
        for (int i = 3; i >= 0; --i)
        {
            result += (x >> i) & 1;
        }

        return result;
    }

    static string ConvertFloatToBinary(float floatNumber) //using bitwise operations
    {
        string result = "";
        byte[] floatBytes = BitConverter.GetBytes(floatNumber); //splits it to bits
        for (int i = 3; i >= 0; --i)
        {
            result += NibbleToBinary(GetLeftNibble(floatBytes[i]));
            result += NibbleToBinary(GetRightNibble(floatBytes[i]));
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a float number: ");
        float floatNumber = float.Parse(Console.ReadLine());

        string binaryNumber = ConvertFloatToBinary(floatNumber);

        Console.WriteLine("Binary representation: " + binaryNumber);
        Console.WriteLine("Sign: " + binaryNumber[0]);
        Console.WriteLine("Exponent: " + binaryNumber.Substring(1, 8));
        Console.WriteLine("Mantissa: " + binaryNumber.Substring(9));
    }
}

//hint:
//Use the special method for conversion of single precision floating-point numbers to a 
//sequence of 4 bytes: System.BitConverter.GetBytes(
//<float>). Then use bitwise operations (shifting and bit masks) to extract the sign, 
//mantissa and exponent following the IEEE 754 standard.