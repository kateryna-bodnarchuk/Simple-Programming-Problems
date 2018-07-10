using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write function that reverses a list, preferably in place.
    /// </summary>
    [TestClass]
    public class Test02_Reverse
    {
        List <int> Reverse(List <int> b)
        {
            var list = new List <int>(b);
            var middle = list.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                int j = list.Count - 1 - i;
                var temp = b[i];
                b[i] = b[j];
                b[j] = temp;
            }
            return b;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var b = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            Assert.IsTrue(Reverse(b).SequenceEqual (new[] { 7, 6, 5, 4, 3, 2, 1}));
        }
    }
}
