using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkA
{
    internal class A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what position in the Harshard do you want");
            int harshPos = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int currentNumber = 0;
            do
            {
                currentNumber++;
                if (Harshard(currentNumber))
                {
                    count++;
                }
            } while (count < harshPos);
            Console.WriteLine(currentNumber);
            Console.ReadLine();
        }

        private static bool Harshard(int currentNumber)
        {
            bool isHarsh = false;
            int total = 0;
            string digitString = currentNumber.ToString();
            foreach (var item in digitString)
            {
                total += Convert.ToInt32(item.ToString());
            }
            if (currentNumber % total == 0)
            {
                isHarsh = true; 
            }
            else
            {
                isHarsh = false;
            }

            return isHarsh;
        }
    }
}
