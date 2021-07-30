using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Test cases for 2-max_int</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<int> testList = new List<int>();
            testList.Add(3);
            testList.Add(42);
            testList.Add(4);
            Assert.AreEqual(Operations.Max(testList), 42);
        }
    }
}