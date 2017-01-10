using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class NumberController
    {
        public double ReverseNumber(double pNumberToReverse)
        {
            string stringNumber = pNumberToReverse.ToString();
            char[] charNumberArray = stringNumber.ToArray();

            StringBuilder newReverseNumber = new StringBuilder();
            for (int numLenght = charNumberArray.Length - 1; numLenght >= 0; numLenght--)
            {
                newReverseNumber.Append(charNumberArray[numLenght]);
            }

            string tempReverseNumber = newReverseNumber.ToString();
            double reverseNumber = double.NaN;
            double.TryParse(tempReverseNumber, out reverseNumber);

            return reverseNumber;
        }

        public List<double> GetDivisorsBetween(double pNumber, double pLowestNumber, double pHighestNumber)
        {
            List<double> divisors = GetDivisors(pNumber);
            List<double> divisorsHighersThanNumber = new List<double>();
            foreach (double divisor in divisors)
            {
                if (divisor < pHighestNumber && divisor > pLowestNumber)
                {
                    divisorsHighersThanNumber.Add(divisor);
                }
            }
            return divisorsHighersThanNumber;
        }

        public List<double> GetDivisorsLowersThan(double pNumber, double pHighestNumber)
        {
            List<double> divisors = GetDivisors(pNumber);
            List<double> divisorsHighersThanNumber = new List<double>();
            foreach (double divisor in divisors)
            {
                if (divisor < pHighestNumber)
                {
                    divisorsHighersThanNumber.Add(divisor);
                }
            }

            return divisorsHighersThanNumber;
        }

        public List<double> GetDivisorsHighersThan(double pNumber, double pLowestNumber)
        {
            List<double> divisors = GetDivisors(pNumber);
            List<double> divisorsHighersThanNumber = new List<double>();
            foreach (double divisor in divisors)
            {
                if (divisor > pLowestNumber)
                {
                    divisorsHighersThanNumber.Add(divisor);
                }
            }

            return divisorsHighersThanNumber;
        }

        public List<double> GetDivisors(double pNumber)
        {
            List<double> results = new List<double>();
            for (int divisor = 2; divisor < pNumber; divisor++)
            {
                if (IsMultiple(pNumber, divisor))
                {
                    results.Add(divisor);
                }
            }
            return results;
        }


        public bool IsPalindrome(double pPalindrome)
        {
            double reverseNumber = ReverseNumber(pPalindrome);

            return pPalindrome == reverseNumber;
        }

        public int Length(double pNumber)
        {
            if (double.IsNaN(pNumber))
            {
                return 0;
            }
            else
            {
                return pNumber.ToString().Length;
            }
        }

        public bool IsMultiple(double pDividen, double pDivisor)
        {
            double result = pDividen % pDivisor;
            return result == 0 && !double.IsNaN(result);
        }
    }
}
