//Problem 20.* Variations of set
//    Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example:
//N 	K 	
//3 	2 	
//{1, 1}
//{1, 2}
//{1, 3}
//{2, 1}
//{2, 2}
//{2, 3}
//{3, 1}
//{3, 2}
//{3, 3}

using System;
using System.Collections.Generic;
using System.Linq;

    class VariationsWithRecursion
    {
        static void Main()
        {
            //input
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = i + 1;
            }
            Variations(nums, new int[k], 0);
        }

        static void Variations(int[] nums, int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(", ", arr));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                arr[index] = nums[i];
                Variations(nums, arr, index + 1); //to start from next element
            }
        }
    }
