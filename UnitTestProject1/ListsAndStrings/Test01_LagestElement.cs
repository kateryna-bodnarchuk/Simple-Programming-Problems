using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function that returns the largest element in a list.
    /// </summary>
    [TestClass]
    public class Test01_LagestElement
    {
        int Calculate(List<int> b)
        {
            var list = new List<int>(b);
            int max = list.Max();
            return max;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var b = new List<int>() { 5, 21, 63, 10, 47, 95, 57 };
            Assert.IsTrue(Calculate(b).Equals(95));
        }
    }
}
