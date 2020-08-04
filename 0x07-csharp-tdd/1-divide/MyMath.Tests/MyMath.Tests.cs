using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        int[,] m1 = new int[,]
                {
                    {2, 4, 8}, 
                    {10, 16, 12},
                    {5, 4, 10},
                    {4, 5, 6}
                };
        int[,] m2 = new int[,]
                {
                    {1, 2, 4}, 
                    {5, 8, 6},
                    {2, 2, 5},
                    {2, 2, 3}
                };
        int[,] m3 = new int[,]
                {
                    {-1, -2, -4}, 
                    {-5, -8, -6},
                    {-2, -2, -5},
                    {-2, -2, -3}
                };
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DivideByTwo()
        {
            int[,] newMat = Matrix.Divide(m1, 2);
            Assert.AreEqual(m2, newMat);
        }
     private static IEnumerable<TestCaseData> AddCases() {
        yield return new TestCaseData(new int[,]
                {
                    {2, 4, 8}, 
                    {10, 16, 12},
                    {5, 4, 10},
                    {4, 5, 6}
                } , 0 );
     }
        [Test, TestCaseSource("AddCases")]
        public void DivideByZero(int[,] m, int num)
        {
            Assert.Throws<DivideByZeroException>(() => throw new DivideByZeroException());
        }
   
        [Test]
        public void NullMatrix()
        {
            int[,] newMat = Matrix.Divide(null, 8);
            Assert.AreEqual(null, newMat);
        }

        [Test]
        public void DivideByNegative()
        {
            int[,] newMat = Matrix.Divide(m2, -1);
            Assert.AreEqual(m3, newMat);
        }
    }
}