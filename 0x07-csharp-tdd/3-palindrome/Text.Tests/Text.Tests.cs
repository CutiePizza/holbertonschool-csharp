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
        public void PalinsdromeWithCharactersTest()
        {
            string s = "A man, a plan, a canal: Panama.";
            bool isPali = Str.IsPalindrome(s);
            Assert.AreEqual(true, isPali);
        }

        [Test]
        public void PalinsdromeNormalTest()
        {
            string s = "Bob";
            bool isPali = Str.IsPalindrome(s);
            Assert.AreEqual(true, isPali);
        }

        [Test]
        public void EmptyStringTest()
        {
            string s = "";
            bool isPali = Str.IsPalindrome(s);
            Assert.AreEqual(true, isPali);
        }

        [Test]
        public void IntranetStringTest()
        {
            string s = "Racecar";
            bool isPali = Str.IsPalindrome(s);
            Assert.AreEqual(true, isPali);
        }

        [Test]
        public void IntranetStringTest2()
        {
            string s = "level";
            bool isPali = Str.IsPalindrome(s);
            Assert.AreEqual(true, isPali);
        }

        [Test]
        public void NotPalindromeTest2()
        {
            string s = "Tunisia";
            bool isPali = Str.IsPalindrome(s);
            Assert.AreEqual(false, isPali);
        }
    }
}