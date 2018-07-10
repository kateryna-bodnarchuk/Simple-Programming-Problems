using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1.Elementary
{
    /// <summary>
    /// Write a program that prints a multiplication table for numbers up to 12.
    /// </summary>
    [TestClass]
    public class Test07_MultiplicationTable
    {
        int[] Multipl(int size, int jMax)
        {
            var a = new int[jMax];
            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j < jMax; j++)
                {
                    int product = i * (j + 1);
                    a[j] = product;
                }
            }
            return a;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var m = Multipl(2, 13);
            Assert.IsTrue(m.SequenceEqual(new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26}));
        }
    }
}

