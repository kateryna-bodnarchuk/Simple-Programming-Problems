using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    [TestClass]
    public class Test02_Reverse
    {
        List <int> Test(int count)
        {
            var list = new List<int>(){ 2,3,5,9,10};
            var middle = count / 2;
            for (int i = 0; i < middle; i++)
            {
                int j = count - 1 - i;
                var temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
            return list;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Test(5).SequenceEqual(new[] { 10, 9, 5, 3, 2}));
        }
    }
}
