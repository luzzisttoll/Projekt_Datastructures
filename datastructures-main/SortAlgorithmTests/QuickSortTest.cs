using Common;
using Datastructures;
using NUnit.Framework;
using SortingAlgorithms;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SortAlgorithmTest
{
    public class QuicksortTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStrategyPatternQuickSort_InsertNumbers1865_ReturnRightOrder()
        {
            int[] arr = { 10, 80, 30, 90, 40, 50, 70 };
            int left = 0; 
            int right = arr.Length - 1;

            QuickSort quicksort = new QuickSort();

            quicksort.QuicksortMethod(arr, left, right);

            CollectionAssert.AreEqual(arr, new int[] { 10, 30, 40, 50, 70, 80, 90});
        }
    }
}
