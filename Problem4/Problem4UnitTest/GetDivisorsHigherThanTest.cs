using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem4;

namespace Problem4UnitTest
{
    [TestClass]
    public class GetDivisorsHigherThanTest
    {
        [TestMethod]
        public void GetDivisorsHigherThan_True()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { 5 };
            List<double> actual = controller.GetDivisorsHighersThan(10, 2);

            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() { 5, 10 };
            actual = controller.GetDivisorsHighersThan(20, 4);
            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() { 10 };
            actual = controller.GetDivisorsHighersThan(20, 5);
            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() {  };
            actual = controller.GetDivisorsHighersThan(20, 10);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDivisorsHigherThan_Zero()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { };
            List<double> actual = controller.GetDivisorsHighersThan(0, 0);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDivisorsHigherThan_NaN()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { };
            List<double> actual = controller.GetDivisorsHighersThan(double.NaN, 0);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
