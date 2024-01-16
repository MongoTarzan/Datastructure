using NUnit.Framework;

namespace StringMirroredTest
{
    public class StringMirroredTest
    {
        [TestCase("hallo","ollah",0)]
        [TestCase("anna","anna",0)]
        [TestCase("", "anna", -1)]
        [TestCase("abcde","edabc",2)]
        [TestCase("abcde","edcba",0)]

        public void TestStringMirrored(string str1, string str2, int expected)
        {
            int actual = StringMirrorChecker.StringMirrored(str1, str2);

            Assert.AreEqual(expected, actual);
        }
    }
}