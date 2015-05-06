//Write a program to convert from any numeral system of given base  s  to any other numeral 
//system of base  d  (2 ≤  s ,  d  ≤ 16).

using System;

class NumSystemConversion
{
    static void Main()
    {
        Console.Write("Base of your number:  ");
        int numBase = int.Parse(Console.ReadLine());
        Console.Write("Your number:  ");
        string inputString = Console.ReadLine();
        Console.Write("Base of numeral system you want the number converted to (from 2 to 16):  ");
        int targetBase = int.Parse(Console.ReadLine());
        if (numBase == targetBase)
        {
            Console.WriteLine("There's nothing to convert the number to...");
        }
        else
        {
            Console.Write("The result:  ");
            if (numBase == 10)
            {
                Console.WriteLine(DecimalToBase(long.Parse(inputString), targetBase));
            }
            else if (targetBase == 10)
            {
                Console.WriteLine(BaseToDecimal(inputString, numBase));
            }
            else
            {
                Console.WriteLine(DecimalToBase(BaseToDecimal(inputString, numBase), targetBase));
            }
        }
    }

    static string DecimalToBase(long decimalNum, int numeralSystem)
    {
        string result = string.Empty;
        while (decimalNum > 0)
        {
            long digit = decimalNum % numeralSystem;
            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            decimalNum /= numeralSystem;
        }
        return result;
    }

    static long BaseToDecimal(string input, int numeralSystem)
    {
        long decimalNum = 0;
        for (int i = 0; i < input.Length; i++) 
        {
            int digit = 0;
            if (input[i] >= '0' && input[i] <= '9')
            {
                digit = input[i] - '0';
            }
            else
            {
                digit = input[i] - 'A' + 10;
            }
            decimalNum += digit * (long)Math.Pow(numeralSystem, input.Length - 1 - i);
        }
        return decimalNum;
    }
}