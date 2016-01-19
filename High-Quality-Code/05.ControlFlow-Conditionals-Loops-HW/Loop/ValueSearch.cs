using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    public class ValueSearch
    {
        public static void Main()
        {
        }

        public void CheckForValue(int valueToFind)
        {
            int[] valueSet = new int[100];
            int length = valueSet.Length;

            for (int i = 0; i < length; i++)
            {
                if (i % 10 == 0 && valueSet[i] == valueToFind)
                {
                    Console.WriteLine("Value found");
                    break;
                }

                Console.WriteLine(valueSet[i]);
            }
        }

    }
}
