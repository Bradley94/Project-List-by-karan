using System;

namespace Mega_Project_List
{
    class Program
    {
        /* Layout of the program is a bit inelegant but I wanted to be able to have all solutions in one program 
         * without making it too overbloated with files, so each section of the project list at https://github.com/karan/Projects
         * is its own class and the function calls are commented out below to display them for use.
        */

        static void Main(string[] args)
        {
            // https://github.com/karan/Projects main page

            Numbers numbers = new Numbers();
            // numbers.FindPiToTheNthDigit(7);
            // numbers.eToTheNthDigit(5);
            // numbers.FibonacciSequence(20);
            // numbers.PrimeFactorisation(387); 
            // numbers.NextPrimeNumber();
            // numbers.CostOfTile(3.55m, 15, 5);
            // numbers.MortgageCalculator(5, 0.05m, 100000);
            // numbers.ChangeReturn(7.37m, 36.89m);

            Classic_Algorithms algorithms = new Classic_Algorithms();
            // algorithms.CollatzConjecture(500);
            // algorithms.SieveOfEratosthenes(100);
            // algorithms.BubbleSort(new int[] { 50, 83, 39, 1, 2, 68, 5, 99, 12, 6, 19, 3, 2, 8 });
            // algorithms.BubbleSortOptimised(new int[] { 50, 83, 39, 1, 2, 68, 5, 99, 12, 6, 19, 3, 2, 8 });
        }
    }
}
