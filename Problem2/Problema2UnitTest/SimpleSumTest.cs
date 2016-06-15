using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;

namespace Problema2UnitTest
{
    [TestClass]
    public class SimpleSumTest
    {
        [TestMethod]
        public void SimpleSum_PositiveValues()
        {
            OperationController controller = new OperationController();

            int expcected = 3;
            int actual = controller.Sum(1, 2);
            Assert.AreEqual(expcected, actual);

            expcected = 8;
            actual = controller.Sum(3, 5);
            Assert.AreEqual(expcected, actual);

            expcected = 1000;
            actual = controller.Sum(223, 777);
            Assert.AreEqual(expcected, actual);
        }

        [TestMethod]
        public void SimpleSum_NegativeValues()
        {
            OperationController controller = new OperationController();

            int expcected = 0;
            int actual = controller.Sum(1, -1);
            Assert.AreEqual(expcected, actual);

            expcected = -5;
            actual = controller.Sum(-2, -3);
            Assert.AreEqual(expcected, actual);
        }
    }
}
