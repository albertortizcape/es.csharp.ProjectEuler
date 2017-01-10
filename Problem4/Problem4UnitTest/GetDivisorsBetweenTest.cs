using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem4;

namespace Problem4UnitTest
{
    [TestClass]
    public class GetDivisorsBetweenTest
    {
        [TestMethod]
        public void GetDivisorsBetweenTest_True()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { 5 };
            List<double> actual = controller.GetDivisorsBetween(10, 2, 6);

            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() { 5, 10 };
            actual = controller.GetDivisorsBetween(20, 4, 11);
            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() { 10 };
            actual = controller.GetDivisorsBetween(20, 5, 11);
            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() { 5 };
            actual = controller.GetDivisorsBetween(20, 4, 10);
            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() { };
            actual = controller.GetDivisorsBetween(20, 10, 15);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDivisorsBetweenTest_Zero()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { };
            List<double> actual = controller.GetDivisorsBetween(0, 0, 0);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDivisorsBetweenTest_NaN()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { };
            List<double> actual = controller.GetDivisorsBetween(double.NaN, 0, 0);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
