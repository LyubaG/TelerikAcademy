//Problem 1. Allocate array
//    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//    Print the obtained array on the console.

using System;

class SimpleArray
{
    static void Main()
    {
        int[] lovelyArray = new int[20];
        for (int i = 0; i < 20; i++)
        {
            lovelyArray[i] = i * 5;
            Console.Write("{0}  ", lovelyArray[i]);

        }
        Console.WriteLine();
        
    }
}
// Note: another option is to separate them by commas and use String.Join to avoid the comma after the last element.