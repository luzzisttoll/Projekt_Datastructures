using GenericList;
using MyStack;
using NUnit.Framework;

namespace StackUnitTests
{
    public class QueueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Enqueue_ThreeElements_QueueOrderOK()
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(queue.ToString(), "| 1 | 2 | 3 |");
        }

        [Test]
        public void EnqueueAndDeQueue_EnqueThreeTimesDequeueonce_TwoElementsInQueueFirstOneRemoved()
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