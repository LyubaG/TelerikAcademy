//Problem 3. Check for a Play Card
//• Classical play cards use the following signs to designate the card face:
//`2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string 
//and prints “yes” if it is a valid card sign or “no” otherwise.
//Examples:
//character       Valid card sign?
//5               yes 
//1               no 
//Q               yes 
//q               no 
//P               no 
//10              yes 
//500             no 

using System;

class Check_for_a_Play_Card
{
    static void Main()
    {
        Console.WriteLine("Enter the card sign: ");
        char sign;
        string entry = Console.ReadLine();
        if (char.TryParse(entry, out sign))
        {
            if ((sign >= 50 && sign <= 57) || sign == 74 || sign == 81 || sign == 75 || sign == 65)
            {
                Console.WriteLine("It's a valid card.");
            }
            else Console.WriteLine("Invalid entry.");
        }
        else
        {
            if (entry == "10") Console.WriteLine("It's a valid card.");
            else Console.WriteLine("Invalid entry.");
        }

    }
}

