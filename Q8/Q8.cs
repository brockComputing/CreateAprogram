using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Q8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string theWord = Console.ReadLine();
            // check for length
            if (CheckLen(theWord) && CheckCase(theWord) && CheckUnique(theWord)
                && CheckAscii(theWord))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("inValid");
            }
            Console.ReadLine();
        }

        private static bool CheckAscii(string theWord)
        {
            int asciiCount = 0;
            for (int i = 0; i < theWord.Length; i++)
            {
                asciiCount += theWord[i];
            }
            if (asciiCount >= 420 && asciiCount <= 600)
            {
                return true;
            }
            Console.WriteLine("ascii count out of range");
            return false;
        }

        private static bool CheckUnique(string theWord)
        {
            string currentChar = "";
            string tempSting = theWord;
            for (int i = 0; i < theWord.Length; i++)
            {
                //currentChar = theWord.Substring(i, 1);
                currentChar = theWord[i].ToString();
                tempSting = theWord.Remove(i);
                if (tempSting.Contains(currentChar))
                {
                    Console.WriteLine("duplicates");
                    return false;
                }
            }
            return true;
        }

        private static bool CheckCase(string theWord)
        {
            string copy = theWord;
            if (theWord == copy.ToUpper())
            {
                return true;
            }
            Console.WriteLine("not upper");
            return false;
        }

        private static bool CheckLen(string theWord)
        {
            if (theWord.Length >= 5 && theWord.Length <=7)
            {
                return true;
            }
            Console.WriteLine("Char count problem");
            return false;
        }
    }
}
