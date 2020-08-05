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
        public void Unique1()
        {
            string s = "aabddee";
            int n = Str.UniqueChar(s);
            Assert.AreEqual(2, n);
        }

        [Test]
        public void NotUnique1()
        {
            string s = "aabbddee";
            int n = Str.UniqueChar(s);
            Assert.AreEqual(-1, n);
        }

        [Test]
        public void Unique3()
        {
            string s = "ines";
            int n = Str.UniqueChar(s);
            Assert.AreEqual(0, n);
        }

        [Test]
        public void Unique4()
        {
            string s = "";
            int n = Str.UniqueChar(s);
            Assert.AreEqual(-1, n);
        }

        [Test]
        public void Unique5()
        {
            string s = "hahahap";
            int n = Str.UniqueChar(s);
            Assert.AreEqual(6, n);
        }
    }
}