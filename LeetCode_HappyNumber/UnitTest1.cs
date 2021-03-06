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
            Assert.AreEqual(true, Solution.IsHappy(7));
        }

        [TestMethod]
        public void Input_2_Should_Be_False()
        {
            Assert.AreEqual(false, Solution.IsHappy(2));
        }

        [TestMethod]
        public void Input_19_Should_Be_True()
        {
            Assert.AreEqual(true,Solution.IsHappy(19));
        }

        [TestMethod]
        public void Input_4_Should_Be_false()
        {
            Assert.AreEqual(false,Solution.IsHappy(4));
        }

    }

    public class Solution
    {
        public static bool IsHappy(int n)
        {
            if (n == 0)
                return false;
            var recordList = new int[5000]; //也可以找malloc動態陣列的使用方法
            var index = 0;
            while (!Contains(recordList,SumAll(n)))
            {
                recordList[index] = SumAll(n);
                n = SumAll(n);
                index++;
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
            for (var i = 0; i < n.ToString().Length; i++)
            {
                var c = n.ToString()[i];
                result += Pow(Convert.ToInt32(c.ToString()));
            }
            return result;
        }

        public static bool Contains(int[] array, int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==num)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
