using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mega_Project_List
{
    class Text
    {
        /// <summary>
        /// Fizz Buzz - 
        /// Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number 
        /// and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”.
        /// </summary>
        public void FizzBuzz()
        {
            for (int i = 1; i <= 100 ; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Reverse a String - Enter a string and the program will reverse it and print it out.
        /// </summary>
        /// <param name="s"></param>
        public void ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);
        }

        /// <summary>
        /// Pig Latin - Pig Latin is a game of alterations played on the English language game. 
        /// To create the Pig Latin form of an English word the initial consonant sound is transposed to the end of the word and an ay is affixed 
        /// (Ex.: "banana" would yield anana-bay).
        /// </summary>
        public void PigLatin(string s)
        {
            //TODO apply consonant cluster rules as a final, more difficult program (e.g. smile = "iles-may")
            var vowels = new List<char>()
            {
                'a', 'e', 'i', 'o', 'u'
            };

            char[] array = s.ToCharArray();

            if(vowels.Contains(array[0]))
            {
                string finalString = s + "-ay";
                Console.WriteLine(finalString);
            }
            else
            {
                string part = s.Substring(1);
                string part2 = array[0] + "ay";
                string finalString = part + "-" + part2;
                Console.WriteLine(finalString);
            }

        }

        /// <summary>
        /// Count Vowels - Enter a string and the program counts the number of vowels in the text. 
        /// For added complexity have it report a sum of each vowel found.
        /// </summary>
        /// <param name="s"></param>
        public void CountVowels(string s)
        {
            var vowels = new Dictionary<char, int>()
            {
                {'a', 0 },
                {'e', 0 },
                {'i', 0 },
                {'o', 0 },
                {'u', 0 }
            };

            // total vowels
            int total = 0;

            s.ToLower();
            char[] array = s.ToCharArray();

            foreach (char item in array)
            {
                if (vowels.ContainsKey(item))
                {
                    total += 1;
                    vowels[item] += 1;
                }
            }

            for (int i = 0; i < vowels.Count; i++)
            {
                if (vowels.ElementAt(i).Value > 0)
                {
                    Console.WriteLine("Vowel {0} occurs {1} time(s).",
                    vowels.ElementAt(i).Key,
                    vowels.ElementAt(i).Value
                    );
                }

            }
            Console.WriteLine("Total vowels: {0}", total);
        }
    }
}
