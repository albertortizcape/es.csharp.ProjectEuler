using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem4;

namespace Problem4UnitTest
{
    [TestClass]
    public class IsPalindromeTest
    {
        [TestMethod]
        public void IsPalindrome_True()
        {
            NumberController controller = new NumberController();
            bool expected = true;
            double palindrome = 101;
            bool actual = controller.IsPalindrome(palindrome);
            Assert.AreEqual(expected, actual);

            expected = true;
            palindrome = 123321;
            actual = controller.IsPalindrome(palindrome);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindrome_False()
        {
            NumberController controller = new NumberController();
            bool expected = true;
            double palindrome = 102;
            bool actual = controller.IsPalindrome(palindrome);
            Assert.AreNotEqual(expected, actual);

            expected = true;
            palindrome = 12345321;
            actual = controller.IsPalindrome(palindrome);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindrome_Zero()
        {
            NumberController controller = new NumberController();
            bool expected = true;
            double palindrome = 00;
            bool actual = controller.IsPalindrome(palindrome);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void IsPalindrome_NaN()
        {
            NumberController controller = new NumberController();
            bool expected = false;
            double palindrome = double.NaN;
            bool actual = controller.IsPalindrome(palindrome);
            Assert.AreEqual(expected, actual);
        }
    }
}
