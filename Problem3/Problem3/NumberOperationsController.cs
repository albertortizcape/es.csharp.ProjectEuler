using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class NumberOperationsController
    {
        public bool IsMultiple(double pDividen, double pDivisor)
        {
            double result = pDividen % pDivisor;
            return result == 0 && result != double.NaN;
        }

        public bool IsPrimeNumber(double pNumber)
        {
            bool isPrime = false;
            for (double divisor = 2; divisor < pNumber; divisor++)
            {
                if (!IsMultiple(pNumber, divisor))
                {
                    isPrime = true;
                }
                else
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
