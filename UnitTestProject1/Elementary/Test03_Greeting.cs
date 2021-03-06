﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Elementary
{
    /// <summary>
    /// Write a program that asks the user for their name and greets them with their name.
    /// Modify such that only the users Alice and Bob are greeted with their names.
    /// </summary>
    [TestClass]
    public class Test03_Greeting
    {
        public string Hello(string name)
        {
            var acceptableNames = new[] {"Alice", "Bob"};
            if (acceptableNames.Contains(name))
            {
                return ("Hello " + name + "!");
            }
            else
            {
                return ("Sorry, program will be closed");
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello Alice!", Hello("Alice"));
            Assert.AreEqual("Hello Bob!", Hello("Bob"));
            Assert.AreEqual("Sorry, program will be closed", Hello("John"));
        }

    }
}
