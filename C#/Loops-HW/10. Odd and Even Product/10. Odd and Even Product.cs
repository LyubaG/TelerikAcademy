//Problem 10. Odd and Even Product
//• You are given  n  integers (given in a single line, separated by a space).
//• Write a program that checks whether the product of the odd elements is equal
//to the product of the even elements.
//• Elements are counted from  1  to  n , so the first element is odd, the second 
//is even, etc.

//Examples:
//numbers             result
//2 1 1 6 3           yes 
//product = 6  

//3 10 4 6 5 1        yes 
//product = 60  

//4 3 2 5 2           no 
//odd_product = 16  
//even_product = 15 

using System;

class Odd_and_Even_Product
{
    static void Main()
    {
        //split string, go through each one...
        Console.Write("Enter a row of integers and separate them with only a space: ");
        string numbersRow = Console.ReadLine();
        string[] numberString = numbersRow.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;
        string result;
        for (int i = 0; i < numberString.Length; i++)
        {
            int element = int.Parse(numberString[i]);
            if (i % 2 == 0)
                evenProduct *= element;
            else oddProduct *= element;
        }
        bool isEqual = (oddProduct == evenProduct);
        if (isEqual == true) result = "yes";
        else result = "no";
        Console.WriteLine("Are the products equal --> " + result);


    }
}
