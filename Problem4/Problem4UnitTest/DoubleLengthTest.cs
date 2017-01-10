using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem4;

namespace Problem4UnitTest
{
    [TestClass]
    public class DoubleLengthTest
    {
        [TestMethod]
        public void DoubleLength_True()
        {
            NumberController controller = new NumberController();
            int expected = 2;
            int actual = controller.Length(10);
            Assert.AreEqual(expected, actual);

            expected = 5;
            actual = controller.Length(12345);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleLength_False()
        {
            NumberController controller = new NumberController();
            int expected = 2;
            int actual = controller.Length(101);
            Assert.AreNotEqual(expected, actual);

            expected = 5;
            actual = controller.Length(123456);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleLength_Zero()
        {
            NumberController controller = new NumberController();
            int expected = 1;
            int actual = controller.Length(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleLength_NaN()
        {
            NumberController controller = new NumberController();
            int expected = 0;
            int actual = controller.Length(double.NaN);
            Assert.AreEqual(expected, actual);
        }
    }
}
