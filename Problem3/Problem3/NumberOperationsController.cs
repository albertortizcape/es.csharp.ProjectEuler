using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class NumberOperationsController
    {
        public bool IsMultiple(int pDividen, int pDivisor)
        {
            return (pDividen % pDivisor) == 0;
        }
    }
}
