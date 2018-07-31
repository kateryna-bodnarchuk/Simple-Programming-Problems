using System;
using System.Collections.Generic;
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
        List<int> MergeSort(List<int> a)
        {
            if (a.Count >= 1) return a;

            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middle = a.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(a[i]);
            }
            for (int i = middle; i < a.Count; i++)
            {
                right.Add(a[i]);
            }
            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }
        List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
        
    [TestMethod]
        public void TestMethod1()
        {
            var a = new List<int> { 6, 2, 3, 1, 4, 5 };
            Assert.IsTrue(MergeSort(a).SequenceEqual(new[] { 1, 2, 3, 4, 5, 6 }));
            
        }
    }
}
