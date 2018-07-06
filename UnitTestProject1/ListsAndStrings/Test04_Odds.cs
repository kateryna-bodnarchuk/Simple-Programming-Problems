using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    [TestClass]
    public class Test04_Odds
    {
        bool IsOdd (int x)
        {
            for (int j = 0; j < x; j++)
            {
                if (j % 2 != 0)
                {
                    return true;
                }
            }
            return true;
        }

        List<int> OddNumbers(int size)
        {
            var list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                if (IsOdd(i)) list.Add(i);
            }
            return list;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var o = OddNumbers(8);
            Assert.IsTrue(OddNumbers(8).SequenceEqual(new int[] { 2, 4, 6, 8 }));
        }
    }
}
