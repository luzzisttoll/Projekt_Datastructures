using Common;
using Datastructures;
using NUnit.Framework;
using Sorting;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SortAlgorithmTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
     
        [Test]
        public void TestStrategyPatternBubbleSort_InsertNumbers1865_ReturnRightOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(new BubbleSort());
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
    }
}