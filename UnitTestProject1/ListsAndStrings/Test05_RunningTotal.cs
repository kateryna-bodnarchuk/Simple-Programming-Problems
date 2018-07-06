using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    [TestClass]
    public class Test05_RunningTotal
    {
        int Calculate(List<int> a)
        {
            var list = new HashSet<int>(a);
            int sum = list.Sum();
            return sum;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var a = new List<int>() { 5, 21, 63, 10, 47, 95, 57 };
            Assert.IsTrue(Calculate(a).Equals(298));
        }
    }
}