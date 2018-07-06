using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Elementary
{
    [TestClass]
    public class Test09_Gess
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testHelper = new TestHelper();
            var game = new Game(secret: 5, log: new Action<string>(testHelper.SaveString));
            var match1Result = game.Match(3);
            Assert.IsFalse(match1Result);
            Assert.AreEqual("My number is bigger", testHelper.Message);
        }

        class TestHelper
        {
            public string Message;

            public void SaveString(string message)
            {
                Message = message;
            }
        }
    }
}
