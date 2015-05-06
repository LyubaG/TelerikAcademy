//Problem 3. Compare char arrays
//    Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class ArrayComparisonChar
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements in first array: ");
        int n = int.Parse(Console.ReadLine());
        char[] array1 = new char[n];
        Console.WriteLine("Enter each element on a new line: ");
        for (int i = 0; i < n; i++)
        {
            array1[i] = Console.ReadLine()[0]; // quick version of  = char.Parse(Console.ReadLine()) - gets one (the only) element on the line
        }
        Console.WriteLine("Enter number of elements in second array: ");
        int n2 = int.Parse(Console.ReadLine());
        char[] array2 = new char[n2];
        Console.WriteLine("Enter each element on a new line: ");
        for (int i = 0; i < n2; i++)
        {
            array2[i] = Console.ReadLine()[0];
        }
        //for testing
        //char[] array1 = new char[] { 'a', 'b', 'n' };
        //char[] array2 = new char[] { 'a', 'b', 'n', 'o' };
        //
        //char[] array1 = new char[] { 'W', 'g', 'T' };
        //char[] array2 = new char[] { '!', 'Y', '%' };

        bool equal = true;
        int length = Math.Min(array1.Length, array2.Length);
        for (int i = 0; i < length; i++)
        {
            if (array1[i] != array2[i])
            {
                if (array1[i] < array2[i])
                {
                    Console.WriteLine("The first array is lexicographically smaller.");
                }
                else if (array1[i] > array2[i])
                {
                    Console.WriteLine("The second array is lexicographically smaller.");
                }
                equal = false;
                break;
            }
        }
        if (equal == true)
        {
            if (array1.Length < array2.Length)
            {
                Console.WriteLine("The first array is lexicographically smaller.");
            }
            else if (array1.Length > array2.Length)
            {
                Console.WriteLine("The second array is lexicographically smaller.");
            }
            else
                Console.WriteLine("The arrays are equal.");
        }
    }
}

//In lexicographic order the elements are compared one by one starting from the very left. If the elements are not the same, 
//the array, whose element is smaller (comes earlier in the alphabet), comes first. If the elements are equal, the next 
//character is compared. If the end of one of the arrays is reached, without finding different elements, the shorter array 
//is the smaller (comes earlier lexicographically). If all elements are equal, the arrays are equal.
//--> ASCII table char order is applied