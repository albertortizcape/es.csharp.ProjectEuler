using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem3;

namespace Problem3UnitTest
{
    [TestClass]
    public class PrimeNumbersTest
    {
        [TestMethod]
        public void PrimeNumber_True()
        {
            NumberOperationsController controller = new NumberOperationsController();
            bool expected = true;
            bool actual = controller.IsPrimeNumber(11);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = controller.IsPrimeNumber(977);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeNumber_False()
        {
            NumberOperationsController controller = new NumberOperationsController();
            bool expected = false;
            bool actual = controller.IsPrimeNumber(3333);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = controller.IsPrimeNumber(1422);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = controller.IsPrimeNumber(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeNumber_Zero()
        {
            NumberOperationsController controller = new NumberOperationsController();
            bool expected = false;
            bool actual = controller.IsPrimeNumber(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeNumber_One()
        {
            NumberOperationsController controller = new NumberOperationsController();
            bool expected = false;
            bool actual = controller.IsPrimeNumber(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
