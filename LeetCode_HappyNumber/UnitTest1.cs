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
            Assert.AreEqual(false,Solution.IsHappy(0));
        }
    }

    public class Solution
    {
        public static bool IsHappy(int n)
        {
            throw new NotImplementedException();
        }
    }
}
