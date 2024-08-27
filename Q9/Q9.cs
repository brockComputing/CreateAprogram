using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    internal class Q9
    {
        static void Main(string[] args)
        {
            // bouncy numbers
            int num = 0;
            do
            {
                Console.WriteLine("enter a number");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num < 0);
            string strNum = num.ToString();
            int countOfIncreasing = 0;
            int countOfDecreasing = 0;
            bool increasing = true;
            bool decreasing = true;
            for (int i = 0; i < strNum.Length - 1; i++)
            {
                if (strNum[i] < strNum[i+1])
                {
                    decreasing = false;
                    countOfIncreasing++;
                }
                else if (strNum[i] > strNum[i+1])
                {
                    increasing = false;
                    countOfDecreasing++;
                }
            }
            if (!increasing && !decreasing)
            {
                if (countOfIncreasing == countOfDecreasing)
                {
                    Console.WriteLine("perfectly bouncy");
                }
                else
                {
                    Console.WriteLine("bouncy");
                }
            }
            else
            {
                Console.WriteLine("Not bouncy");
            }
            Console.ReadLine();
        }
    }
}
