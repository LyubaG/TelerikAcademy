/*
Problem 8. Isosceles Triangle
Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
*/

using System;

class CharTriangle
{
    static void Main()
    {
        char copyright = '\u00A9';
        string line = copyright.ToString();
        Console.WriteLine(new string(' ', 3) + copyright + new string(' ', 3)); //Note to self: check other empty space methods; string.Empty did not work :(
        Console.WriteLine();
        Console.WriteLine(new string(' ', 2) + copyright + new string(' ', 1) + copyright + new string(' ', 2));
        Console.WriteLine();
        Console.WriteLine(new string(' ', 1) + copyright + new string(' ', 3) + copyright + new string(' ', 1));
        Console.WriteLine();
        Console.WriteLine(copyright + new string(' ', 1) + copyright + new string(' ', 1) + copyright + new string(' ', 1) + copyright);
        //Note to self: check console encoding before disappointment...
    }
}