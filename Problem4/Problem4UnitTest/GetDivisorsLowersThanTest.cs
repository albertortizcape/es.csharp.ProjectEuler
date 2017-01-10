using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem4;

namespace Problem4UnitTest
{
    [TestClass]
    public class GetDivisorsLowersThanTest
    {
        [TestMethod]
        public void GetDivisorsLowersThan_True()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { 2 };
            List<double> actual = controller.GetDivisorsLowersThan(10, 5);

            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() { 2, 4, 5 };
            actual = controller.GetDivisorsLowersThan(20, 10);
            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() { 2 };
            actual = controller.GetDivisorsLowersThan(20, 4);
            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() { };
            actual = controller.GetDivisorsLowersThan(20, 2);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDivisorsLowersThan_Zero()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { };
            List<double> actual = controller.GetDivisorsLowersThan(0, 0);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDivisorsLowersThan_NaN()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { };
            List<double> actual = controller.GetDivisorsLowersThan(double.NaN, 0);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
