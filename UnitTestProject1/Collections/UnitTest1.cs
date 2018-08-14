using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KateCollection = global::Collections;

namespace UnitTestProject1.Collections
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmpty()
        {
            var collection = new KateCollection.List<int>();
            Assert.AreEqual(0, collection.Count);
        }

        [TestMethod]
        public void TestAddOne()
        {
            var collection = new KateCollection.List<int>();
            Assert.AreEqual(0, collection.Count);
            collection.Add(5);
            Assert.AreEqual(1, collection.Count);
            Assert.AreEqual(5, collection[0]);
        }

        [TestMethod]
        public void TestSetOne()
        {
            var collection = new KateCollection.List<int>();
            collection.Add(5);
            Assert.AreEqual(5, collection[0]);
            collection[0] = 7;
            Assert.AreEqual(7, collection[0]);
        }

        [TestMethod]
        public void TestAddMany()
        {
            var collection = new KateCollection.List<int>();
            collection.Add(3);
            collection.Add(5);
            collection.Add(7);
            Assert.AreEqual(3, collection[0]);
            Assert.AreEqual(5, collection[1]);
            Assert.AreEqual(7, collection[2]);
        }

        [TestMethod]
        public void TestForeach()
        {
            var collection = new KateCollection.List<int>();
            collection.Add(3);
            collection.Add(5);
            collection.Add(7);
            //foreach (int item in collection)
            //{
            //    /// My logic with item
            //}

            int index = 0;
            IEnumerator<int> enumerator = null;
            try
            {
                enumerator = collection.GetEnumerator();
                while (true)
                {
                    bool moveNextResult = enumerator.MoveNext();
                    if (moveNextResult)
                    {
                        int item = enumerator.Current;

                        if (index == 0) Assert.AreEqual(3, item);
                        else if (index == 1) Assert.AreEqual(5, item);
                        else if (index == 2) Assert.AreEqual(7, item);
                        else Assert.Fail();
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            finally
            {
                if (enumerator != null)
                {
                    enumerator.Dispose();
                }
            }
        }

        [TestMethod]
        public void TestCorruptedForeachFailed()
        {
            var collection = new KateCollection.List<int>
            {
                3
            };
            foreach (var item in collection)
            {
                try
                {
                    collection.Add(5);
                }
                catch (InvalidOperationException)
                {
                    return;
                }

                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestModifyAfterForeach()
        {
            var collection = new KateCollection.List<int>
            {
                3,
                5
            };
            foreach (var item in collection)
            {
            }
            collection.Add(7);
            Assert.AreEqual(3, collection.Count);
        }
    }
}
