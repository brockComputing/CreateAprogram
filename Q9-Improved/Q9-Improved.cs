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

            } while (num <= 0);
            string strNum = num.ToString();
            int countOfIncreasing = 0;
            int countOfDecreasing = 0;

            for (int i = 0; i < strNum.Length - 1; i++)
            {
                if (strNum[i] < strNum[i + 1])
                {
                    countOfIncreasing++;
                }
                else if (strNum[i] > strNum[i + 1])
                {
                    countOfDecreasing++;
                }
            }
            if (countOfDecreasing == countOfIncreasing && countOfDecreasing != 0)
            {
                Console.WriteLine("perfectly bouncy");
            }
            else if (countOfDecreasing != 0 && countOfIncreasing != 0)
            {
                Console.WriteLine("bouncy");
            }
            else
            {
                Console.WriteLine("Not a bouncy number");
            }
            Console.ReadLine();
        }
    }
}
