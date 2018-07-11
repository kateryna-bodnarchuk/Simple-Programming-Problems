using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function that concatenates two lists. [a,b,c], [1,2,3] → [a,b,c,1,2,3]
    /// </summary>
    [TestClass]
    public class Test09_Concat1
    {
        object[] MyConcat (object[] a, object[] b)
        {
            var result = new object[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                result[i + a.Length] = b[i];
            }
            return result;
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(MyConcat(new object[] { "a", "b", "c" }, new object[] { 1, 2, 3 })
                    .SequenceEqual(new object[] { "a", "b", "c", 1, 2, 3}));
        }
    }
}
