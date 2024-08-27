using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number");
            int decNum = Convert.ToInt32(Console.ReadLine());
            string decStr = "";
            do
            {
                decStr = (decNum % 2) + decStr;
                decNum = decNum / 2;
            } while (decNum != 0);
            Console.WriteLine(decStr);
            Console.ReadLine();
        }
    }
}
