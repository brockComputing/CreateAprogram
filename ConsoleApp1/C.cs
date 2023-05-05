using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class C
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what harsh number do you want");
            int harhsPos = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int currentNumber = 0;
            do
            {
                currentNumber++;
                if (Harshad(currentNumber))
                {
                    count++;
                }
            } while (count < harhsPos);
            Console.WriteLine(currentNumber);
            Console.ReadLine();
        }

        private static bool Harshad(int currentNumber)
        {
            bool isHarsh = false;
            string digString = currentNumber.ToString();
            int total = 0;
            foreach (var item in digString)
            {
                total += Convert.ToInt32(item.ToString()); // adds up all the digits
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
