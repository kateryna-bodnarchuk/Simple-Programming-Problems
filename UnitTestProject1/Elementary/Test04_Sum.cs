using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.Elementary
{
    /// <summary>
    /// Write a program that asks the user for a number n and prints the sum of the numbers 1 to n.
    /// </summary>
    [TestClass]
    public class Test04_Sum
    {
        int Sum(int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += (i + 1);
            }
            return sum;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var a = Sum(5);
            Assert.IsTrue(Sum(5).Equals(15));
        }
    }
}
