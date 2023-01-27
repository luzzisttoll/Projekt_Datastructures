using Common;
using Datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class BinaryTree
    {
        public Node root;


        public void Insert(int data)
        {
            root = InsertRecursive(root, data);
        }

        private Node InsertRecursive(Node current, int data)
        {
            if (current == null)
            {
                return new Node(data, null);
            }

            if (data < current.data)
            {
                current.LtNode = InsertRecursive(current.LtNode, data);
            }
            else if (data > current.data)
            {
                current.RtNode = InsertRecursive(current.RtNode, data);
            }

            return current;
        }

        public void PostOrder()
        {
            PostOrderRecursive(root);
        }

        private void PostOrderRecursive(Node current)
        {
            if (current == null)
                return;

            PostOrderRecursive(current.LtNode);
            PostOrderRecursive(current.RtNode);
        }

        public int GetDepth()
        {
            return this.GetDepth(root);
        }

        public int GetDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetDepth(parent.LtNode), GetDepth(parent.RtNode)) + 1;
        }

        public void Delete(int value)
        {
            root = Delete(root, value);
        }

        private Node Delete(Node parent, int key)
        {
            if (parent == null)
                return parent;

            if (key < parent.data) 
                parent.LtNode = Delete(parent.LtNode, key);
            else if (key > parent.data)
                parent.RtNode = Delete(parent.RtNode, key);

            // if the value is the same as the parent's value, then this node is to be deleted  
            else
            {
                // the node with one or no child  
                if (parent.LtNode == null)
                    return parent.RtNode;
                else if (parent.RtNode == null)
                    return parent.LtNode;
                // node with two children: Get the inorder successor (smallest in the right subtree)  
                
                parent.data = MinValue(parent.RtNode);
                // Delete the inorder successor  
                parent.RtNode = Delete(parent.RtNode, parent.data);
            }
            return parent;
        }

        private int MinValue(Node node)
        {
            int minv = node.data;
            
            while (node.LtNode != null)
            {
                minv = node.LtNode.data;
                node = node.LtNode;
            }
            return minv;
        }
    }
}

