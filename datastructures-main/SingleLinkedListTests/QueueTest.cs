using Datastructures;
using NUnit.Framework;
using System.Collections.Generic;

namespace DatastructureTests
{
    public class QueueTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Enqueue_Elements_RightQueueOrder()
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(queue.ToString(), "| 1 | 2 | 3 |");
        }

        [Test]
        public void EnqueueAndDeque_Elements_RightQueueOrder()
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            var first = queue.Dequeue();
            Assert.AreEqual(first.data, 1);
            Assert.AreEqual(queue.ToString(), "| 2 | 3 |");
        }
    }
}