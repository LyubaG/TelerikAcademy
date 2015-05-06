//Write a program to convert binary numbers to their decimal representation.
//Examples:
//decimal     binary
//3           11 
//236476736   1110000110000101100101000000 

using System;

class BinaryToDecimalConv
{
    static void Main()
    {
        Console.Write("Please enter a number in binary form: ");
        string binary = Console.ReadLine();
        Console.WriteLine("This number in decimal form is:");
        Console.WriteLine(BinaryToDecimal(binary));
    }

    static long BinaryToDecimal (string binaryNum)
    {
        long decimalNum = 0;

        for (int i = 0; i < binaryNum.Length; i++)
        {
            // int digit = binaryNum[i] == '1' ? 1 : 0;  ---> because it's either 0 or 1
            int digit = binaryNum[i] - '0';
            int position = binaryNum.Length - 1 - i;
            decimalNum += digit * (long)Math.Pow(2, position); //method works with double
        }

        return decimalNum;
    }
}

//by removing last digit:
        //double sum = 0;
        //int n = 1111111; 
        //int strn = n.ToString().Length; //how many digits has my number
        //for (int i = 0; i < strn; i++)
        //{
        //    int lastDigit = n % 10; // get the last digit
        //    sum = sum + lastDigit * (Math.Pow(2, i));
        //    n = n / 10; //remove the last digit
        //}
        //Console.WriteLine(sum);

//another way:
//sum = 0;
//Array.Reverse(a); //input, parsed to array
//for (int j = 0; j < a.Length;j++)
//{
//   if (a[j] == 1)
//sum = sum + (Math.Pow(2, j));
//}

//similar way, with foreach:
        //string binaryStr = Console.ReadLine();
        //byte [] binNum = new byte [binNum.Length];
        //for (int i = 0; i < binaryStr.Length; i++)
        //{
        //    binNum[i] = byte.Parse(Convert.ToString((binaryStr [i])));
        //}
        //Array.Reverse(binNum);
 
        //long numDecimal = 0;
        //long multiplier = 1;
        //foreach (var digit in binNum)
        //{
        //    numDecimal += (digit * multiplier);
        //    multiplier *= 2;
        //}