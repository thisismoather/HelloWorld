using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GL;

namespace GL.Tests
{
    [TestClass]
    public class SimpleCalculationsTest
    {
        [TestMethod]
        public void UserCanAddTwoNumbers()
        {
            Assert.AreEqual(3, Program.Add(2, 2), "Addition of two numbers failed");
        }

        [TestMethod]
        public void UserCanSubtracTwoNumbers()
        {
            Assert.AreEqual(1, Program.Subtract(5, 4), "Subtraction of two numbers failed");
        }

        [TestMethod]
        public void UserCanMultiplyTwoNumbers()
        {
            Assert.AreEqual(6, Program.Multiply(3, 2), "Multiplication of two numbers failed");
        }
    }
}
