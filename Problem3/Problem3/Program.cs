using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                The prime factors of 13195 are 5, 7, 13 and 29.

                What is the largest prime factor of the number 600851475143 ?
            */

            // First, start with the lowest factors and check if the biggest quotients are primes
            NumberOperationsController controller = new NumberOperationsController();
            double exerciseNumber = 600851475143;
            for (double factor = 2; factor < exerciseNumber; factor++)
            {
                if (controller.IsMultiple(exerciseNumber, factor))
                {
                    double result = exerciseNumber / factor;

                    //Check if the result is a prime number
                    if (controller.IsPrimeNumber(result))
                    {
                        Console.WriteLine("The biggest prime number which is factor of '" + exerciseNumber + "' is --> " + result);
                        break;
                    }
                }
            }

            Console.ReadLine();
            return;
        }
    }
}
