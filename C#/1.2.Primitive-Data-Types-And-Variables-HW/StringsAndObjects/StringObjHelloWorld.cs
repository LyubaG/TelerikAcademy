//Problem 6. Strings and Objects
//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class StringObjHelloWorld
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";
        object greeting = word1 + ", " + word2;
        string fullSentence = (string)greeting;  //Note to self: that's type casting, i.e. you 'transform' greeting into a string
        Console.WriteLine(fullSentence + "...");
        //Note to whoever checks my homework - why wouldn't the computer understand it all without type casting? Just curious :)
    }
}
