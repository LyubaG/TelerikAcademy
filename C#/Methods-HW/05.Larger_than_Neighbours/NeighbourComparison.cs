//Problem 5. Larger than neighbours
//    Write a method that checks if the element at given position in given array of integers is larger 
//than its two neighbours (when such exist).

using System;

class NeighbourComparison
{
    static void Main()
    {
        //reading input:
        //Console.Write("How long's the array? -->");
        //int arrLength = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the elements in a single line, separated by a space:");
        //int[] funArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
        //                             Select(x => int.Parse(x)).ToArray();
        //Console.WriteLine("Position of the element:");
        //int position = int.Parse(Console.ReadLine());

        //test (change position if you want):
        int[] funArray = { 12, 3, 4, 5, 6, 3, 4, 8, 9, 0, 11, 12 };
        int position = 8;
        BiggestAmongNeighbours(funArray, position);
    }

    private static void BiggestAmongNeighbours(int[] array, int position)
    {
        if (position < 0 || position > array.Length)
        {
            Console.WriteLine("Invalid position");
        }
        else if ((position == 0 && array[position] > array[position + 1]) || (position == array.Length-1 && array[position] > array[position - 1]))
        {
            Console.WriteLine("The element at position {0} is bigger than its only neighbour.", position);
        }
        else if ((array[position] > array[position + 1]) && (array[position] > array[position - 1]))
        {
            Console.WriteLine("The element at position {0} is bigger than its neighbours. Hooray!", position);
        }
        else Console.WriteLine("The element has larger neighbours. Poor element...");
    }
}
