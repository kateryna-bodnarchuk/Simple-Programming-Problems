using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    [TestClass]
    public class Test03_Check
    {
        int Find(List<int> b, int value)
        {
            var list = new List<int>(b);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var b = new List<int>() { 5, 21, 63, 100, 47, 95, 57 };
            Assert.IsTrue(Find(b, 100) >= 0);
        }
    }
    
}
