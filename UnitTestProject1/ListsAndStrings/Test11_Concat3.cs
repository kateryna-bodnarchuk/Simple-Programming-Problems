using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function that merges two sorted lists into a new sorted list. [1,4,6],[2,3,5] → [1,2,3,4,5,6]. 
    /// You can do this quicker than concatenating them followed by a sort.
    /// </summary>
    [TestClass]
    public class Test11_Concat3
    {
        int [] MyConcat(int [] a, int[] b)
        {
            if (b.Length == 0) return a;

            var result = new int[a.Length + b.Length];
            int aIndex = 0; int bIndex = 0; int resultIndex = 0;

            while (resultIndex < result.Length)
            {
                if (aIndex < a.Length)
                {
                    if (bIndex < b.Length)
                    {
                        if (a[aIndex] < b[bIndex])
                        {
                            result[resultIndex] = a[aIndex];
                            aIndex++;
                        }
                        else //(b[rightIndex] <= a[leftIndex])
                        {
                            result[resultIndex] = b[bIndex];
                            bIndex++;
                        }
                    }
                    else
                    {
                        result[resultIndex] = a[aIndex];
                        aIndex++;
                    }
                }
                else
                {
                    result[resultIndex] = b[bIndex];
                    bIndex++;
                }
                resultIndex++;
            }
            return result;
        }
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = new int[] { 1, 4 };
            int[] b = new int[] { 2, 3, 5 };
            var c = MyConcat(a, b);
            Assert.IsTrue(MyConcat(a,b).SequenceEqual(new int [] { 1, 2, 3, 4, 5 }));
        }
    }
}
