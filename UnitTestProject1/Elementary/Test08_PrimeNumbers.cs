using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.Elementary
{
    [TestClass]
    public class Test08_PrimeNumbers
    {
        bool IsPrime(int i)
        {
            if (i == 1) return false;
            if (i == 2) return true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
        }

        List<int> GetPrimes(int to)
        {
            var list = new List<int>();
            for (int i = 1; i < to; i++)
            {
                if (IsPrime(i)) list.Add(i);
            }
            return list;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(GetPrimes(10).SequenceEqual(new int[] { 2, 3, 5, 7 }));
        }
    }
}
