//Write a program to convert decimal numbers to their binary representation.
//Examples:
//decimal     binary
//3           11 
//43691       1010101010101011 
//236476736   1110000110000101100101000000 

using System;

class DecimalToBinaryConversion
{
    static void Main()
    {
        Console.Write("Enter an integer n (>= 0): ");
        long num = long.Parse(Console.ReadLine());
        string binary = "";

        do
        {
            binary = num % 2 + binary;
            num = num / 2;
        }
        while (num > 0);
        Console.WriteLine(binary);
    }    
}



//Option 2:
//long decimalForm = long.Parse(Console.ReadLine());
//string buffer = "";
//do
//{
//    buffer += decimalForm % 2;
//    decimalForm = decimalForm / 2;
//}
//while (decimalForm != 0);
//string binaryForm = "";
//for (int i = buffer.Length - 1; i >= 0; i--)
//{
//    binaryForm += buffer[i];
//}
//Console.WriteLine(binaryForm);

//In a reusable method:
    //static string DecimalToBinary(long decimalNum)
    //{
    //    string binaryNum = string.Empty;
    //    while (decimalNum > 0)
    //    {
    //        var digit = decimalNum % 2;
    //        binaryNum += digit + binaryNum; //to make sure digit order is correct
    //        decimalNum = decimalNum / 2;
    //    }
    //    return binaryNum;
    //}