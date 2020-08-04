using NUnit.Framework;
using System.Collections.Generic;
namespace MyMath.Tests
{
    public class Tests
    {
        List<int> lista = new List<int>() {10, 15, 0, -3, 288, 100, 3};
        List<int> lista2 = new List<int>() {};
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SuccessTest()
        {
            int n = Operations.Max(lista);
            Assert.AreEqual(288, n);
        }

        [Test]
        public void EmptyList()
        {
            int n = Operations.Max(lista2);
            Assert.AreEqual(0, n);
        }
    }
}