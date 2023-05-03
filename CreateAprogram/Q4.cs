using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAprogram
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word");
            string first = Console.ReadLine();
            Console.WriteLine("Enter the second word");
            string second = Console.ReadLine();
            bool isOK = true;
            // loop through first
            for (int i = 0; i < first.Length; i++)
            {
                string currentLetterFromFirst = first[i].ToString();
                // loop through the second
                isOK = false;
                for (int j  = 0; j < second.Length; j++)
                {
                    if (currentLetterFromFirst == second[j].ToString())
                    {
                        second = second.Remove(j,1);
                        isOK = true;
                        break;
                    }
                }
            }
            if (isOK)
            {
                Console.WriteLine("good");
            }
            else
            {
                Console.WriteLine("bad");
            }
            Console.ReadLine();

        }
    }
}
