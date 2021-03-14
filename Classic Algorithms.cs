using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mega_Project_List
{
    class Classic_Algorithms
    {
        /// <summary>
        /// Collatz Conjecture - 
        /// Start with a number n > 1. Find the number of steps it takes to reach one using the following process: 
        /// If n is even, divide it by 2. If n is odd, multiply it by 3 and add 1.
        /// </summary>
        /// <param name="n"></param>
        public void CollatzConjecture(int n)
        {
            int steps = 0;

            if(n <= 1) 
            {
                Console.WriteLine("Number must be greater than 1");
            }
            else
            {
                while (n > 1)
                {
                    if (n % 2 == 0)
                    {
                        n /= 2;
                        steps++;
                        Console.Write(n + " ");
                    }
                    else
                    {
                        n *= 3;
                        n += 1;
                        steps++;
                        Console.Write(n + " ");
                    }
                }
                Console.WriteLine("\nThis took " + steps + " steps.");
            }
        }

        /// <summary>
        /// Sieve of Eratosthenes - 
        /// The sieve of Eratosthenes is one of the most efficient ways to find all of the smaller primes (below 10 million or so).
        /// https://www.onlinemathlearning.com/sieve-eratosthenes.html explained
        /// https://www.youtube.com/watch?v=3Vbe0c4e6RY video for aid in algorithm logic
        /// </summary>
        /// <param name="n"></param>
        public void SieveOfEratosthenes(int n)
        {
            
            List<bool> prime = new List<bool>();
            // for i < length of our upperbound, fill prime list with all true as default
            for (int i = 0; i <= (n+1); i++)
            {
                prime.Add(true);
            }

            int p = 2; // start from the first prime 2
            while (p*p <= n) // ensure we only check n / 10 for composites
            {
                if (prime[p])
                {
                    for (int y = (p*2); y <= (n+1); y+=p) // check multiples
                    {
                        prime[y] = false; // mark off composites as false as per the sieve algorithm
                    }
                }
                p += 1;
            }
            prime[0] = false; // number 0 is not a prime
            prime[1] = false; // number 1 is not a prime
            int count = 0;
            // simple write of prime array results
            for (int j = 0; j <= (prime.Count - 1); j++)
            {
                if (prime[j] )
                {
                    count += 1;
                    Console.WriteLine(j);
                }
            }
            Console.WriteLine($"There are {count} primes up to {n}");
        }
        /// <summary>
        /// Implement two types of sorting algorithms:
        /// Part 1: Bubble sort
        /// https://www.geeksforgeeks.org/bubble-sort/
        /// </summary>
        /// <param name="arr"></param>
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j+1] = temp;
                    }
                }
            }

            // print array
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");           
            }
            Console.WriteLine("\nArray sorted");
        }

        /// <summary>
        /// Optimised Bubble sort - 
        /// Above always runs O(n^2), this prevents that by stopping the algorithm if no swap is made.
        /// </summary>
        /// <param name="arr"></param>
        public void BubbleSortOptimised(int[] arr)
        {
            bool swapped;
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // break if no two elements are swapped
                if (swapped == false)
                {
                    break;
                }
            }

            // print array
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nArray sorted");
        }


        /// <summary>
        /// Implement two types of sorting algorithms:
        /// Part 2: Merge sort
        /// </summary>
        /// <param name="arr"></param>
        public void MergeSort(int[] arr)
        {

        }
    }
}
