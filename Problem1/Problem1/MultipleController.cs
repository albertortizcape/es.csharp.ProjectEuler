using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class MultipleController
    {
        public bool IsMultipleOf3(int naturalNumber)
        {
            return (naturalNumber % 3) == 0;
        }

        public bool IsMultipleOf5(int naturalNumber)
        {
            return (naturalNumber % 5) == 0;
        }
    }
}
