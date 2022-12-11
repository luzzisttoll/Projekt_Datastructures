using NUnit.Framework;
using System.Collections.Generic;

namespace DatastructureTests
{
    public class StackTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Stack<string> stack = new Stack<string>();
            string item1 = "Test1", item2 = "Test2";
            stack.Push(item1);
            stack.Push(item2);
            Assert.AreEqual(stack.Pop(), item2);
        }
    }
}