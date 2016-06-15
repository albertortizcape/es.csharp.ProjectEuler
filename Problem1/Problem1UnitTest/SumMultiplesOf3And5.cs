using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace Problem1UnitTest
{
    [TestClass]
    public class SumMultiplesOf3And5
    {
        [TestMethod]
        public void IsMultipleOf5_TrueMultiple()
        {
            SumMultiplesController controller = new SumMultiplesController();

            int expected = 3;
            int limit = 4;
            int actual = controller.SumMultiplesOf3And5(limit);
            Assert.AreEqual(expected, actual);

            expected = 23;
            limit = 10;
            actual = controller.SumMultiplesOf3And5(limit);
            Assert.AreEqual(expected, actual);
        }
    }
}
