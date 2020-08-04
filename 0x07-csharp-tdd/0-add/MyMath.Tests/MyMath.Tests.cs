using NUnit.Framework;
using MyMath;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TwoIntegers()
        {
            var n =  MyMath.Operations.Add(5, 6);
            Assert.AreEqual(11, n);
        }

        [Test]
        public void TwoZeros()
        {
            var n =  MyMath.Operations.Add(0, 0);
            Assert.AreEqual(0, n);
        }

        [Test]
        public void NegativeAndPositive()
        {
            var n =  MyMath.Operations.Add(-2, 5);
            Assert.AreEqual(3, n);
        }

        [Test]
        public void BothNegatives()
        {
            var n =  MyMath.Operations.Add(-2, -6);
            Assert.AreEqual(-8, n);
        }
    }
}