using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    [TestClass]
    public class Test12_Concat4
    {
        int[] MyConcat(int [] a)
        {
            int n = a.Length;
            int k = 2;
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
            int[] a = new int[] { 1, 2, 3, 4};
            var c = MyConcat(a);
            Assert.IsTrue(MyConcat(a).SequenceEqual(new int[] { 3, 4, 1, 2 }));
        }
    }
}
