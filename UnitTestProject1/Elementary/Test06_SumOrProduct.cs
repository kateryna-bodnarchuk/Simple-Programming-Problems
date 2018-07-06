using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject1.Elementary
{
    [TestClass]
    public class Test06_SumOrProduct
    {
        int[] Sum(int value)
        {
            int sum = 0;
            var a = new int[value];
            for (int i = 0; i < value; i++)
            {
                sum += (i + 1);
                a[i] = sum;
            }
            return a;
        }

        int[] Product(int value)
        {
            int product = 1;
            var a = new int[value];
            for (int i = 0; i < value; i++)
            {
                product = product * (i + 1);
                a[i] = product;
            }
            return a;
        }
        int[] Answer(int b, int value, string ans)
        {
            if (ans == "yes")
            {
                return Sum(value);
            }
            else if (ans == "no")
            {
                return Product(value);
            }
            else return new int[0];
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Sum(5).SequenceEqual(new[] {1, 3, 6, 10, 15}));
            Assert.IsTrue(Product(5).SequenceEqual(new[] { 1, 2, 6, 24, 120 }));

            Assert.IsTrue(Answer(1, 5, "yes").SequenceEqual(new[] { 1, 3, 6, 10, 15 }));
            Assert.IsTrue(Answer(1, 5, "no").SequenceEqual(new[] { 1, 2, 6, 24, 120 }));

        }
    }
}

      
        
        
        


