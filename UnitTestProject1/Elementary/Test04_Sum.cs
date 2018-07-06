using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.Elementary
{
    [TestClass]
    public class Test04_Sum
    {
        int[] Sum(int size)
        {
            int sum = 0;
            var a = new int[size];
            for (int i = 0; i < size; i++)
            {
                sum += (i + 1);
                a[i] = sum;
            }
            return a;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var a = Sum(6);
            Assert.IsTrue(Sum(6).SequenceEqual(new[] { 1, 3, 6, 10, 15, 21} ));
        }
    }
}
