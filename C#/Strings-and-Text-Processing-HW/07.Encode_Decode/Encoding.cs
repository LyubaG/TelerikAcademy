//Problem 7. Encode/decode
//    Write a program that encodes and decodes a string using given encryption key (cipher).
//    The key consists of a sequence of characters.
//    The encoding/decoding is done by performing XOR (exclusive or) operation over the 
//  first letter of the string with the first of the key, the second – with the second, etc. 
//  When the last key character is reached, the next is the first.

using System;
using System.Text;

class Encoding
{
    static void Main()
    {
        Console.WriteLine("Enter cipher: ");
        string cipher = Console.ReadLine();
        Console.WriteLine("Enter string: ");
        string text = Console.ReadLine();
        Console.WriteLine("Encoded (funny characters inclusive):\n" + Cipher(cipher, text));
        Console.WriteLine("Decoded:\n" + Cipher(cipher, Cipher(cipher, text)));
    }

    static string Cipher(string cipher, string text)
    {
        var encoded = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            encoded.Append((char)(text[i] ^ cipher[i % cipher.Length]));
        }
        return encoded.ToString();
    }
}

