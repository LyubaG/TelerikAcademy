//Problem 17.* Subset K with sum S
//    Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//    Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Collections.Generic;

    class SubsetKofSumS
    {
        static void Main()
        {
            //input
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Element {0} = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter S: ");
            int S = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());

            //finding the elements
            int checkedNumbers = 0;
            List<int> sumSubsetNums = new List<int>();
            int maxIndex = (int)Math.Pow(2, array.Length) - 1;
            bool subsetExists = false;

            //note: "a subset of K elements" is needed, not all subsets
            for (int i = 1; i <= maxIndex; i++)
            {
                long currentSum = 0;
                for (int j = 1; j <= array.Length; j++)
                {
                    if (((i >> (j - 1)) & 1) == 1)
                    {
                        currentSum += array[j - 1];
                        checkedNumbers++;
                        sumSubsetNums.Add(array[j - 1]);
                    }
                }
                if (checkedNumbers == K && currentSum == S)
                {
                    subsetExists = true;
                    break;
                }
                else
                {
                    checkedNumbers = 0;
                    sumSubsetNums.Clear();
                }
            }

            //output
            if (subsetExists)
            {
                Console.WriteLine("A subset resulting in the sum:");
                for (int i = 0; i < sumSubsetNums.Count; i++)
                {
                    Console.Write(sumSubsetNums[i] + " ");
                }
            }
            else
            {
                Console.Write("There's no subset resulting in this sum.");
            }
            Console.WriteLine();


        }
    }
