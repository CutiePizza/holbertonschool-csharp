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

        [Test]
        [TestCase("helo", 5)]
        public void NullArgument(int num1, int num2)
        {
            var n = MyMath.Operations.Add(num1, num2);
            Console.WriteLine(n);
            Assert.AreEqual(NullArgument, n);
        }
    }
}