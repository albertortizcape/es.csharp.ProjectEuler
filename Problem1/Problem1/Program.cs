using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

                Find the sum of all the multiples of 3 or 5 below 1000.
            */

            SumMultiplesController controller = new SumMultiplesController();
            int sum10 = controller.SumMultiplesOf3And5(10);
            Console.WriteLine("The sum of the first 10 multiple values of 3 and 5 is " + sum10);

            int sum1000 = controller.SumMultiplesOf3And5(1000);
            Console.WriteLine("The sum of the first 1000 multiple values of 3 and 5 is  " + sum1000);

            Console.Read();
            return;
        }
    }
}
