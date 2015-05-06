//    Write a program that prints to the console which day of the week is today.
//    Use System.DateTime.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Hooray! Today is ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(DateTime.Now.DayOfWeek + "...");
            Console.ResetColor();
            Console.WriteLine();
     }
}
