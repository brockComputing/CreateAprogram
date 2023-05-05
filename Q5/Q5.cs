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
            //
            int[] frequency = new int[10];
            Console.WriteLine("Enter how many digits");
            int numberOFDigits = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOFDigits; i++)
            {
                Console.WriteLine("Enter a digit");
                int digit = Convert.ToInt32(Console.ReadLine());
                frequency[digit] = frequency[digit] + 1;
            }
            // find the highest number in the array
            // output its position
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
            // check if multimodal
            int countOfHighest = 0;
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] == highest)
                {
                    countOfHighest++;
                }
            }
            if (countOfHighest > 1)
            {
                Console.WriteLine("multimodal");
            }
            else
            {
                Console.WriteLine($"{posHighest} is the most frequent");
            }
            Console.ReadLine();
        }
    }
}
