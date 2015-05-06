//Problem 1. Say Hello
//    Write a method that asks the user for his name and prints “Hello, <name>”
//    Write a program to test this method.
//Example:
//input 	output
//Peter 	Hello, Peter!

using System;

class HelloMethod
{
    static void Main()
    {
                Greeting();
    }

    static void Greeting()
    {
        Console.WriteLine("Your name, dear?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + " !\n");
    }
}

//Split into two:
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Your name, dear?");
//        string name = Console.ReadLine();
//        Greeting(name);

//    }

//    static void Greeting(string name)
//    {
//        Console.WriteLine("Hello, " + name + " !\n");
//    }
//}