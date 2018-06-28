using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test2Plues2()
        {
            Assert.IsTrue(2 + 2 == 4);
            Assert.IsFalse(2 + 2 == 5);
        }

        [TestMethod]
        public void TestWrong()
        {
            var data = new List<int>() { 3, 2, 6, 8, 1 };
            MySort(data);
            Assert.IsTrue(data.SequenceEqual(new[] { 1, 2, 3, 6, 8 }));
        }

        void MySort(List<int> a)
        {
            a.Sort();
        }
    }
}
