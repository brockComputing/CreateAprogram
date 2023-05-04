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
            Console.WriteLine("Enter the first word");
            string first = Console.ReadLine();
            Console.WriteLine("Enter the second word");
            string second = Console.ReadLine(); 
            bool isOk = false;
            // loop through first
            for (int i = 0; i < first.Length; i++)
            {
                string letterFromFirst = first.Substring(i, 1);
                isOk = false;
                for (int j = 0; j < second.Length; j++)
                {
                    if (letterFromFirst == second.Substring(j,1))
                    {
                        second = second.Remove(j, 1);
                        isOk = true;
                        break;
                    }
                }
                if (!isOk)
                {
                    break;
                }
            }
            if (isOk)
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
