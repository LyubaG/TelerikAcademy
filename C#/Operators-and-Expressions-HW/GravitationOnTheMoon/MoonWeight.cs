//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.


using System;

class MoonWeight
{
    static void Main()
    {
        Console.WriteLine("What is your weight, in kilograms? ");
        float earthWeight = float.Parse(Console.ReadLine()); 
        earthWeight *= 0.17f;
        Console.WriteLine("Your Moon weight weight is {0} kg, you skinny coder!", Math.Round(earthWeight, 3)); //Rounds it up to 3 digits, otherwise you get a few more unnecessary ones.
    }
}
