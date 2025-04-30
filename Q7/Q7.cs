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
                            enteredText = enteredText.Insert(endpos, first);
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

            // possibly a better method is to record index of vowels in a list and the actual vowels found
            // in another list reverse one of the lists and then swap
            // this does not work

            //string vowels = "aeiou";
            //string enteredText = "";
            //Console.WriteLine("enter a word");
            //enteredText = Console.ReadLine();
            //List<int> indexes = new List<int>();
            //List<string> vowelsUsed = new List<string>();
            //// find the vowels and their indexes
            //int pos = 0;
            //foreach (var item in enteredText)
            //{
            //    if (vowels.Contains(item))
            //    {
            //        indexes.Add(pos);
            //        vowelsUsed.Add(item.ToString());
            //    }
            //    pos++;
            //}
            //List<int> reversedIndexed = indexes.ToList(); // a complete new copt
            //reversedIndexed.Reverse();
            //for (int i = 0; i < indexes.Count; i++)
            //{
            //    string currentChar = vowelsUsed[i];
            //    enteredText = enteredText.Remove(indexes[i], 1);
            //    enteredText = enteredText.Insert(reversedIndexed[i], currentChar);
            //}
            //Console.WriteLine(enteredText);
            Console.ReadLine();
        }

    }
}
