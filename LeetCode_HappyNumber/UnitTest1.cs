using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_HappyNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0_Should_Be_False()
        {
            Assert.AreEqual(false, Solution.IsHappy(0));
        }

        [TestMethod]
        public void Input_1_Should_Be_True()
        {
            Assert.AreEqual(true, Solution.IsHappy(1));
        }

        [TestMethod]
        public void Pow_Input_2_Should_Be_4()
        {
            Assert.AreEqual(4,Solution.Pow(2));
        }
    }

    public class Solution
    {
        public static bool IsHappy(int n)
        {
            if (n == 1)
            {
                return true;
            }
            return false;
        }


        public static int Pow(int n)
        {
            return n * n;
        }
    }
}
