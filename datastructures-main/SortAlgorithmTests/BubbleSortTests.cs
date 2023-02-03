using Common;
using Datastructures;
using NUnit.Framework;
using SortingAlgorithms;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SortAlgorithmTest
{
    public class BubbleSortTests
    {
        [SetUp]
        public void Setup()
        {
        }
     
        [Test]
        public void TestStrategyPatternBubbleSort_InsertNumbers1865_ReturnRightOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(SortFactory.StrategyGenerator("BubbleSort"));
            linkedList.insertLast(1);
            linkedList.insertLast(8);
            linkedList.insertLast(5);
            linkedList.insertLast(6);
            linkedList.Sort();
            Assert.AreEqual(linkedList.head.data, 1);
            Assert.AreEqual(linkedList.head.next.data, 5);
            Assert.AreEqual(linkedList.head.next.next.data, 6);
            Assert.AreEqual(linkedList.head.next.next.next.data, 8);
        }

        [Test]
        public void TestStrategyPatternBubbleSortInverse_InsertNumbers1865_ReturnRightOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(SortFactory.StrategyGenerator("BubbleSortInverse"));
            linkedList.insertLast(1);
            linkedList.insertLast(8);
            linkedList.insertLast(5);
            linkedList.insertLast(6);
            linkedList.Sort();
            Assert.AreEqual(linkedList.head.data, 8);
            Assert.AreEqual(linkedList.head.next.data, 6);
            Assert.AreEqual(linkedList.head.next.next.data, 5);
            Assert.AreEqual(linkedList.head.next.next.next.data, 1);
        }
    }
}