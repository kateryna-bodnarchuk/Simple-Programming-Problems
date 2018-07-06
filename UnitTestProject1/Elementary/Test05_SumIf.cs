using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.Elementary
{
    [TestClass]

    public class Test05_SumIf
    {
        int[] Sum(int size)
        {
            var a = new int[size];
            int sum = 0;
            for (int i = 0; i < size; i++) 
            {
                sum += i + 1;
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    a[i] = sum;
                }
            }
            return a;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var a = Sum(5);
            Assert.IsTrue(a.SequenceEqual(new[] {1, 10}));
        }
    }
}
