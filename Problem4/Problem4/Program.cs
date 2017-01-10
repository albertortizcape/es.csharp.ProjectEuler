using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            https://projecteuler.net/problem=4

            A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

            Find the largest palindrome made from the product of two 3-digit numbers.

            */

            // First, get palindroms highers than 9009
            NumberController controller = new NumberController();
            double palindrome = 9009;
            bool found = false;
            while (!found)
            {
                if (controller.IsPalindrome(palindrome))
                {
                    // Second, get multiples of the palindrom until the two factors has 3 digits
                    List<double> divisorsList = controller.GetDivisorsBetween(palindrome, 99, 1000);

                    double divisorPairWith3digitNumber = double.NaN;
                    foreach (double divisor in divisorsList)
                    {
                        double dividend = palindrome / divisor;

                        if (controller.Length(dividend) == 3)
                        {
                            // get de result, if it is a 3 digits factor, you have a palindrom with 3 digits
                            //if (double.IsNaN(divisorPairWith3digitNumber))
                            //{
                            //    divisorPairWith3digitNumber = divisor;
                            //}
                            //else
                            //{
                            //    Console.WriteLine("The palindrom with two is " + palindrome);
                            //    found = false;
                            //    break;
                            //}
                        }
                    }
                }

                palindrome++;
            }

            Console.ReadLine();
            return;
        }
    }
}
