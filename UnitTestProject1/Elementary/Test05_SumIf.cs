using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject1.Elementary
{
    /// <summary>
    /// Write a program that asks the user for a number n and prints the sum of the numbers 1 to n.
    /// Modify  program such that only multiples of three or five are considered in the sum
    /// </summary>
    [TestClass]

    public class Test05_SumIf
    {
        int Sum (int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += (i + 1);
                }
            }
            return sum;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var b = Sum(5);
            Assert.IsTrue(b.Equals(5));
        }
    }
}
