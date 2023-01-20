using NUnit.Framework;
using System.Collections.Generic;
using Datastructures;

namespace DatastructureTests
{
    public class TreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

       [Test]
       public void TestTreeStructure_addNodes_ReturnRightNodes()
        {
            var binTree = new BinaryTree();
            binTree.Insert(11);
            binTree.Insert(21);
            binTree.Insert(78);
            binTree.Insert(31);
            binTree.Insert(101);
            binTree.Insert(51);
            binTree.Insert(82);

            binTree.PostOrder(binTree.Root);
            Assert.AreEqual(binTree.ToString(), "51 31 82 101 78 21 11");
        }
    }
}