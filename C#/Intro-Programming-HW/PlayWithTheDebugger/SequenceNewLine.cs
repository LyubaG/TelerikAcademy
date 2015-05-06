using System;

class SequenceNewLine
{
    static void Main()
    {
        int number = 1;
        while (number < 1001)
        {
            Console.WriteLine(number);
            number = number + 1;
        }
        Console.ReadLine();
    }
}

