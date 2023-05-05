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
            int[] frequency = new int[10];
            Console.WriteLine("How many digits");
            int numberOfDigits = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfDigits; i++)
            {
                int digit = Convert.ToInt32(Console.ReadLine());
                frequency[digit]++;
            }
            int highest = frequency[0];
            int posHighest = 0;



            Console.ReadLine();
        }
    }
}
