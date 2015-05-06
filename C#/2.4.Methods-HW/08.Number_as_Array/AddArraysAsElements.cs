//Problem 8. Number as array
//    Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//    Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class AddArraysAsElements
{
    static void Main()
    {
        Console.Write("Enter first positive integer: ");
        string numInput1 = Console.ReadLine();
        Console.Write("Enter second positive integer: ");
        string numInput2 = Console.ReadLine();

        //check if input is ok
        BigInteger firstNumber;
        BigInteger secondNumber;
        bool isFirstNumber = BigInteger.TryParse(numInput1, out firstNumber);
        bool isSecondNumber = BigInteger.TryParse(numInput2, out secondNumber);
        if (isFirstNumber && isSecondNumber)
        {                  
        //use input as string; comparing lengths, fill empty with zeroes
        int commonLength = (numInput1.Length > numInput2.Length) ? numInput1.Length : numInput2.Length;
        numInput1 = numInput1.PadLeft(commonLength, '0');
        numInput2 = numInput2.PadLeft(commonLength, '0');
        
        CreateArrayFromInput(numInput1);
        CreateArrayFromInput(numInput2);

       //result
        string result = AddArrays(CreateArrayFromInput(numInput1), CreateArrayFromInput(numInput2));
        Console.Write("Adding the numbers as array elements results in: ");
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();    
    }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    //fill it backwards (last digit at arr[0]) to make sure padded zeroes don't skew end result
     static int[] CreateArrayFromInput(string input)
    {
        int[] array = new int[input.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(input[input.Length - 1 - i].ToString());
        }
        return array;
    }

     static string AddArrays(int[] numberOneArr, int[] numberTwoArr)
    {
        string addedNum = string.Empty;
        int remaining = 0;
        for (int i = 0; i < numberOneArr.Length; i++)
        {
            addedNum += ((numberOneArr[i] + numberTwoArr[i]) % 10 + remaining).ToString();
            remaining = (numberOneArr[i] + numberTwoArr[i]) / 10;
            if (remaining > 0 && i == numberTwoArr.Length - 1)
            {
                addedNum += remaining;
            }
        }
        return addedNum;
    }
}