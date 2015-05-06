//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFileExceptions
{
    static void Main()
    {
        string remoteUri = "http://telerikacademy.com/Content/Images/";
        string fileName = "news-img01.png";

        using (WebClient myWebClient = new WebClient())
        {
            try
            {
                string fullPath = remoteUri + fileName;
                // Download the file and save it into the current project (Debug) folder.
                myWebClient.DownloadFile(fullPath, fileName);
            }
            catch (WebException)
            {
                Console.Error.WriteLine("Invalid address...");
            }
            catch (ArgumentException)
            {
                Console.Error.WriteLine("You didn't enter anything.");
            }
            catch (NotSupportedException)
            {
                Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            finally
            {
                Console.WriteLine("Done!");
                myWebClient.Dispose(); //inside 'using' block to make sure it is used even if there's an exception
            }
        }

    }
}