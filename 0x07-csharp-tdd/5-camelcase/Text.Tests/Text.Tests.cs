using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string s = "yasmineIsCool";
            int n = Str.CamelCase(s);
            Assert.AreEqual(3, n);
        }
        [Test]
        public void Test2()
        {
            string s = "yasmine Is Cool";
            int n = Str.CamelCase(s);
            Assert.AreEqual(3, n);
        }

        [Test]
        public void Test3()
        {
            string s = "yasmine Is Very Cool";
            int n = Str.CamelCase(s);
            Assert.AreEqual(4, n);
        }

        [Test]
        public void Test4()
        {
            string s = "sonya Can't Do Her HomeWork";
            int n = Str.CamelCase(s);
            Assert.AreEqual(6, n);
        }

        [Test]
        public void Test5()
        {
            string s = "";
            int n = Str.CamelCase(s);
            Assert.AreEqual(1, n);
        }

        [Test]
        public void Test6()
        {
            string s = "hi";
            int n = Str.CamelCase(s);
            Assert.AreEqual(1, n);
        }

        [Test]
        public void Test7()
        {
            string s = "hi You";
            int n = Str.CamelCase(s);
            Assert.AreEqual(2, n);
        }

        [Test]
        public void Test8()
        {
            string s = "hi YouYou 12";
            int n = Str.CamelCase(s);
            Assert.AreEqual(3, n);
        }
    }
}