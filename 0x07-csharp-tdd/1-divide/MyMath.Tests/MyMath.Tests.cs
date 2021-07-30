using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Test cases for 1-divide</summary>
    public class Tests
    {
        [Test]
        public void DivideTest1()
        {
            int[,] testMatrix = new int[,]{{0, 2, 4}, {6, 8, 10}, {12, 14, 16}};
            Assert.AreEqual(Matrix.Divide(testMatrix, 0), null);
        }
    }
}