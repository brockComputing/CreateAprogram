using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q6
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            List<int> harshlist = new List<int>();
            int num = 1;
            int count = 0;
            do
            {
                if (Harshad(num))
                {
                    harshlist.Add(num);
                    count++;
                }
                num++;
            } while (count <= 1000);
            Console.WriteLine("Enter the what harsh you want");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(harshlist[pos -1]);
            Console.ReadLine();

        }

        private static bool Harshad(int num)
        {
            bool isHarsh = false;
            string digString = num.ToString();
            int total = 0;
            foreach (var item in digString)
            {
                total += Convert.ToInt32(item.ToString());
            }
            if (num % total == 0)
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
