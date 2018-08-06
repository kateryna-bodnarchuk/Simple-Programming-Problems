using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    [TestClass]
    public class Test17_BubbleSort
    {
            int [] BubbleSort(int [] a)
            {
                int n = a.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            int temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }
                    }
                }
                return a;
            }
        [TestMethod]
        public void TestMethod1()
        {
            var a = new[] { 6, 1, 3, 2, 5, 4 };
            Assert.IsTrue(BubbleSort(a).SequenceEqual(new[] { 1, 2, 3, 4, 5, 6 }));
        }

    }
    
}
