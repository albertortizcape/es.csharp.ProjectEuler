using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class OperationController
    {
        public int Sum(int pParam1, int pParam2)
        {
            return pParam1 + pParam2;
        }

        public bool IsEvenValue(int pValue)
        {
            return (pValue % 2) == 0;
        }
    }
}
