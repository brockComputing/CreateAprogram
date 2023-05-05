using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkB
{
    internal class B
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what number in the Harshard numbers do you want");
            int harshPos = 0;
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
            Console.ReadLine();
        }

        private static bool Harshard(int currentNumber)
        {
            bool isHarsh = false;
            string digString = currentNumber.ToString();
            int total = 0;
            foreach (var item in digString)
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
