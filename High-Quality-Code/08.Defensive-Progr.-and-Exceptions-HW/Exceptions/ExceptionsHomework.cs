using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("Array can't null.", "array");
        }
        if (count < 0)
        {
            throw new ArgumentNullException("Length of subsequence cannot be negative", "subsequence length");
        }
        if (startIndex < 0 || startIndex >= arr.Length)
        {
            throw new ArgumentOutOfRangeException("Start index must be at least 0 and within the array range.");
        }
        if ((startIndex + count) >= arr.Length)
        {
            count = arr.Length - startIndex;
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (str == null)
        {
            throw new ArgumentNullException("String cannot be null.");
        }
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("Count shouldn't be greater than string length.");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        if (!(number > 0))
        {
            throw new ArgumentOutOfRangeException("That's no number, dear.");
        }

        if (number <= 2)
        {
            return false;
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        try
        {
            Console.WriteLine(ExtractEnding("Hi", 100));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }

        int numberTwentyTree = 23;
        if (CheckPrime(numberTwentyTree))
        {
            Console.WriteLine("{0} is prime", numberTwentyTree);
        }
        else
        {
            Console.WriteLine("{0} is not a prime", numberTwentyTree);
        }

        int numberThirtyTree = 33;
        if (CheckPrime(numberTwentyTree))
        {
            Console.WriteLine("{0} is prime", numberThirtyTree);
        }
        else
        {
            Console.WriteLine("{0} is not a prime", numberThirtyTree);
        }

        List<Exam> peterExams = new List<Exam>() {
                                    new SimpleMathExam(2),
                                    new CSharpExam(55),
                                    new CSharpExam(100),
                                    new SimpleMathExam(1),
                                    new CSharpExam(0)};
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
