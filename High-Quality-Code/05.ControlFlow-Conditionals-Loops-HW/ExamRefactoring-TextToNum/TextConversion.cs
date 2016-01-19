namespace ExamRefactoring_TextToNum
{
    using System;

    public class TextConversion
    {
        private const char StopChar = '@';

        public static void Main()
        {
            decimal moduleNum = decimal.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            decimal result = GetConversionResult(text, moduleNum);
            Console.WriteLine(result);
        }

        private static decimal GetConversionResult(string text, decimal moduleNum)
        {
            decimal result = 0;
            int textLength = text.Length;

            for (int i = 0; i < textLength; i++)
            {
                if (text[i] == StopChar)
                {
                    return result;
                }
                else if (Char.IsDigit(text[i]))
                {
                    result *= (int)text[i] - 48;
                }
                else if ((text[i] >= 32 && text[i] <= 47) ||
                    (text[i] >= 58 && text[i] <= 63) ||
                    (text[i] >= 91 && text[i] <= 96) ||
                    (text[i] >= 123 && text[i] <= 126))
                {
                    result = result % moduleNum;
                }
                else
                {
                    if (text[i] >= 65 && text[i] <= 90)
                    {
                        result = result + (text[i] - 65);
                    }
                    else if (text[i] >= 97 && text[i] <= 122)
                    {
                        result = result + (text[i] - 97);
                    }
                }
            }

            return result;
        }
    }
}
