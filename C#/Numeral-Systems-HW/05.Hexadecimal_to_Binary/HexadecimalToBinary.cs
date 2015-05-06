//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecimalToBinary
{

    static void Main()
    {
        Console.Write("Please enter a number in hexadecimal form:  ");
        string hex = Console.ReadLine();
        Console.Write("This number in binary form is:  ");
        Console.WriteLine(HexToBinary(hex));
    }

    static string HexToBinary(string hexNum)
    {
        string hexResult = string.Empty;
        string[] binHexConvTable = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", 
                                       "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
        string[] hexBinConvTable = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        for (int i = 0; i < hexNum.Length; i++)
        {
            for (int j = 0; j < hexBinConvTable.Length; j++)
            {
                if (Convert.ToString(hexNum[i]) == hexBinConvTable[j])
                {
                    hexResult = hexResult + binHexConvTable[j];
                }
            }
        }
        return hexResult;
    }
}