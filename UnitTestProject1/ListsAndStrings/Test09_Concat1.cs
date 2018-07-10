using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.ListsAndStrings
{
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
                result[i] = b[i];
            }
            return result;
        }
        [TestMethod]
        public void TestMethod1()
        {
            List<object> a = new List<object>() { "a", "b", "c" };
            List<object> b = new List<object>() { 1, 2, 3 };

           Assert.(MyConcat(a,b))(a.Concat(b).ToString);

        }
    }
}
