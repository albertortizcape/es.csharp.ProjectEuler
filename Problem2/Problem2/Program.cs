﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
				https://projecteuler.net/problem=2
			
                Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

                1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

                By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
            */

            int previousTerm = 1;
            int nextTerm = 2;

            int sumEvenValues = 0;

            OperationController controller = new OperationController();
            while (nextTerm <= 4000000)
            {
                // Check if the next term is even, if so, add it to the sumEvenValue
                if (controller.IsEvenValue(nextTerm))
                {
                    sumEvenValues = controller.Sum(sumEvenValues, nextTerm);
                }

                // Get the next value
                int tempNextValue = controller.Sum(previousTerm, nextTerm);

                // Change the two lastest terms
                previousTerm = nextTerm;
                nextTerm = tempNextValue;
            }

            Console.WriteLine("The sum of the even-valued terms from Fibonacci sequence below four million is " + sumEvenValues);
            Console.Read();

            return;
        }
    }
}
