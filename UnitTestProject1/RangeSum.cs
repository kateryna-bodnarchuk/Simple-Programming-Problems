using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class RangeSum
    {
        public static int SumIterative(int max)
        {
            var sum = 0;
            for (int i = 1; i <= max; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int SumRecursive(int max)
        {
            if (max <= 1) return max;
            else return SumRecursive(max - 1) + max;
        }

        public static int SumRecursiveteTail(int max)
        {
            return SumRecursiveteTailCore(sum: 0, current: 0, max: max);
        }

        public static int SumRecursiveteTailCore(int sum, int current, int max)
        {
            var sumUpdated = sum + current;
            if (current == max) return sumUpdated;

            return SumRecursiveteTailCore(sumUpdated, current + 1, max);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var data = new Tuple<int, int>[]
            {
                //new Tuple<int, int>(0, 0),
                //new Tuple<int, int>(1, 1),
                new Tuple<int, int>(2, 3),
                new Tuple<int, int>(3, 6),
                new Tuple<int, int>(4, 10),
            };
            foreach (var item in data)
            {
                Assert.AreEqual(item.Item2, SumIterative(item.Item1));
                Assert.AreEqual(item.Item2, SumRecursive(item.Item1));
                Assert.AreEqual(item.Item2, SumRecursiveteTail(item.Item1));
            }
        }
    }
}
