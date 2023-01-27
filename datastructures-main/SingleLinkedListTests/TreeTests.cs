using NUnit.Framework;
using System.Collections.Generic;
using Datastructures;
using System.Text;
using System.IO;
using System;

namespace DatastructureTests
{
    public class TreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

       [Test]
        public void TestInsert_AddNOdes_ReturnRightOrder()
        {
            var tree = new BinaryTree();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(8);

            // Test if the values were inserted correctly
            Assert.AreEqual(5, tree.root.data);
            Assert.AreEqual(3, tree.root.LtNode.data);
            Assert.AreEqual(7, tree.root.RtNode.data);
            Assert.AreEqual(2, tree.root.LtNode.LtNode.data);
            Assert.AreEqual(4, tree.root.LtNode.RtNode.data);
            Assert.AreEqual(6, tree.root.RtNode.LtNode.data);
            Assert.AreEqual(8, tree.root.RtNode.RtNode.data);
        }


        [Test]
        public void TestTreeStructure_DeleteNodes_ReturnRightNodes()
        {
            var tree = new BinaryTree();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(8);
            var sb = new StringBuilder();
            var sw = new StringWriter(sb);
            Console.SetOut(sw);

            tree.PostOrder();

            var expectedOutput = "2 4 3 6 8 7 5 ";
            var actualOutput = sb.ToString();
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}