//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Security;

    class ReadFileExceptions
    {
        static void Main()
        {
            try
            {
                //play around with file name to test the exceptions
                Console.WriteLine(File.ReadAllText(@"C:\Windows\win.ini"));
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Such path does not exist.");
            }
            catch (ArgumentException)
            {
                Console.Error.WriteLine("Path contains invalid character(s), white space, or is an empty string.");
            }
            catch (PathTooLongException)
            {
                Console.Error.WriteLine("The entered path, file name (or both) exceed the system-defined maximum length.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("The specified directory does not exist.");
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("The file is not present in the specified directory.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("A general input-output error occured while opening the file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.Error.WriteLine("You don't have the permission to open the file.");
            }
            catch (NotSupportedException)
            {
                Console.Error.WriteLine("That's not a valid path format.");
            }
            catch (SecurityException)
            {
                Console.Error.WriteLine("You don't have the permission to open the file.");
            }

        }
    }
