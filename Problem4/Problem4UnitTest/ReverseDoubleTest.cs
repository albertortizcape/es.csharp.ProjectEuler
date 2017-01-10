using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem4;

namespace Problem4UnitTest
{
    [TestClass]
    public class ReverseDoubleTest
    {
        [TestMethod]
        public void ReverseDouble_True()
        {
            NumberController controller = new NumberController();
            double expected = 101;
            double actual = controller.ReverseNumber(expected);
            Assert.AreEqual(expected, actual);

            expected = 123321;
            actual = controller.ReverseNumber(expected);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseDoubelWithDecimals_True()
        {
            NumberController controller = new NumberController();
            double expected = 10.01;
            double actual = controller.ReverseNumber(expected);
            Assert.AreEqual(expected, actual);

            expected = 1234.4321;
            actual = controller.ReverseNumber(expected);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseDoubel_Zero()
        {
            NumberController controller = new NumberController();
            double expected = 0;
            double actual = controller.ReverseNumber(expected);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseDoubel_NaN()
        {
            NumberController controller = new NumberController();
            double expected = double.NaN;
            double actual = controller.ReverseNumber(expected);
            Assert.AreEqual(expected, actual);
        }


        // It should be funny if some method uses an infinity double....
        //[TestMethod]
        //public void ReverseDoubel_Infinity()
        //{
        //    NumberController controller = new NumberController();
        //    double expected = double.PositiveInfinity;
        //    double actual = controller.ReverseNumber(expected);
        //    Assert.AreEqual(expected, actual);

        //    expected = double.NegativeInfinity;
        //    actual = controller.ReverseNumber(expected);
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
