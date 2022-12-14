//IT213 Unit 5 Assignment 1 Part 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Key_Unit5_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";

            int current = 0;
            int blankPosition = 0;
            int wordCount = 0;

            for (int i=0 ; i<sentence.Length; i++)
            {
                current = i;
                string word;
                blankPosition = sentence.IndexOf(" ", current);

                if (blankPosition == -1)
                {
                    word = sentence.Substring(current);
                    i = sentence.Length;
                }
                else
                {
                    word = sentence.Substring(current, blankPosition - current);
                    i = blankPosition;
                }
                wordCount++;
                Console.WriteLine(wordCount + " " + word);
            }
            Console.WriteLine("Total word count " + wordCount);
            Console.ReadKey();
        }
    }
}