using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function that rotates a list by k elements. 
    /// For example [1,2,3,4,5,6] rotated by two becomes [5,6,3,4,1,2].
    /// </summary>
    [TestClass]
    public class Test12_Concat4Var1
    {
        int[] MyConcat(int [] a, int k)
        {
            int n = a.Length;
            var middle = n / 2;

            for (int leftStartIndex = 0; leftStartIndex < middle; leftStartIndex += k)
            {
                int[] temp = new int[k];
                for (int blockIndex = 0; blockIndex < k; blockIndex++)
                {
                    temp[blockIndex] = a[leftStartIndex + blockIndex];
                }

                var rightStartIndex =  n - k - leftStartIndex;
                for (int blockIndex = 0; blockIndex < k; blockIndex++)
                {   

                    a[leftStartIndex + blockIndex] = a[rightStartIndex + blockIndex];
                    a[rightStartIndex + blockIndex] = temp[blockIndex];
                }
            }
            return a;
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6};
            var c = MyConcat(a, 2);
            Assert.IsTrue(c.SequenceEqual(new int[] { 5, 6, 3, 4, 1, 2 }));
        }
    }
}
