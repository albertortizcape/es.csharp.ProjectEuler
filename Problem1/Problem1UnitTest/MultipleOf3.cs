using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace Problem1UnitTest
{
    [TestClass]
    public class MultipleOf3
    {
        [TestMethod]
        public void IsMultipleOf3_TrueMultiple()
        {
            MultipleController controller = new MultipleController();

            bool expected = true;
            int naturalNumber = 3;
            bool actual = controller.IsMultipleOf3(naturalNumber);
            Assert.AreEqual(expected, actual);

            expected = true;
            naturalNumber = -333;
            actual = controller.IsMultipleOf3(naturalNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsMultipleOf3_FalseMultiple()
        {
            MultipleController controller = new MultipleController();

            bool expected = false;
            int naturalNumber = 1;
            bool actual = controller.IsMultipleOf3(naturalNumber);
            Assert.AreEqual(expected, actual);

            expected = false;
            naturalNumber = 10;
            actual = controller.IsMultipleOf3(naturalNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsMultipleOf3_Zero()
        {
            MultipleController controller = new MultipleController();

            bool expected = true;
            int naturalNumber = 0;
            bool actual = controller.IsMultipleOf3(naturalNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
