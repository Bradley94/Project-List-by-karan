using System;

namespace Mega_Project_List
{
    class Program
    {
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
            algorithms.SieveOfEratosthenes(100);
        }
    }
}
