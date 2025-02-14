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
            if (countOfDecreasing != 0 && countOfIncreasing == 0)
            {
                Console.WriteLine("Not bouncy");
            }
            else if (countOfIncreasing != 0 && countOfDecreasing == 0)
            {
                Console.WriteLine("not a bouncy number");
            }
            else if (countOfIncreasing !=0 && countOfDecreasing != 0 && countOfIncreasing != countOfDecreasing)
            {
                Console.WriteLine("bouncy");
            }
            else
            {
                Console.WriteLine("perfectly bouncy");
            }
           
            Console.ReadLine();
        }
    }
}
