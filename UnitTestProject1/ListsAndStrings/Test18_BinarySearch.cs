using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Implement binary search
    /// </summary>
    [TestClass]
    public class Test18_BinarySearch
    {
        bool BinarySearch(int [] a, int value)
        {
            int min = 0;
            int max = a.Length - 1;
            while (min <= max)
            {
                var middle = min + ((max - min) / 2);
                if (a[middle] > value)
                {
                    max = middle - 1;
                }
                else if (a[middle] < value)
                {
                    min = middle + 1;
                }
                else
                {
                    return true;
                }
            }
            return false;     
        }
        [TestMethod]
        public void TestMethod1()
        {
            var a = new int[] { 2, 5, 8, 10, 14, 25 };
            Assert.IsTrue(BinarySearch(a, 10));
        }
    }
}
