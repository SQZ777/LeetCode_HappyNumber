using System;
using System.Collections.Generic;
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
            Assert.AreEqual(4, Solution.Pow(2));
        }


        [TestMethod]
        public void SumAll_Input_10_Should_Be_1()
        {
            Assert.AreEqual(1, Solution.SumAll(10));
        }

        [TestMethod]
        public void Input_10_Should_Be_True()
        {
            Assert.AreEqual(true, Solution.IsHappy(10));
        }

        [TestMethod]
        public void Input_7_Should_Be_True()
        {
            Assert.AreEqual(true,Solution.IsHappy(7));
        }

    }

    public class Solution
    {
        public static bool IsHappy(int n)
        {
            if (n == 0)
                return false;
            var recordList = new List<int>();
            while (!recordList.Contains(SumAll(n)) || SumAll(n) != 1)
            {
                recordList.Add(SumAll(n));
                n = SumAll(n);
            }
            if (n == 1)
                return true;
            return false;
        }


        public static int Pow(int n)
        {
            return n * n;
        }

        public static int SumAll(int n)
        {
            var result = 0;
            foreach (var c in n.ToString())
            {
                result += Pow(Convert.ToInt32(c.ToString()));
            }
            return result;
        }
    }
}
