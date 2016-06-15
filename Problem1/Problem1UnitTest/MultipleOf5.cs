using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace Problem1UnitTest
{
    [TestClass]
    public class MultipleOf5
    {
        [TestMethod]
        public void IsMultipleOf5_TrueMultiple()
        {
            MultipleController controller = new MultipleController();

            bool expected = true;
            int naturalNumber = 5;
            bool actual = controller.IsMultipleOf5(naturalNumber);
            Assert.AreEqual(expected, actual);

            expected = true;
            naturalNumber = -5500;
            actual = controller.IsMultipleOf5(naturalNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsMultipleOf5_FalseMultiple()
        {
            MultipleController controller = new MultipleController();

            bool expected = false;
            int naturalNumber = 13;
            bool actual = controller.IsMultipleOf5(naturalNumber);
            Assert.AreEqual(expected, actual);

            expected = false;
            naturalNumber = 6;
            actual = controller.IsMultipleOf5(naturalNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsMultipleOf5_ZeroMultiple()
        {
            MultipleController controller = new MultipleController();

            bool expected = true;
            int naturalNumber = 0;
            bool actual = controller.IsMultipleOf5(naturalNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
