using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            int num = 0;
            string ans = "y";
            while (ans == "y")
            {
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                if (num <= 1)
                {
                    Console.WriteLine("Not greater than 1");
                }
                else if (Prime(num))
                {
                    Console.WriteLine("Is prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
                Console.WriteLine("Another go y/n");
                ans = Console.ReadLine();
            }
        }

        private static bool Prime(int num)
        {

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
