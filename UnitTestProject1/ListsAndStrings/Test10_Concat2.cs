using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function that combines two lists by alternatingly taking elements, 
    /// e.g. [a,b,c], [1,2,3] → [a,1,b,2,c,3].
    /// </summary>
    [TestClass]
    public class Test10_Concat2
    {
        int Max(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }

        object[] MyConcat(object[] a, object[] b)
        {
            var result = new object[a.Length + b.Length];
            int j = 0;
            for (int i = 0; i < Max(a.Length, b.Length); i++)
            {
                if (i < a.Length)
                {
                    result[j] = a[i];
                    j++;
                }
                if (i < b.Length)
                {
                    result[j] = b[i];
                    j++;
                }
            }
            return result;
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(MyConcat(new object[] { "a", "b" }, new object[] { 1 })
                    .SequenceEqual(new object[] { "a", 1, "b",}));
        }
    }
}
     
