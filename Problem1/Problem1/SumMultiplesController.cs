using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class SumMultiplesController
    {
        public int SumMultiplesOf3And5(int pNumberLimit)
        {
            MultipleController controller = new MultipleController();

            int suma = 0;
            for (int i = 0; i < pNumberLimit; i++)
            {
                if (controller.IsMultipleOf3(i) || controller.IsMultipleOf5(i))
                {
                    suma = suma + i;
                }
            }

            return suma;
        }
    }
}
