using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem4;

namespace Problem4UnitTest
{
    [TestClass]
    public class GetDivisorsTest
    {
        [TestMethod]
        public void GetDivisors_True()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { 2, 5 };
            List<double> actual = controller.GetDivisors(10);

            CollectionAssert.AreEqual(expected, actual);

            expected = new List<double>() { 2, 4, 5, 10 };
            actual = controller.GetDivisors(20);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDivisors_Zero()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() {  };
            List<double> actual = controller.GetDivisors(0);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDivisors_NaN()
        {
            NumberController controller = new NumberController();
            List<double> expected = new List<double>() { };
            List<double> actual = controller.GetDivisors(double.NaN);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
