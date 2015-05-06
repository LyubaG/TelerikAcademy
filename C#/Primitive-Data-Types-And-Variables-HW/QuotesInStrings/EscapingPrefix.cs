//Problem 7. Quotes in Strings
//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class EscapingPrefix
{
    static void Main()
    {
        string withPrintedQuotMarks = @"The ""use"" of quotations causes difficulties."; //The @ prefix means \" equals ""
        string withoutQuotMarks = "The \"use\" of quotations causes difficulties."; //escaping sequence
        Console.WriteLine("{0} - looks the same as - {1}", withPrintedQuotMarks, withoutQuotMarks);
    }
}