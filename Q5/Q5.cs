using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            int[] frequency = new int[10];
            Console.WriteLine("Enter how many digits");
            int numberOfDigits = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfDigits; i++)
            {
                int digit = Convert.ToInt32(Console.ReadLine());
                frequency[digit] += 1;
            }
            int highest = frequency[0];
            int posHighest = 0;
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > highest)
                {
                    highest = frequency[i];
                    posHighest = i;
                }
            }
            Console.WriteLine($"The most frequent is {posHighest}");
            Console.ReadLine();
        }
    }
}
