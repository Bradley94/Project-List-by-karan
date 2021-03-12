using System;
using System.Collections.Generic;
using System.Text;

namespace Mega_Project_List
{
    // https://github.com/karan/Projects#numbers
    class Numbers
    {
        /// <summary>
        /// Find PI to the Nth Digit - 
        /// Enter a number and have the program generate PI up to that many decimal places. 
        /// Keep a limit to how far the program will go.
        /// </summary>
        /// <param name="n"></param>
        public void FindPiToTheNthDigit(int n)
        {
            // Manual interpretation 100 digits limit
            decimal Pivalue = 3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067m;
            Console.WriteLine(Decimal.Round(Pivalue, n));

            // Using Math Class
            // Console.WriteLine(Math.Round(Math.PI, n));
        }

        /// <summary>
        /// Find e to the Nth Digit - 
        /// Just like the previous problem, but with e instead of PI. 
        /// Enter a number and have the program generate e up to that many decimal places. 
        /// Keep a limit to how far the program will go.
        /// </summary>
        /// <param name="n"></param>
        public void eToTheNthDigit(int n)
        {
            // Using Math Class
            // Console.WriteLine(Math.Round(Math.E, n));

            // Manual 10000 digits of e, 151 d.p.
            decimal eValue = 2.718281828459045235360287471352662497757247093699959574966967627724076630353547594571382178525166427m;
            Console.WriteLine(Decimal.Round(eValue, n));
        }

        /// <summary>
        /// Fibonacci Sequence - 
        /// Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
        /// </summary>
        /// <param name="n"></param>
        public void FibonacciSequence(int n)
        {
            // Regular version
            //int x = 0; // first value
            //int y = 1; // second value
            //int total = 0;

            //Console.Write(x + " " + y + " ");
            //for (int i = 0; i < n; i++)
            //{
            //    total = x + y;
            //    Console.Write(total + " ");

            //    x = y;
            //    y = total;
            //}

            // List version
            List<int> values = new List<int>();
            values.Add(0);
            values.Add(1);
            Console.Write(values[0] + " " + values[1] + " ");

            for (int i = 0; i < n; i++) 
            {
                values.Add(values[i] + values[i + 1]);
                Console.Write(values[i + 2] + " ");
            }
        }

        /// <summary>
        /// Prime Factorization - 
        /// Have the user enter a number and find all Prime Factors (if there are any) and display them.
        /// </summary>
        /// <param name="n"></param>
        public void PrimeFactorisation(int n)
        {
            // primes up to 101, can add to this later if desired https://www.mathsisfun.com/prime_numbers.html
            // prime factorisation calculator to test results
            // https://www.calculatorsoup.com/calculators/math/prime-factors.php
            int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101};
            List<int> factors = new List<int>();

            foreach (var item in primes)
            {
                if(n % item == 0) 
                {
                    factors.Add(item);
                    if((IsPrime(n / item)) == true) // test if remainder is prime 
                    {
                        factors.Add(n / item);
                        break;
                    }
                    else
                    {
                        n /= item;
                    }
                }
            }
            factors.Sort();
            factors.ForEach(Console.WriteLine);        

            // test for prime number
            static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(number));

                for (int i = 3; i <= boundary; i += 2)
                    if (number % i == 0)
                        return false;

                return true;
            }
        }

        /// <summary>
        /// Next Prime Number - 
        /// Have the program find prime numbers until the user chooses to stop asking for the next one.
        /// </summary>
        public void NextPrimeNumber()
        {
            bool looping = true;

            while(looping)
            {
                for (int i = 1; i < 1000000; i++)
                {
                    if (IsPrime(i) == true)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine("Type 'yes' to continue.");
                        string userContinue = Console.ReadLine();

                        if (userContinue.ToLower() == "yes")
                        {
                            continue;
                        }
                        else
                        {
                            looping = false;
                            break;
                        }
                    }
                }

                // test for prime number
                static bool IsPrime(int number)
                {
                    if (number <= 1) return false;
                    if (number == 2) return true;
                    if (number % 2 == 0) return false;

                    var boundary = (int)Math.Floor(Math.Sqrt(number));

                    for (int i = 3; i <= boundary; i += 2)
                        if (number % i == 0)
                            return false;

                    return true;
                }
            }
        }

        /// <summary>
        /// Find Cost of Tile to Cover W x H Floor - 
        /// Calculate the total cost of tile it would take to cover a floor plan of width and height, 
        /// using a cost [*and dimensions] entered by the user.
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void CostOfTile(decimal cost, int width, int height)
        {
            Console.WriteLine("Total cost of tiles for a floor of " + width + " width, " + height + " height, " + " at a cost of " + cost + " per tile: £" + (width * height) * cost);
        }

        /// <summary>
        /// Mortgage Calculator - 
        /// Calculate the monthly payments of a fixed term mortgage over given Nth terms at a given interest rate. 
        /// Also figure out how long it will take the user to pay back the loan. For added complexity, 
        /// add an option for users to select the compounding interval (Monthly, Weekly, Daily, Continually).
        /// </summary>
        /// <param name="years"> must be a decimal percentage e.g. 5% = 0.05 </param>
        /// <param name="interest"></param>
        /// <param name="houseValue"></param>
        public void MortgageCalculator(int years, decimal interest, int houseValue)
        {
            decimal interestOwed = (houseValue * interest) * years;
            Console.WriteLine("Interest owed = " + interestOwed);

            Console.WriteLine("Total payment = " + houseValue + interestOwed);
            Console.WriteLine("Monthly payment = " + (houseValue + interestOwed) / (years * 12));
           
        }

        /// <summary>
        /// Change Return Program - 
        /// The user enters a cost and then the amount of money given. 
        /// The program will figure out the change and the number of quarters, dimes, nickels, pennies needed for the change.
        /// *** Editing challenge to UK currency so 1p, 2p, 5p, 10p, 20p, 50p (leaving out £1 and £2) ***
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="money"></param>
        public void ChangeReturn(decimal cost, decimal money)
        {
            if(money < cost)
            {
                Console.WriteLine("Money must be greater than or equal to the cost of the product");
            }
            else
            {
                // Maths to ensure we always round down for money e.g. no such coin as £0.205 
                decimal costRounded = Math.Floor(cost * 100) / 100;
                decimal moneyRounded = Math.Floor(money * 100) / 100;

                // multiply values by 100 to simplify foreach maths
                int change = Convert.ToInt32((moneyRounded - costRounded) * 100);

                // array of coin values, can add 100 and 200 if desired (£1, £2)
                int[] coins = new int[6] { 50, 20, 10, 5, 2, 1 };

                Console.WriteLine("Change = " + change);
                foreach (var coin in coins)
                {
                    // could edit this to see all evenly divisible change options e.g. 100 = x2 50p or x5 20p etc
                    if(change % coin == 0)
                    {
                        Console.WriteLine("x" + (change / coin) + " " + coin + "p coins.");
                        break;
                    }
                    else
                    {
                        if(change / coin == 0)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("x" + (change / coin) + " " + coin + "p coins.");
                            change = change % coin;
                            Console.WriteLine("Change = " + change);
                        }               
                    }
                }

            }
        }   


    }
}
