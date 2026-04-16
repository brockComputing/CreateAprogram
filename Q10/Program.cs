using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of columns");
            int columns = Convert.ToInt32(Console.ReadLine());
            string plainText = "";
            Console.WriteLine("enter the plain text");
            plainText = Console.ReadLine();
            // remove all non  alpha numeric characters
            string temp = "";
            foreach (char c in plainText)
            {
                if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(c.ToString().ToUpper()))
                {
                    temp += c;
                }
            }
            Console.WriteLine(temp);
            int start = 0;
            int currentPos = 0;
            while (start < columns)
            {
                currentPos = start;
                while (currentPos < temp.Length)
                {
                    Console.Write(temp[currentPos]);
                    currentPos+= columns;
                }
                start++ ;
            }
            Console.ReadLine();
        }
    }
}
