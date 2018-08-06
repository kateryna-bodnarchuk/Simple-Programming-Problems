using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Implement Merge Sort
    /// </summary>
    [TestClass]
    public class Test17_MergeSort
    {
        int [] Sort(int[] a)
        {
            MergeSort(a, 0, a.Length - 1);
            return a;
        }

        void MergeSort(int[] a, int left, int right)
        {
            if (left == right) return;
            var middle = (left + right) / 2;
            MergeSort(a, left, middle);
            MergeSort(a, middle + 1, right);
            Merge(a, left, middle, right);
        }

        void Merge(int[] a, int left, int middle, int right)
        {
            var n1 = middle - left + 1;
            var l = new int[n1 + 1];
            l[l.Length - 1] = int.MaxValue;
            for (int i = 0; i < n1; i++)
            {
                l[i] = a[left + i];
            }
            var n2 = right - middle;
            var r = new int[n2 + 1];
            r[r.Length - 1] = int.MaxValue;
            for (int i = 0; i < n2; i++)
            {
                r[i] = a[middle + i + 1];
            }
            int leftSource = 0;
            int rightSource = 0;
            for (int i = left; i <= right; i++)
            {
                if (l[leftSource] <= r[rightSource])
                {
                    a[i] = l[leftSource];
                    leftSource++;
                }
                else
                {
                    a[i] = r[rightSource];
                    rightSource++;
                }
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            var a = new int[] { 6, 2, 3, 1, 4, 5 };
            Assert.IsTrue(Sort(a).SequenceEqual(new[] { 1, 2, 3, 4, 5, 6 }));
        }
    }
}