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
            int[,] halvedMatrix = new int[,]{{0, 1, 2}, {3, 4, 5}, {6, 7, 8}};
            Assert.AreEqual(Matrix.Divide(testMatrix, 0), null);
            Assert.AreEqual(Matrix.Divide(testMatrix, 2), halvedMatrix);
            Assert.AreEqual(Matrix.Divide(null, 0), null);
        }
    }
}