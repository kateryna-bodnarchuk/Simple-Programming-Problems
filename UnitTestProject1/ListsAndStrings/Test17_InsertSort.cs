using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Implement Insert Sort
    /// </summary>
    [TestClass]
    public class Test17_InsertSort
    {
        int[] InsertionSort(int[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                int temp = a[i];

                while (j >= 0 && temp < a[j])
                {
                    a[j + 1] = a[j];
                    j--; ;
                }
                a[j + 1] = temp;
            }
            return a;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var a = new int[] { 6, 2, 3, 1, 4, 5 };
            Assert.IsTrue(InsertionSort(a).SequenceEqual(new[] { 1, 2, 3, 4, 5, 6 }));
        }
    }
}
