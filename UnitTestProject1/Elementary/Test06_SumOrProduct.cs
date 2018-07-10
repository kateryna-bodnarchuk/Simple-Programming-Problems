using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject1.Elementary
{
    /// <summary>
    /// Write a program that asks the user for a number n and gives them the possibility 
    /// to choose between computing the sum and computing the product of 1,…,n.
    /// </summary>
    [TestClass]
    public class Test06_SumOrProduct
    {
        int Sum(int value)
        {
            int sum = 0;
            for (int i = 0; i < value; i++)
            {
                sum += (i + 1);
            }
            return sum;
        }
        int Product(int value)
        {
            int product = 1;
            for (int i = 0; i < value; i++)
            {
                product = product * (i + 1);
            }
            return product;
        }
        int Answer(int value, string ans)
        {
            if (ans == "yes")
            {
                return Sum(value);
            }
            else if (ans == "no")
            {
                return Product(value);
            }
            else return 0;
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Sum(5).Equals(15));
            Assert.IsTrue(Product(5).Equals(120));

            Assert.IsTrue(Answer(5, "yes").Equals(15));
            Assert.IsTrue(Answer(5, "no").Equals(120));
        }
    }
}

      
        
        
        


