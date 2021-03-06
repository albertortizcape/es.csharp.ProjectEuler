﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem3;

namespace Problem3UnitTest
{
    [TestClass]
    public class MultiplesNumbersTest
    {
        [TestMethod]
        public void MultiplesNumbers_True()
        {
            // Dividend
            // Divisor
            // Quotient
            NumberOperationsController controller = new NumberOperationsController();
            bool expected = true;
            bool actual = controller.IsMultiple(10, 5);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = controller.IsMultiple(333, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplesNumbers_False()
        {
            NumberOperationsController controller = new NumberOperationsController();
            bool expected = false;
            bool actual = controller.IsMultiple(7, 8);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = controller.IsMultiple(100, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        // [ExpectedException(typeof(DivideByZeroException), "Undefined result when you divide by 0")]
        public void MultiplesNumbers_Zero()
        {
            // Double division by Zero will return a NaN.
            NumberOperationsController controller = new NumberOperationsController();
            bool expected = false;
            bool actual = controller.IsMultiple(10, 0);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = controller.IsMultiple(0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        // [ExpectedException(typeof(DivideByZeroException), "Undefined result when you divide by 0")]
        public void MultiplesNumbers_NaN()
        {
            // Double division by Zero will return a NaN.
            NumberOperationsController controller = new NumberOperationsController();
            bool expected = false;
            bool actual = controller.IsMultiple(double.NaN, 0);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = controller.IsMultiple(100, double.NaN);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = controller.IsMultiple(double.NaN, double.NaN);
            Assert.AreEqual(expected, actual);
        }
    }
}
