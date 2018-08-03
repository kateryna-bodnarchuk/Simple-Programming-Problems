using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    ///<summary>
    ///Implement Quick sort
    ///</summary>
    [TestClass]
    public class Test17_QuickSort
    {
        int [] Sort (int [] a)
        {
            QuickSort(a, 0, a.Length - 1);
            return a;
        }

        void QuickSort(int[] a, int i, int j)
        {
            if (i < j)
            {
                int q = SortPart(a, i, j);
                QuickSort(a, i, q - 1);
                QuickSort(a, q + 1, j);
            }
        }
        int SortPart(int[] a, int i, int j)
        {
            int x = a[j];
            int minValue = i - 1;

            for (int k = i; k < j; k++)
            {
                if (a[k] <= x)
                {
                    minValue++;
                    Swap(a, k, minValue);
                }
            }
            Swap(a, j, minValue + 1);
            return minValue + 1;
        }
        void Swap(int[] a, int k, int minValue)
        {
            int temp = a[k];
            a[k] = a[minValue];
            a[minValue] = temp;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var a = new [] { 6, 2, 3, 1, 4, 5 };
            Assert.IsTrue(Sort(a).SequenceEqual(new[] { 1, 2, 3, 4, 5, 6 }));
        }
    }
} 

