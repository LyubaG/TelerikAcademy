//Problem 21.* Combinations of set
//    Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//Example:
//N 	K 	result
//5 	2 	
//{1, 2}
//{1, 3}
//{1, 4}
//{1, 5}
//{2, 3}
//{2, 4}
//{2, 5}
//{3, 4}
//{3, 5}
//{4, 5}


using System;
using System.Collections.Generic;
using System.Linq;

class CombinationsWithRecursion
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());
    
    static void Main()
    {
        //user input can be here, but the method has to be reworked to get n
        int[] nums = new int[k];
        Combinations(nums, 0, 1);
    }

    static void Combinations(int[] array, int index, int currentNumber)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = currentNumber; i <= n; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1); 
            }
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

}