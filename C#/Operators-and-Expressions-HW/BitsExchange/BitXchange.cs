//Problem 15.* Bits Exchange
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitXchange
{
    static void Main()
    {
        uint n;
        Console.Write("Enter an unsigned integer: ");
        bool validUint = uint.TryParse(Console.ReadLine(), out n);
        Console.WriteLine("Initial binary:");
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        if (validUint)
        {
            int num = (int)n;

            int bit3 = (num >> 3) & 1;
            int bit24 = (num >> 24) & 1;
            num = num & (~(1 << 24)) | (bit3 << 24);
            num = num & (~(1 << 3)) | (bit24 << 3);

            int bit4 = (num >> 4) & 1;
            int bit25 = (num >> 25) & 1;
            num = num & (~(1 << 25)) | (bit4 << 25);
            num = num & (~(1 << 4)) | (bit25 << 4);

            int bit5 = (num >> 5) & 1;
            int bit26 = (num >> 26) & 1;
            num = num & (~(1 << 26)) | (bit5 << 26);
            num = num & (~(1 << 5)) | (bit26 << 5);

            Console.WriteLine("Final binary:");
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine("You end up with number:");
            Console.WriteLine((uint)num); //Doesn't work if I leave it as int...

        }
        else
        {
            Console.WriteLine("Not a valid entry. Console mucho disappointed :(");
        }
        Console.ReadLine();
    }
}

//Option 2:
//int startBitReceiver = 3;
//int startBitSender = 24;

//for (int i = 0; i < 3; i++)
//{
//    long maskOne = (num & (1 << startBitReceiver)) >> startBitReceiver;
//    long maskTwo = (num & (1 << startBitSender)) >> startBitSender;

//    //mask one
//    if (maskOne == 0)
//    {
//        num = num & (~(1 << startBitSender));
//    }
//    else if (maskOne == 1)
//    {
//        num = num | (1 << startBitSender);
//    }

//    //mask two
//    if (maskTwo == 0)
//    {
//        num = num & (~(1 << startBitReceiver));
//    }
//    else if (maskTwo == 1)
//    {
//        num = num | (1 << startBitReceiver);
//    }

//    startBitReceiver++;
//    startBitSender++;
//}

//Option 3:
//n = ((~(7u << 24 | 7u << 3)) & n) | (((n & (7u << 3)) << 21) | ((n & (7u << 24)) >> 21));//Swap bits 3,4,5 with 24,26,26
