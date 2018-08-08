using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.ListsAndStrings
{
    [TestClass]
    public class Test16_Bases
    {
        int ConvertToBase(IList<int> a)
        {
            int result = 0;
            int multiplicator = 1;
            int baseNumber = 10;
            for (int i = a.Count - 1; i >= 0; i--)
            {
                result = result + a[i] * multiplicator;
                multiplicator = multiplicator * baseNumber;
            }
            return result;
        }

        List<int> ConvertBaseToBase(int number)
        {
            var baseNumber = 2;
            var result = new List<int>();
            while (number != 0)
            {
                result.Insert(0, number % baseNumber);
                number = number / baseNumber;
            }
            return result;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var a = new [] { 1, 2, 5 };
            Assert.IsTrue(ConvertToBase(a).Equals(125));
        }
        [TestMethod]
        public void TestMethod2()
        {
            var a = 20;
            Assert.IsTrue(ConvertBaseToBase(a).SequenceEqual(new [] { 1, 0, 1, 0, 0 }));
        }
    }
}
