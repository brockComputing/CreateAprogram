using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            string compressedText = "";
            int countOfLetter = 1;
            string currentLetter = "";
            Console.WriteLine("Enter the text to compress");
            string originalText = Console.ReadLine();
            int pos = 0;
            currentLetter = originalText[0].ToString();
            while (pos < originalText.Length -1)
            {
                if (currentLetter != originalText[pos +1].ToString())
                {
                    compressedText = compressedText + currentLetter + countOfLetter;
                    currentLetter = originalText[pos + 1].ToString();
                    countOfLetter = 1;
                    pos ++;
                }
                else
                {
                    pos++;
                    countOfLetter++;
                }
            }
            compressedText = compressedText + currentLetter + countOfLetter;
            Console.WriteLine(compressedText);
            Console.ReadLine(); 
        }
    }
}
