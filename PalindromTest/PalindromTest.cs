using NUnit.Framework;

namespace PalindromTest
{
    public class PalindromTest
    {
        [TestCase("Otto", true)]
        [TestCase("Anna", true)]
        [TestCase("Hans", false)]
        [TestCase("OTTTO", true)]
        [TestCase("abcd", false)]
        [TestCase("A man a plan a canal Panama", true)]
        public void IsPalindromTest(string input, bool expected)
        {
            bool actual = PalindromStack.IsPalindrom(input);

            Assert.AreEqual(expected, actual);
        }
    }
}