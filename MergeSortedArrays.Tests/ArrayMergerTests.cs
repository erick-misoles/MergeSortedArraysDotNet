using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergeSortedArrays.Helpers;

namespace MergeSortedArrays.Tests
{
    [TestClass]
    public class ArrayMergerTests
    {
        [TestMethod]
        public void MergeSortedArrays_Ints_MergesCorrectly()
        {
            int[] a = { 1, 3, 5 };
            int[] b = { 2, 4, 6 };

            var result = ArrayMerger.MergeSortedArrays(a, b);

            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6 }, result);
        }

        [TestMethod]
        public void MergeSortedArrays_EmptyAndNonEmpty_ReturnsNonEmpty()
        {
            int[] a = { };
            int[] b = { 1, 2 };

            var result = ArrayMerger.MergeSortedArrays(a, b);

            CollectionAssert.AreEqual(new[] { 1, 2 }, result);
        }

        [TestMethod]
        public void MergeSortedArrays_BothEmpty_ReturnsEmpty()
        {
            int[] a = { };
            int[] b = { };

            var result = ArrayMerger.MergeSortedArrays(a, b);

            CollectionAssert.AreEqual(new int[] { }, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSortedArrays_Null_Throws()
        {
            int[] a = null;
            int[] b = { 1 };

            ArrayMerger.MergeSortedArrays(a, b);
        }
    }
}
