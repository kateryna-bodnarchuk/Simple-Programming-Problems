using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Elementary
{
    /// <summary>
    /// Write a guessing game where the user has to guess a secret number. After every guess 
    /// the program tells the user whether their number was too large or too small.
    /// At the end the number of tries needed should be printed.
    /// I counts only as one try if they input the same number multiple times consecutively.
    /// </summary>
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
