using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Q7
    {
        static void Main(string[] args)
        {
            string vowels = "aeiou";
            string enteredText = "";
            Console.WriteLine("enter a word");
            enteredText = Console.ReadLine();
            int startpos = 0;
            int endpos = enteredText.Length - 1;
            while (startpos < endpos)
            {
                if (vowels.Contains(enteredText[startpos]))
                {
                    while (endpos > startpos)
                    {
                        if (vowels.Contains(enteredText[endpos]))
                        {
                            // swap
                            string first = enteredText[startpos].ToString();
                            string second = enteredText[endpos].ToString();
                            enteredText = enteredText.Remove(startpos, 1);
                            enteredText = enteredText.Insert(startpos, second);
                            enteredText = enteredText.Remove(endpos, 1);
                            enteredText = enteredText.Insert(endpos,first);
                            // exit loop
                            endpos--;
                            break;
                        }
                        endpos--;
                    }
                }
                startpos++;
            }
            Console.WriteLine(enteredText);
            Console.ReadLine();
        }

       
    }
}
