using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Implement Selection Sort
    /// </summary>
    [TestClass]
    public class Test17_SelectionSort
    {
        int[] SelectionSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[i])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = a[i];
                    a[i] = a[minIndex];
                    a[minIndex] = temp;
                }
            }
            return a;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var a = new int[] { 6, 2, 3, 1, 4, 5 };
            Assert.IsTrue(SelectionSort(a).SequenceEqual(new[] { 1, 2, 3, 4, 5, 6 }));
        }
    }
}
