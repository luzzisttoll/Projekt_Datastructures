using Common;
using Datastructures;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DatastructureTests
{
    public class SingleLinkedListTest
    {
        public Node head;
        public Node tail;
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

        [Test]
        public void SSLTest_DeleteFirstNode_FirstIsNext()
        {
            var linkedList = new SingleLinkedList();
            linkedList.insertLast(1);
            linkedList.insertLast(2);
            linkedList.insertLast(5);
            linkedList.RemoveFirstElement();
            Assert.AreEqual(2, linkedList.head.data);
        }

        [Test]
        public void SSLTest_DeleteLastNode_FirstIsNext()
        {
            var linkedList = new SingleLinkedList();
            linkedList.insertLast(1);
            linkedList.insertLast(2);
            linkedList.insertLast(5);
            linkedList.RemoveLastElement();
            Assert.AreEqual(2, linkedList.head.next.next.data);
        }

        [Test]
        public void TestSLLCount_AddItemsAsNodes_ReturnCorrectCount()
        {
            var myLL = new SingleLinkedList();
            myLL.insertLastNode(new Node(1, null));
            myLL.insertLastNode(new Node(2, null));
            myLL.insertLastNode(new Node(3, null));
            myLL.insertLastNode(new Node(4, null));
            Assert.AreEqual(4, myLL.count());
        }
    }
}