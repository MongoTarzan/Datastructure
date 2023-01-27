using NUnit.Framework;

namespace QuickSortTest
{
    public class QuickSortTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QuicksortAlgorithm_ValidInput_ArraySort()
        {
           
            int[] arr = { 3, 8, 5, 2, 1, 9, 7 };
            int[] expected = { 1, 2, 3, 5, 7, 8, 9 };

            QuickSort.QuicksortAlgorithm(arr, 0, arr.Length - 1);

            Assert.AreEqual(expected, arr);
        }

        [Test]
        public void QuicksortAlgorithm_SingleElementArray_DoesNotChange()
        {
           
            int[] arr = { 5 };
            int[] expected = { 5 };

            QuickSort.QuicksortAlgorithm(arr, 0, arr.Length - 1);

            Assert.AreEqual(expected, arr);
        }

        [Test]
        public void QuicksortAlgorithm_NegativeInput_ArraySort()
        {

            int[] arr = { -3, -8, -5, 2, 1, 9, 7 };
            int[] expected = { -8, -5, -3, 1, 2, 7, 9 };

            QuickSort.QuicksortAlgorithm(arr, 0, arr.Length - 1);

            Assert.AreEqual(expected, arr);
        }
    }
}