//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter a number in binary form:  ");
        string binary = Console.ReadLine();
        Console.Write("This number in hexadecimal form is:  ");
        Console.WriteLine(BinaryToHex(binary));
    }

    static string BinaryToHex(string binaryNum)
    {
        //fill number with zeroes so it's divisible by 4
        if (binaryNum.Length % 4 != 0)
        {
            binaryNum = binaryNum.PadLeft((binaryNum.Length + (4 - binaryNum.Length % 4)), '0');
        }
        string[] binArray = new string[binaryNum.Length / 4];
        //fill new array
        int index = 0, newIndex = 0;
        while (index + 4 <= binaryNum.Length)
        {
            binArray[newIndex] = binaryNum.Substring(index, 4);
            index += 4;
            newIndex++;
        }

        string[] binHexConvTable = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", 
                                       "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
        string[] hexBinConvTable = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        string hexResult = string.Empty;

        for (int i = 0; i < binArray.Length; i++)
        {
            for (int j = 0; j < binHexConvTable.Length; j++)
            {
                if (binArray[i] == binHexConvTable[j])
                {
                    hexResult = hexResult + hexBinConvTable[j];
                }
            }
        }
        return hexResult;
    }
}
