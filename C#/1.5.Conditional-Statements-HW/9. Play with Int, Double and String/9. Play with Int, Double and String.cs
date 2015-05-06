//Problem 9. Play with Int, Double and String
//• Write a program that, depending on the user’s choice, inputs an  int ,  double
//or  string  variable. ◦ If the variable is  int  or  double , the program increases it by one.
//◦ If the variable is a  string , the program appends  *  at the end.
//• Print the result at the console. Use switch statement.

using System;
using System.Globalization;
using System.Threading;

class Play_with_Int_Double_and_String
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Choose what data you want to process and enter the corresponding number\n1-->int\n2-->double\n3-->string");
        string choice = Console.ReadLine();
        Console.WriteLine();
        switch (choice)
        {
            case "1":
                Console.Write("Enter an integer: ");
                int choiceInt;
                while (!(int.TryParse(Console.ReadLine(), out choiceInt)))
                {
                    Console.WriteLine("Try again...: ");
                }
                Console.WriteLine("Your result:");
                Console.WriteLine(choiceInt + 1);
                break;
            case "2":
                Console.Write("Enter a double: ");
                double choiceDbl;
                while (!(double.TryParse(Console.ReadLine(), out choiceDbl)))
                {
                    Console.WriteLine("Try again...: ");
                }
                Console.WriteLine("Your result:");
                Console.WriteLine(choiceDbl + 1);
                break;
            case "3":
                Console.Write("Enter a string: ");
                string choiceTxt = Console.ReadLine();
                Console.WriteLine("Your result:");
                Console.WriteLine(choiceTxt + "*");
                break;
            default:
                Console.WriteLine("Invalid choice. You want too much from me.");
                break;
        }
        Console.ReadLine();
    }
}

