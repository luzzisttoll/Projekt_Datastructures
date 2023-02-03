using Datastructures;
using NUnit.Framework;
using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTests
{
    public class InsertionSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStrategyPatternInsertionSort_InsertNumbers1865_ReturnRightOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(SortFactory.StrategyGenerator("InsertionSort"));
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
        public void TestInsertionSort_InsertOneNumber_ReturnReverseOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(SortFactory.StrategyGenerator("InsertionSortInverse"));
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
