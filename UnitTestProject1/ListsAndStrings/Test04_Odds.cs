using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function that returns the elements on odd positions in a list.
    /// </summary>
    [TestClass]
    public class Test04_Odds
    {

        List<int> OddNumbers(List<int> a)
        {
            var list = new List<int>();
            for (int i = 1; i < a.Count; i += 2)
            {
                list.Add(a[i]);
            }
            return list;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var a = new List<int>() { 15, 21, 63, 10, 47, 95, 57 };
            var b = OddNumbers(a);
            Assert.IsTrue(OddNumbers(a).SequenceEqual(new[] { 21, 10, 95 }));
        }
    }
}
