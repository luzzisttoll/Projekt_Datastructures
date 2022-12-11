using Common;
using Datastructures;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestProject
{
    public class LinkedListTest
    {
        public Node head;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSLLCount_AddItems_ReturnCorrectCount()
        {
            var myLL = new SingleLinkedList();
            myLL.insertLast(1);
            myLL.insertLast(1);
            myLL.insertLast(1);
            myLL.insertLast(1);
            Assert.AreEqual(4, myLL.count());
        }

        [Test]
        public void SingleLinkedListTest_DeleteItem_ReturnCorrectCount()
        {
            var linkedList = new SingleLinkedList();
            linkedList.insertLast(0);
            linkedList.insertLast(2);
            linkedList.DeleteNode(1);
            Assert.AreEqual(1, linkedList.count());
        }

        [Test]
        public void SSLTest_NodeExists_ReturnsNode()
        {
            var linkedList = new SingleLinkedList();
            var getnode = linkedList.GetNode(1);
            Assert.AreEqual(getnode, null);
            linkedList.insertLast(1);
            linkedList.insertLast(2);
            linkedList.insertLast(3);
            getnode = linkedList.GetNode(1);
            Assert.AreNotEqual(getnode, null);
        }

        [Test]
        public void SSLTest_SwitchNodes_ReturnCorrectOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.insertLast(1);
            linkedList.insertLast(2);
            linkedList.insertLast(5);
            linkedList.SwitchNode3(new Node(1, null), new Node(5, null));
            Assert.AreEqual(5, linkedList.head.data);
        }
    }
}