using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;

namespace Problema2UnitTest
{
    [TestClass]
    public class EvenValuesTest
    {
        [TestMethod]
        public void EvenValues_True()
        {
            OperationController controller = new OperationController();

            bool expcected = true;
            bool actual = controller.IsEvenValue(2);
            Assert.AreEqual(expcected, actual);

            expcected = true;
            actual = controller.IsEvenValue(524);
            Assert.AreEqual(expcected, actual);
        }

        [TestMethod]
        public void EvenValues_False()
        {
            OperationController controller = new OperationController();

            bool expcected = false;
            bool actual = controller.IsEvenValue(3);
            Assert.AreEqual(expcected, actual);

            expcected = false;
            actual = controller.IsEvenValue(555);
            Assert.AreEqual(expcected, actual);
        }
    }
}
