using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
