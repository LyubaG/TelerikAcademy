//Problem 6. First larger than neighbours
//    Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//    Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;

class FirstBiggerThanNeighbours
{
    static void Main()
    {
        //reading input:
        //Console.Write("How long's the array? -->");
        //int arrLength = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the elements in a single line, separated by a space:");
        //int[] funArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
        //                             Select(x => int.Parse(x)).ToArray();

        //test:
        int[] funArray = { 12, 3, 4, 5, 6, 3, 4, 8, 9, 0, 11, 12 };
        Console.WriteLine("The index of the first element larger than its neighbours (you get -1 if there's no such element): " + (FirstLargerThanNeighbours(funArray)));
    }
        
    private static int FirstLargerThanNeighbours(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if ((array[i] > array[i + 1]) && (array[i] > array[i - 1]))
            {
                return i;
            }
            else
                continue;
        }
        return -1;
    }
    //method is revised from the previous problem (where it was void)
    //and the previous problem asks for a different output (this one considers only elements with 2 neighbours), 
    //so no, we don't have to call method from another project here

}

