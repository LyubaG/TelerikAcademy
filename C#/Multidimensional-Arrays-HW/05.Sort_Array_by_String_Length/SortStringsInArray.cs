//Problem 5. Sort by string length
//You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

using System;

class SortStringsInArray
{
    static void Main()
    {
        string[] array = { "Baba", "Meca", "Gorata", "Chervenata", "Shapka", "Mamma Mia", "Hola", "Oye" };
        //another test:
        //string[] array = { "dfgh", ".", "3w4terdt", "fd", "hhh", "qw[;lkj;0976", "56", "add" };
        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
    }
}

//another way:
//var sortedArray = array.OrderBy(x => x.Length);

//and another:
